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
        static string filePath = @"..\..\..\CarSensor_Lernsituation\assets\SensorData.txt";
        static string directorys = @"..\..\..\CarSensor_Lernsituation\assets\";
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
            try {
                System.IO.Directory.CreateDirectory(directorys);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
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
        //Code that will be executed on button click
        string time, speed, distanceL, distanceM, distanceR;

        private void chart1_Click(object sender, EventArgs e) {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        string sensorL = "SL", sensorM = "SM", sensorR = "SR";
        private void submitButton_MouseClick(object sender, MouseEventArgs e) {
            StreamWriter StreamWriter = new StreamWriter(filePath);
            
            try {
                time = dateTimePicker1.Text;
                speed = SpeedBox.Value.ToString();
                distanceL = input_left.Value.ToString();
                distanceM = input_middle.Value.ToString();
                distanceR = input_right.Value.ToString();
                StreamWriter.WriteLine($"{sensorL}; {time}; {speed}; {distanceL}");
                StreamWriter.WriteLine($"{sensorM}; {time}; {speed}; {distanceM}");
                StreamWriter.WriteLine($"{sensorR}; {time}; {speed}; {distanceR}");
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
