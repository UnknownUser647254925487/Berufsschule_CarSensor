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

namespace CarSensor_Lernsituation {
    public partial class Window : Form {
        readonly static Messwert.Sensor sensorL = Messwert.Sensor.sensorL, sensorM = Messwert.Sensor.sensorM, sensorR = Messwert.Sensor.sensorR;
        readonly static string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
        readonly static string filePath = Path.Combine(directoryPath, @"SensorData.txt");
        BindingSource measuredData = new  BindingSource();


        //Code to be executed 'before' UI is built
        private void ReadFile(String filePath, DataGridView table) {
            StreamReader leseStream = new StreamReader(filePath);
            Debug.Write("Reading:");
            int i = 0;
            while (leseStream.Peek() > 0) {
                String line = leseStream.ReadLine();
                try {
                    measuredData.Add(new MiniMesswert(messwertFromString(line)));
                    i++;
                }catch (Exception ex) {
                    Debug.WriteLine(ex.ToString());
                }
            }
            Debug.WriteLine($"Read: {i} lines");
            leseStream.Close();
        }



        public Window() {
            InitializeComponent();
            InitializeTable();
        }

        private void InitializeTable() {
            MeasurmentList.DataSource = measuredData;

            // Initialize and add a text box column for the Time
            DataGridViewColumn timeCol = new DataGridViewTextBoxColumn();
            timeCol.DataPropertyName = "time";
            timeCol.Name = "Zeitpunkt";
            MeasurmentList.Columns.Add(timeCol);
            // Initialize and add a text box column for the Speed
            DataGridViewColumn speedCol = new DataGridViewTextBoxColumn();
            speedCol.DataPropertyName = "speed";
            speedCol.Name = "Geschwindigkeit";
            MeasurmentList.Columns.Add(speedCol);
            // Initialize and add a text box column for the Speed
            DataGridViewColumn sensorCol = new DataGridViewTextBoxColumn();
            sensorCol.DataPropertyName = "speed";
            sensorCol.Name = "Geschwindigkeit";
            MeasurmentList.Columns.Add(sensorCol);
            // Initialize and add a text box column for the min. Distance
            DataGridViewColumn distanceCol = new DataGridViewTextBoxColumn();
            distanceCol.DataPropertyName = "distance";
            distanceCol.Name = "Abstand";
            MeasurmentList.Columns.Add(distanceCol);
            // Initialize and add a text box column for weather enough distance was held
            DataGridViewColumn enoughCol = new DataGridViewTextBoxColumn();
            enoughCol.Name = "Genug Abstand gehalten?";
            MeasurmentList.Columns.Add(enoughCol);
        }

        //Submit-button
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
                safeToFile(filePath, data);
                //add new 'Object' to the List of already exiting ones
                measuredData.Add(data);
            }catch (Exception ex) { 
                Debug.WriteLine(ex);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        private void chart1_Click(object sender, EventArgs e) {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }


        //Code that will be executed on button click
        string time;
        double speed, distanceL, distanceM, distanceR;

        private void SpeedBox_ValueChanged(object sender, EventArgs e) {

        }

        private void MeasurmentList_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void messwertBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            ReadFile(filePath, MeasurmentList);
        }



        public static string newLines(int count) {
            return new string('\n', count);
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
            } else if (parts.Length > 7) {
                sens2 = sensorFromString(parts[5]);
                distance2 = double.Parse(parts[6]);
                sens3 = sensorFromString(parts[7]);
                distance3 = double.Parse(parts[8]);
                lineMesswert = new Messwert(time, speed, sens1, distance1, sens2, distance2, sens3, distance3);
            } else {
                lineMesswert = new Messwert(time, speed, sens1, distance1);
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

        public static void safeToFile(string filePath, Messwert data) {
            try {
                //create *appending* StreamWriter
                StreamWriter StreamWriter = new StreamWriter(filePath, true);
                //save data to file
                StreamWriter.WriteLine(data.toString());
                StreamWriter.Close();
            } catch (Exception exceptions) {
                MessageBox.Show($"ooops, something went wrong processing your inputs{newLines(3)}{exceptions.Message}");
                Debug.WriteLine(exceptions);
            }
        }
    }
}
