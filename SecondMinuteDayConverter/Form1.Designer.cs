namespace SecondMinuteDayConverter {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtValue = new System.Windows.Forms.TextBox();
            this.rdnYear = new System.Windows.Forms.RadioButton();
            this.rdnMonth = new System.Windows.Forms.RadioButton();
            this.rdnWeek = new System.Windows.Forms.RadioButton();
            this.rdnDay = new System.Windows.Forms.RadioButton();
            this.rdnHour = new System.Windows.Forms.RadioButton();
            this.rdnMinute = new System.Windows.Forms.RadioButton();
            this.rdnSecond = new System.Windows.Forms.RadioButton();
            this.rdnYear2 = new System.Windows.Forms.RadioButton();
            this.rdnMonth2 = new System.Windows.Forms.RadioButton();
            this.rdnWeek2 = new System.Windows.Forms.RadioButton();
            this.rdnDay2 = new System.Windows.Forms.RadioButton();
            this.rdnHour2 = new System.Windows.Forms.RadioButton();
            this.rdnMinute2 = new System.Windows.Forms.RadioButton();
            this.rdnSecond2 = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtValue.Location = new System.Drawing.Point(7, 17);
            this.txtValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(371, 20);
            this.txtValue.TabIndex = 6;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // rdnYear
            // 
            this.rdnYear.AutoSize = true;
            this.rdnYear.Location = new System.Drawing.Point(333, 19);
            this.rdnYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnYear.Name = "rdnYear";
            this.rdnYear.Size = new System.Drawing.Size(47, 17);
            this.rdnYear.TabIndex = 5;
            this.rdnYear.TabStop = true;
            this.rdnYear.Text = "Year";
            this.rdnYear.UseVisualStyleBackColor = true;
            this.rdnYear.Click += new System.EventHandler(this.rdnYear_Click);
            // 
            // rdnMonth
            // 
            this.rdnMonth.AutoSize = true;
            this.rdnMonth.Location = new System.Drawing.Point(277, 19);
            this.rdnMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnMonth.Name = "rdnMonth";
            this.rdnMonth.Size = new System.Drawing.Size(55, 17);
            this.rdnMonth.TabIndex = 4;
            this.rdnMonth.TabStop = true;
            this.rdnMonth.Text = "Month";
            this.rdnMonth.UseVisualStyleBackColor = true;
            this.rdnMonth.Click += new System.EventHandler(this.rdnMonth_Click);
            // 
            // rdnWeek
            // 
            this.rdnWeek.AutoSize = true;
            this.rdnWeek.Location = new System.Drawing.Point(223, 19);
            this.rdnWeek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnWeek.Name = "rdnWeek";
            this.rdnWeek.Size = new System.Drawing.Size(54, 17);
            this.rdnWeek.TabIndex = 1;
            this.rdnWeek.TabStop = true;
            this.rdnWeek.Text = "Week";
            this.rdnWeek.UseVisualStyleBackColor = true;
            this.rdnWeek.Click += new System.EventHandler(this.rdnWeek_Click);
            // 
            // rdnDay
            // 
            this.rdnDay.AutoSize = true;
            this.rdnDay.Location = new System.Drawing.Point(177, 19);
            this.rdnDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnDay.Name = "rdnDay";
            this.rdnDay.Size = new System.Drawing.Size(44, 17);
            this.rdnDay.TabIndex = 3;
            this.rdnDay.TabStop = true;
            this.rdnDay.Text = "Day";
            this.rdnDay.UseVisualStyleBackColor = true;
            this.rdnDay.Click += new System.EventHandler(this.rdnDay_Click);
            // 
            // rdnHour
            // 
            this.rdnHour.AutoSize = true;
            this.rdnHour.Location = new System.Drawing.Point(128, 19);
            this.rdnHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnHour.Name = "rdnHour";
            this.rdnHour.Size = new System.Drawing.Size(48, 17);
            this.rdnHour.TabIndex = 2;
            this.rdnHour.TabStop = true;
            this.rdnHour.Text = "Hour";
            this.rdnHour.UseVisualStyleBackColor = true;
            this.rdnHour.Click += new System.EventHandler(this.rdnHour_Click);
            // 
            // rdnMinute
            // 
            this.rdnMinute.AutoSize = true;
            this.rdnMinute.Location = new System.Drawing.Point(70, 19);
            this.rdnMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnMinute.Name = "rdnMinute";
            this.rdnMinute.Size = new System.Drawing.Size(57, 17);
            this.rdnMinute.TabIndex = 1;
            this.rdnMinute.TabStop = true;
            this.rdnMinute.Text = "Minute";
            this.rdnMinute.UseVisualStyleBackColor = true;
            this.rdnMinute.Click += new System.EventHandler(this.rdnMinute_Click);
            // 
            // rdnSecond
            // 
            this.rdnSecond.AutoSize = true;
            this.rdnSecond.Location = new System.Drawing.Point(7, 19);
            this.rdnSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnSecond.Name = "rdnSecond";
            this.rdnSecond.Size = new System.Drawing.Size(62, 17);
            this.rdnSecond.TabIndex = 0;
            this.rdnSecond.TabStop = true;
            this.rdnSecond.Text = "Second";
            this.rdnSecond.UseVisualStyleBackColor = true;
            this.rdnSecond.Click += new System.EventHandler(this.rdnSecond_Click);
            // 
            // rdnYear2
            // 
            this.rdnYear2.AutoSize = true;
            this.rdnYear2.Location = new System.Drawing.Point(333, 20);
            this.rdnYear2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnYear2.Name = "rdnYear2";
            this.rdnYear2.Size = new System.Drawing.Size(47, 17);
            this.rdnYear2.TabIndex = 5;
            this.rdnYear2.TabStop = true;
            this.rdnYear2.Text = "Year";
            this.rdnYear2.UseVisualStyleBackColor = true;
            this.rdnYear2.Click += new System.EventHandler(this.rdnYear2_Click);
            // 
            // rdnMonth2
            // 
            this.rdnMonth2.AutoSize = true;
            this.rdnMonth2.Location = new System.Drawing.Point(277, 20);
            this.rdnMonth2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnMonth2.Name = "rdnMonth2";
            this.rdnMonth2.Size = new System.Drawing.Size(55, 17);
            this.rdnMonth2.TabIndex = 4;
            this.rdnMonth2.TabStop = true;
            this.rdnMonth2.Text = "Month";
            this.rdnMonth2.UseVisualStyleBackColor = true;
            this.rdnMonth2.Click += new System.EventHandler(this.rdnMonth2_Click);
            // 
            // rdnWeek2
            // 
            this.rdnWeek2.AutoSize = true;
            this.rdnWeek2.Location = new System.Drawing.Point(223, 20);
            this.rdnWeek2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnWeek2.Name = "rdnWeek2";
            this.rdnWeek2.Size = new System.Drawing.Size(54, 17);
            this.rdnWeek2.TabIndex = 1;
            this.rdnWeek2.TabStop = true;
            this.rdnWeek2.Text = "Week";
            this.rdnWeek2.UseVisualStyleBackColor = true;
            this.rdnWeek2.Click += new System.EventHandler(this.rdnWeek2_Click);
            // 
            // rdnDay2
            // 
            this.rdnDay2.AutoSize = true;
            this.rdnDay2.Location = new System.Drawing.Point(177, 20);
            this.rdnDay2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnDay2.Name = "rdnDay2";
            this.rdnDay2.Size = new System.Drawing.Size(44, 17);
            this.rdnDay2.TabIndex = 3;
            this.rdnDay2.TabStop = true;
            this.rdnDay2.Text = "Day";
            this.rdnDay2.UseVisualStyleBackColor = true;
            this.rdnDay2.Click += new System.EventHandler(this.rdnDay2_Click);
            // 
            // rdnHour2
            // 
            this.rdnHour2.AutoSize = true;
            this.rdnHour2.Location = new System.Drawing.Point(128, 20);
            this.rdnHour2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnHour2.Name = "rdnHour2";
            this.rdnHour2.Size = new System.Drawing.Size(48, 17);
            this.rdnHour2.TabIndex = 2;
            this.rdnHour2.TabStop = true;
            this.rdnHour2.Text = "Hour";
            this.rdnHour2.UseVisualStyleBackColor = true;
            this.rdnHour2.Click += new System.EventHandler(this.rdnHour2_Click);
            // 
            // rdnMinute2
            // 
            this.rdnMinute2.AutoSize = true;
            this.rdnMinute2.Location = new System.Drawing.Point(70, 20);
            this.rdnMinute2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnMinute2.Name = "rdnMinute2";
            this.rdnMinute2.Size = new System.Drawing.Size(57, 17);
            this.rdnMinute2.TabIndex = 1;
            this.rdnMinute2.TabStop = true;
            this.rdnMinute2.Text = "Minute";
            this.rdnMinute2.UseVisualStyleBackColor = true;
            this.rdnMinute2.Click += new System.EventHandler(this.rdnMinute2_Click);
            // 
            // rdnSecond2
            // 
            this.rdnSecond2.AutoSize = true;
            this.rdnSecond2.Location = new System.Drawing.Point(7, 20);
            this.rdnSecond2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnSecond2.Name = "rdnSecond2";
            this.rdnSecond2.Size = new System.Drawing.Size(62, 17);
            this.rdnSecond2.TabIndex = 0;
            this.rdnSecond2.TabStop = true;
            this.rdnSecond2.Text = "Second";
            this.rdnSecond2.UseVisualStyleBackColor = true;
            this.rdnSecond2.Click += new System.EventHandler(this.rdnSecond2_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(7, 205);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(384, 48);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnSecond);
            this.groupBox1.Controls.Add(this.rdnYear);
            this.groupBox1.Controls.Add(this.rdnMinute);
            this.groupBox1.Controls.Add(this.rdnMonth);
            this.groupBox1.Controls.Add(this.rdnHour);
            this.groupBox1.Controls.Add(this.rdnWeek);
            this.groupBox1.Controls.Add(this.rdnDay);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(384, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdnSecond2);
            this.groupBox2.Controls.Add(this.rdnYear2);
            this.groupBox2.Controls.Add(this.rdnMinute2);
            this.groupBox2.Controls.Add(this.rdnMonth2);
            this.groupBox2.Controls.Add(this.rdnHour2);
            this.groupBox2.Controls.Add(this.rdnWeek2);
            this.groupBox2.Controls.Add(this.rdnDay2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(7, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(384, 46);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second Selection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValue);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(7, 56);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(384, 44);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Value";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblResult);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(7, 152);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(384, 44);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(8, 19);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 20);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(400, 263);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RadioButton rdnYear;
        private System.Windows.Forms.RadioButton rdnMonth;
        private System.Windows.Forms.RadioButton rdnWeek;
        private System.Windows.Forms.RadioButton rdnDay;
        private System.Windows.Forms.RadioButton rdnHour;
        private System.Windows.Forms.RadioButton rdnMinute;
        private System.Windows.Forms.RadioButton rdnSecond;
        private System.Windows.Forms.RadioButton rdnYear2;
        private System.Windows.Forms.RadioButton rdnMonth2;
        private System.Windows.Forms.RadioButton rdnWeek2;
        private System.Windows.Forms.RadioButton rdnDay2;
        private System.Windows.Forms.RadioButton rdnHour2;
        private System.Windows.Forms.RadioButton rdnMinute2;
        private System.Windows.Forms.RadioButton rdnSecond2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblResult;
    }
}

