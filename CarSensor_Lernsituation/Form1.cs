/*
 * @author アンドレアス
 * in group with Josia Happel & Jonas Hesse
 */


using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace CarSensor_Lernsituation {
    public partial class Window : Form {
        static string directory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        static string filePath = System.IO.Path.Combine(directory, @"SensorData.txt");
        ArrayList fileData = new ArrayList();


        //Code executed 'before' UI is built
        private void readFile(String filePath) {
            StreamReader leseStream = new StreamReader(filePath);
            while (!leseStream.EndOfStream) {
                fileData.Add(leseStream.ReadLine());
            }
            leseStream.Close();
        }
  



    public Window() {
            InitializeComponent();
        }

        private void main() {
            
        }
        

        private void button1_Click(object sender, EventArgs e) {

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

        Messwert.Sensor sensorL = Messwert.Sensor.sensorL, sensorM = Messwert.Sensor.sensorM, sensorR = Messwert.Sensor.sensorR;
        private void submitButton_MouseClick(object sender, MouseEventArgs e) {
            StreamWriter StreamWriter = new StreamWriter(filePath);
            
            try {
                //save & convert inputs of the UI elements
                time = dateTimePicker1.Text;
                speed = (double)SpeedBox.Value;
                distanceL = (double)input_left.Value;
                distanceM = (double)input_middle.Value;
                distanceR = (double)input_right.Value;

                //create new Messwert 'Object' (for better formatting and consitancy)
                Messwert data;
                if (distanceL > 0 && distanceM <= 0 && distanceR <= 0) {
                    data = new Messwert(time, speed, Messwert.Sensor.sensorL, distanceL);
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
                    throw new ArgumentOutOfRangeException("At least one distance has to be greater than 0");
                }
                //add new 'Object' to the List of already exiting ones
                fileData.Add(data);
                //save data to file
                StreamWriter.Write(data.ToString(), true); //TODO: Test & Fix StreamWriter
                StreamWriter.Close();
            } catch (Exception exceptions) {
                MessageBox.Show($"ooops, something went wrong processing your inputs{newLines(3)}{exceptions.Message}");
            }
        }

        public static string newLines(int count) {
            return new string('\n', count);
        }
    }
}
