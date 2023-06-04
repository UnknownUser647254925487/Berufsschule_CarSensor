using System.ComponentModel;
using System.Windows.Forms;

namespace CarSensor_Lernsituation {
    partial class Window {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.Label_Speed = new System.Windows.Forms.Label();
            this.SpeedBox = new System.Windows.Forms.NumericUpDown();
            this.input_left = new System.Windows.Forms.NumericUpDown();
            this.input_middle = new System.Windows.Forms.NumericUpDown();
            this.Label_Right = new System.Windows.Forms.Label();
            this.Label_Middle = new System.Windows.Forms.Label();
            this.Label_Left = new System.Windows.Forms.Label();
            this.input_right = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MeasurmentList = new System.Windows.Forms.DataGridView();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.miniMesswertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_middle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_right)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMesswertBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd;HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Tag = "TimePicker";
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.submitButton.Location = new System.Drawing.Point(651, 5);
            this.submitButton.Name = "submitButton";
            this.tableLayoutPanel2.SetRowSpan(this.submitButton, 2);
            this.submitButton.Size = new System.Drawing.Size(100, 58);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Speed
            // 
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.Location = new System.Drawing.Point(255, 2);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(99, 26);
            this.Label_Speed.TabIndex = 2;
            this.Label_Speed.Text = "Geschwindigkeit in km/h:";
            // 
            // SpeedBox
            // 
            this.SpeedBox.DecimalPlaces = 2;
            this.SpeedBox.Location = new System.Drawing.Point(384, 5);
            this.SpeedBox.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpeedBox.Size = new System.Drawing.Size(93, 20);
            this.SpeedBox.TabIndex = 3;
            this.SpeedBox.Tag = "SpeedBox";
            this.SpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpeedBox.ThousandsSeparator = true;
            // 
            // input_left
            // 
            this.input_left.DecimalPlaces = 2;
            this.input_left.Location = new System.Drawing.Point(384, 101);
            this.input_left.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.input_left.Name = "input_left";
            this.input_left.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_left.Size = new System.Drawing.Size(93, 20);
            this.input_left.TabIndex = 6;
            this.input_left.Tag = "SpeedBox";
            this.input_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_left.ThousandsSeparator = true;
            // 
            // input_middle
            // 
            this.input_middle.DecimalPlaces = 2;
            this.input_middle.Location = new System.Drawing.Point(384, 69);
            this.input_middle.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.input_middle.Name = "input_middle";
            this.input_middle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_middle.Size = new System.Drawing.Size(93, 20);
            this.input_middle.TabIndex = 5;
            this.input_middle.Tag = "SpeedBox";
            this.input_middle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_middle.ThousandsSeparator = true;
            // 
            // Label_Right
            // 
            this.Label_Right.AutoSize = true;
            this.Label_Right.Location = new System.Drawing.Point(255, 34);
            this.Label_Right.Name = "Label_Right";
            this.Label_Right.Size = new System.Drawing.Size(77, 26);
            this.Label_Right.TabIndex = 0;
            this.Label_Right.Text = "Sensor Rechts\r\nAbstand in m:";
            // 
            // Label_Middle
            // 
            this.Label_Middle.AutoSize = true;
            this.Label_Middle.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Middle.Location = new System.Drawing.Point(255, 66);
            this.Label_Middle.Name = "Label_Middle";
            this.Label_Middle.Size = new System.Drawing.Size(71, 26);
            this.Label_Middle.TabIndex = 1;
            this.Label_Middle.Text = "Sensor Mitte\r\nAbstand in m:";
            // 
            // Label_Left
            // 
            this.Label_Left.AutoSize = true;
            this.Label_Left.Location = new System.Drawing.Point(255, 98);
            this.Label_Left.Name = "Label_Left";
            this.Label_Left.Size = new System.Drawing.Size(71, 26);
            this.Label_Left.TabIndex = 2;
            this.Label_Left.Text = "Sensor Links\r\nAbstand in m:";
            // 
            // input_right
            // 
            this.input_right.DecimalPlaces = 2;
            this.input_right.Location = new System.Drawing.Point(384, 37);
            this.input_right.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.input_right.Name = "input_right";
            this.input_right.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_right.Size = new System.Drawing.Size(93, 20);
            this.input_right.TabIndex = 4;
            this.input_right.Tag = "SpeedBox";
            this.input_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_right.ThousandsSeparator = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScrollMargin = new System.Drawing.Size(2, 50);
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.input_left, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.input_middle, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label_Speed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.input_right, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label_Left, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.Label_Middle, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label_Right, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.SpeedBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.submitButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.refreshButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 132);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.refreshButton.Location = new System.Drawing.Point(691, 69);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(60, 26);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 57);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Tag = "Heading";
            this.label1.Text = "Abstandsmesser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeasurmentList
            // 
            this.MeasurmentList.AllowUserToDeleteRows = false;
            this.MeasurmentList.AllowUserToOrderColumns = true;
            this.MeasurmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.MeasurmentList, 2);
            this.MeasurmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasurmentList.Location = new System.Drawing.Point(0, 199);
            this.MeasurmentList.Margin = new System.Windows.Forms.Padding(0);
            this.MeasurmentList.Name = "MeasurmentList";
            this.MeasurmentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MeasurmentList.Size = new System.Drawing.Size(756, 199);
            this.MeasurmentList.TabIndex = 7;
            this.MeasurmentList.Tag = "Display";
            this.MeasurmentList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MeasurmentList_CellFormatting);
            // 
            // chartPie
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea3);
            this.chartPie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartPie.Legends.Add(legend3);
            this.chartPie.Location = new System.Drawing.Point(3, 3);
            this.chartPie.Name = "chartPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPie.Series.Add(series3);
            this.chartPie.Size = new System.Drawing.Size(372, 193);
            this.chartPie.TabIndex = 0;
            this.chartPie.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Gesmantanzahl der Messwerte mit Genug Abstand";
            this.chartPie.Titles.Add(title3);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartPie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MeasurmentList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartLine, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 398);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // chartLine
            // 
            chartArea4.Name = "ChartArea1";
            this.chartLine.ChartAreas.Add(chartArea4);
            this.chartLine.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartLine.Legends.Add(legend4);
            this.chartLine.Location = new System.Drawing.Point(381, 3);
            this.chartLine.Name = "chartLine";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Relativ gehaltener Abstand in m";
            this.chartLine.Series.Add(series4);
            this.chartLine.Size = new System.Drawing.Size(372, 193);
            this.chartLine.TabIndex = 8;
            this.chartLine.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Abstand/Soll-Abstand nach Zeit";
            this.chartLine.Titles.Add(title4);
            // 
            // miniMesswertBindingSource
            // 
            this.miniMesswertBindingSource.DataSource = typeof(MiniMesswert);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "💀";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "Window";
            this.Text = "Abstandsmesser";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_middle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_right)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMesswertBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label Label_Speed;
        private System.Windows.Forms.NumericUpDown SpeedBox;
        private System.Windows.Forms.NumericUpDown input_left;
        private System.Windows.Forms.NumericUpDown input_middle;
        private System.Windows.Forms.NumericUpDown input_right;
        private System.Windows.Forms.Label Label_Right;
        private System.Windows.Forms.Label Label_Middle;
        private System.Windows.Forms.Label Label_Left;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private DataGridView MeasurmentList;
        private Button refreshButton;
        private BindingSource miniMesswertBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLine;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sensorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enoughDistDataGridViewTextBoxColumn;
        private Button button1;
    }
}

