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

        //Code that will be executed on button click
        string time;
        double speed, distanceL, distanceM, distanceR;


        //Code to be executed 'before' UI is built
        private void ReadFile(String filePath, DataGridView table) {
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

        public Window() {
            InitializeComponent();
            InitializeTable();
        }

        private void InitializeTable() {
            MeasurmentList.DataSource = measuredData;
            MeasurmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MeasurmentList.AutoGenerateColumns = true;
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
                measuredData.Add(new MiniMesswert(data));
            }catch (Exception ex) { 
                Debug.WriteLine(ex);
            }
        }

        
        private void Form1_Load(object sender, EventArgs e) {

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

        public static void safeToFile(string filePath, Messwert data) {
            try {
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
    }
}
