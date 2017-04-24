namespace WorkMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.clockInTime = new System.Windows.Forms.DateTimePicker();
            this.clockOutTime = new System.Windows.Forms.DateTimePicker();
            this.LunchBreakMin = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HoursLastWeekLabel = new System.Windows.Forms.Label();
            this.HoursForDateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HoursWorkedLabel);
            this.groupBox2.Location = new System.Drawing.Point(309, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hours worked this week";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clock In:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clock Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lunch break:";
            // 
            // DatePicker
            // 
            this.DatePicker.Checked = false;
            this.DatePicker.CustomFormat = "";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatePicker.Location = new System.Drawing.Point(48, 10);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(106, 20);
            this.DatePicker.TabIndex = 6;
            // 
            // clockInTime
            // 
            this.clockInTime.Checked = false;
            this.clockInTime.CustomFormat = "";
            this.clockInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockInTime.Location = new System.Drawing.Point(64, 37);
            this.clockInTime.Name = "clockInTime";
            this.clockInTime.ShowUpDown = true;
            this.clockInTime.Size = new System.Drawing.Size(106, 20);
            this.clockInTime.TabIndex = 7;
            this.clockInTime.Value = new System.DateTime(2017, 4, 18, 8, 0, 0, 0);
            // 
            // clockOutTime
            // 
            this.clockOutTime.Checked = false;
            this.clockOutTime.CustomFormat = "";
            this.clockOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockOutTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clockOutTime.Location = new System.Drawing.Point(72, 66);
            this.clockOutTime.Name = "clockOutTime";
            this.clockOutTime.ShowUpDown = true;
            this.clockOutTime.Size = new System.Drawing.Size(106, 20);
            this.clockOutTime.TabIndex = 8;
            this.clockOutTime.Value = new System.DateTime(2017, 4, 18, 9, 0, 0, 0);
            // 
            // LunchBreakMin
            // 
            this.LunchBreakMin.Location = new System.Drawing.Point(86, 94);
            this.LunchBreakMin.Name = "LunchBreakMin";
            this.LunchBreakMin.Size = new System.Drawing.Size(100, 20);
            this.LunchBreakMin.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(228, 89);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedLabel.Location = new System.Drawing.Point(6, 16);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(151, 37);
            this.HoursWorkedLabel.TabIndex = 0;
            this.HoursWorkedLabel.Text = "0";
            this.HoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HoursLastWeekLabel);
            this.groupBox3.Location = new System.Drawing.Point(309, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 57);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hours worked last week:";
            // 
            // HoursLastWeekLabel
            // 
            this.HoursLastWeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLastWeekLabel.Location = new System.Drawing.Point(6, 14);
            this.HoursLastWeekLabel.Name = "HoursLastWeekLabel";
            this.HoursLastWeekLabel.Size = new System.Drawing.Size(151, 37);
            this.HoursLastWeekLabel.TabIndex = 1;
            this.HoursLastWeekLabel.Text = "0";
            this.HoursLastWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoursForDateButton
            // 
            this.HoursForDateButton.Location = new System.Drawing.Point(212, 9);
            this.HoursForDateButton.Name = "HoursForDateButton";
            this.HoursForDateButton.Size = new System.Drawing.Size(91, 23);
            this.HoursForDateButton.TabIndex = 12;
            this.HoursForDateButton.Text = "Hours for Date";
            this.HoursForDateButton.UseCompatibleTextRendering = true;
            this.HoursForDateButton.UseVisualStyleBackColor = true;
            this.HoursForDateButton.Click += new System.EventHandler(this.HoursForDateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.HoursForDateButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LunchBreakMin);
            this.Controls.Add(this.clockOutTime);
            this.Controls.Add(this.clockInTime);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "MainForm";
            this.Text = "Hours Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker clockInTime;
        private System.Windows.Forms.DateTimePicker clockOutTime;
        private System.Windows.Forms.TextBox LunchBreakMin;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label HoursLastWeekLabel;
        private System.Windows.Forms.Button HoursForDateButton;
    }
}

