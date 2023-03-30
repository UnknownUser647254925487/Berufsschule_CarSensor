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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_middle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_right)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd; HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Tag = "TimePicker";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.submitButton.Location = new System.Drawing.Point(621, 5);
            this.submitButton.Name = "submitButton";
            this.tableLayoutPanel2.SetRowSpan(this.submitButton, 2);
            this.submitButton.Size = new System.Drawing.Size(100, 58);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            this.submitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.submitButton_MouseClick);
            // 
            // Label_Speed
            // 
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.Location = new System.Drawing.Point(245, 2);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(99, 26);
            this.Label_Speed.TabIndex = 2;
            this.Label_Speed.Text = "Geschwindigkeit in km/h:";
            // 
            // SpeedBox
            // 
            this.SpeedBox.DecimalPlaces = 2;
            this.SpeedBox.Location = new System.Drawing.Point(368, 5);
            this.SpeedBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
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
            this.input_left.Location = new System.Drawing.Point(368, 101);
            this.input_left.Maximum = new decimal(new int[] {
            600,
            0,
            0,
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
            this.input_middle.Location = new System.Drawing.Point(368, 69);
            this.input_middle.Maximum = new decimal(new int[] {
            600,
            0,
            0,
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
            this.Label_Right.Location = new System.Drawing.Point(245, 34);
            this.Label_Right.Name = "Label_Right";
            this.Label_Right.Size = new System.Drawing.Size(77, 26);
            this.Label_Right.TabIndex = 0;
            this.Label_Right.Text = "Sensor Rechts\r\nAbstand in m:";
            // 
            // Label_Middle
            // 
            this.Label_Middle.AutoSize = true;
            this.Label_Middle.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Middle.Location = new System.Drawing.Point(245, 66);
            this.Label_Middle.Name = "Label_Middle";
            this.Label_Middle.Size = new System.Drawing.Size(71, 26);
            this.Label_Middle.TabIndex = 1;
            this.Label_Middle.Text = "Sensor Mitte\r\nAbstand in m:";
            // 
            // Label_Left
            // 
            this.Label_Left.AutoSize = true;
            this.Label_Left.Location = new System.Drawing.Point(245, 98);
            this.Label_Left.Name = "Label_Left";
            this.Label_Left.Size = new System.Drawing.Size(71, 26);
            this.Label_Left.TabIndex = 2;
            this.Label_Left.Text = "Sensor Links\r\nAbstand in m:";
            // 
            // input_right
            // 
            this.input_right.DecimalPlaces = 2;
            this.input_right.Location = new System.Drawing.Point(368, 37);
            this.input_right.Maximum = new decimal(new int[] {
            600,
            0,
            0,
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 132);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 57);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Tag = "Heading";
            this.label1.Text = "Abstandsmesser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(726, 296);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Tag = "Display";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "Window";
            this.Text = "Abstandsmesser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_middle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_right)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DataGridView dataGridView1;
    }
}

