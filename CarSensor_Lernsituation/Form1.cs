/*
 * @author アンドレアス
 * in group with Josia Happel & Jonas Hesse
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace CarSensor_Lernsituation {
    public partial class Window : Form {
        #region Setup
        readonly static Messwert.Sensor sensorL = Messwert.Sensor.sensorL, sensorM = Messwert.Sensor.sensorM, sensorR = Messwert.Sensor.sensorR;
        readonly static string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
        readonly static string filePath = Path.Combine(directoryPath, @"SensorData.txt");
        readonly static string dataLine = "Relativ gehaltener Abstand in m";
        static BindingSource measuredData = new  BindingSource();
        static string time;
        static double speed, distanceL, distanceM, distanceR;
        #endregion


        public Window() {
            InitializeComponent();
            InitializeTable();
            reloadTable();
            paintPieChart();
            paintLineChart();
        }

        #region Charts
        public void rePaintCharts() {
            paintPieChart();
            paintLineChart();
        }

        private void InitializeTable() {
            MeasurmentList.DataSource = measuredData;
            MeasurmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MeasurmentList.AutoGenerateColumns = true;
        }

        private void paintPieChart() {
            chartPie.Series["Series1"].Points.Clear();
            chartPie.Series["Series1"].Points.AddXY("Genug Abstand", enoughDistNum(measuredData));
            chartPie.Series["Series1"].Points.AddXY("Zu wenig Abstand", notEnoughDistNum(measuredData));
        }

        private void paintLineChart() {
            chartLine.Series[dataLine].Points.Clear();
            foreach (MiniMesswert miniMess in measuredData)
            {
                chartLine.Series[dataLine].Points.AddXY(timeFromString(miniMess.Time),miniMess.EnoughDist);
            }
        }


        private int enoughDistNum(BindingSource bindingSouce) {
            int enoughDist =0;
            foreach (MiniMesswert miniMess in bindingSouce)
            {
                if(miniMess.EnoughDist >= 0) { enoughDist++; }
            }
            Debug.WriteLine($"Anzahl genug Abstand: {enoughDist}");
            return enoughDist;
        }

        private int notEnoughDistNum(BindingSource bindingSouce) {
            int notEnoughDist = 0;
            foreach (MiniMesswert miniMess in bindingSouce) {
                if (miniMess.EnoughDist < 0) { notEnoughDist++; }
            }
            Debug.WriteLine($"Anzahl zu wenig Abstand: {notEnoughDist}");
            return notEnoughDist;
        }
        #endregion

        #region Submit-Button
        private void button1_Click(object sender, EventArgs e) {
            time = dateTimePicker1.Text;
            speed = (double)SpeedBox.Value;
            distanceL = (double)input_left.Value;
            distanceM = (double)input_middle.Value;
            distanceR = (double)input_right.Value;

            //create new Messwert 'Object' (for better formatting and consitancy)
            Messwert data = new Messwert();
            if (distanceL > 0 && distanceM <= 0 && distanceR <= 0) {
                data = new Messwert(time, speed, sensorL, distanceL);
            } else if (distanceL <= 0 && distanceM > 0 && distanceR <= 0) {
                data = new Messwert(time, speed, sensorM, distanceM);
            } else if (distanceL <= 0 && distanceM <= 0 && distanceR > 0) {
                data = new Messwert(time, speed, sensorR, distanceR);
            } else if (distanceL <= 0 && distanceM > 0 && distanceR > 0) {
                data = new Messwert(time, speed, sensorM, distanceM, sensorR, distanceR);
            } else if (distanceL > 0 && distanceM <= 0 && distanceR > 0) {
                data = new Messwert(time, speed, sensorL, distanceL, sensorR, distanceR);
            } else if (distanceL > 0 && distanceM > 0 && distanceR <= 0) {
                data = new Messwert(time, speed, sensorL, distanceL, sensorM, distanceM);
            } else if (distanceL > 0 && distanceM > 0 && distanceR > 0) {
                data = new Messwert(time, speed, sensorL, distanceL, sensorM, distanceM, sensorR, distanceR);
            } else {
                MessageBox.Show($"Mindestends ein Sensor muss einen Abstand >0 haben!");
            }
            try {
                saveToFile(filePath, data);
                //add new 'Object' to the List of already exiting ones
                measuredData.Add(new MiniMesswert(data));
            }catch (Exception ex) { 
                Debug.WriteLine(ex);
            }
            //time updates on submit to current time
            dateTimePicker1.Text = DateTime.Now.ToString();
            reloadTable();
            rePaintCharts();
        }
        #endregion

        #region Tablepainter
        //change Colour of cells according to distance held
        private void MeasurmentList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 4 && e.Value != null) {
                double colorDist = (double)e.Value;
                if (colorDist < 0) {
                    e.CellStyle.BackColor = Color.OrangeRed;
                }else if (colorDist > 0) {
                    e.CellStyle.BackColor = Color.LightGreen;
                }else {
                    e.CellStyle.BackColor = Color.FromArgb(190,250,180);
                }
            }
        }
        #endregion

        #region Refresh-Button
        private void button2_Click(object sender, EventArgs e) {
            dateTimePicker1.Text = DateTime.Now.ToString();
            rePaintCharts();
            reloadTable();
        }
        #endregion
        private void reloadTable() {
            measuredData.Clear();
            ReadFile(filePath, MeasurmentList);
        }

        public static string newLines(int count) {
            return new string('\n', count);
        }

        #region File interactions
        private void ReadFile(String filePath, DataGridView table) {
            checkForFile(filePath);
            StreamReader leseStream = new StreamReader(filePath);
            Debug.WriteLine("Reading:");
            int i = 0;
            while (leseStream.Peek() > 0) {
                String line = leseStream.ReadLine();
                try {
                    Messwert Mess = (messwertFromString(line));
                    MiniMesswert miniMess = new MiniMesswert(Mess);
                    measuredData.Add(miniMess);
                    Debug.WriteLine("MiniMess: " + miniMess.toString());
                    Debug.WriteLine("Mess: "+Mess.toString());
                    i++;
                } catch (Exception ex) {
                    Debug.WriteLine("ReadFile:\n"+ex.ToString());
                }
            }
            Debug.WriteLine($"Read: {i} lines from: {filePath}");
            leseStream.Close();
            }

        public static Messwert messwertFromString(string str) {
            String time;
            double speed, distance1, distance2, distance3;
            Messwert.Sensor sens1, sens2, sens3;
            Messwert lineMesswert;

            String[] parts = str.Split(';');
            time = $"{parts[0]}; {parts[1]}";
            speed = double.Parse(parts[2]);
            sens1 = sensorFromString(parts[3]);
            distance1 = double.Parse(parts[4]);
            if (parts.Length > 5 && parts.Length <= 6) {
                sens2 = sensorFromString(parts[5]);
                distance2 = double.Parse(parts[6]);
                lineMesswert = new Messwert(time, speed, sens1, distance1, sens2, distance2);
                Debug.WriteLine("M2");
            } else if (parts.Length > 7) {
                sens2 = sensorFromString(parts[5]);
                distance2 = double.Parse(parts[6]);
                sens3 = sensorFromString(parts[7]);
                distance3 = double.Parse(parts[8]);
                lineMesswert = new Messwert(time, speed, sens1, distance1, sens2, distance2, sens3, distance3);
                Debug.WriteLine("M3");
            } else {
                lineMesswert = new Messwert(time, speed, sens1, distance1);
                Debug.WriteLine("M1");
            }
            return lineMesswert;
        }

        public static Messwert.Sensor sensorFromString(string str){
            if (str.Equals("SL")) { return Messwert.Sensor.sensorL; }
            else if (str.Equals("SM")) { return Messwert.Sensor.sensorM; }
            else if (str.Equals("SR")) { return Messwert.Sensor.sensorR; }
            else {
                throw new ArgumentException("Error on converting the sensor");
            }
        }
        private DateTime timeFromString(string timestring) {
            DateTime timeStamp = new DateTime();
            try { 
                timeStamp = DateTime.ParseExact(timestring, "yyyy-MM-dd; HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }catch (Exception ex) { //don't just catch any exception, it will kill the code, thanks
                Debug.WriteLine($"Aaaaaaaaaaaaaaaaahhhhhhhhhhh\n{ex}");
            }
            return timeStamp;
        }

        public static void saveToFile(string filePath, Messwert data) {
            try {
                checkForFile(filePath);
                //create *appending* StreamWriter
                StreamWriter StreamWriter = new StreamWriter(filePath, true);
                //save data to file
                StreamWriter.WriteLine(data.toString());
                StreamWriter.Close();
                Debug.WriteLine($"Succesfully safed data to the file: {filePath}");
            } catch (Exception exceptions) {
                MessageBox.Show($"ooops, something went wrong processing your inputs{newLines(3)}{exceptions.Message}");
                Debug.WriteLine(exceptions);
            }
        }

        public static void checkForFile(String path) {
            if (!File.Exists(path)) {
                FileStream fs = File.Create(path,1,FileOptions.WriteThrough);
                fs.Close();
            }
        }
        #endregion
    }
}
