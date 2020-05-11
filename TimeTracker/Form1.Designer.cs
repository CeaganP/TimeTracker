namespace TimeTracker
{
    partial class Form1
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
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddTime = new System.Windows.Forms.Button();
            this.listBox_Work = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.listBox_Break = new System.Windows.Forms.ListBox();
            this.checkBox_Break = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_LunchTotal = new System.Windows.Forms.TextBox();
            this.button_ClearFlags = new System.Windows.Forms.Button();
            this.button_Flag = new System.Windows.Forms.Button();
            this.radioButton_AM = new System.Windows.Forms.RadioButton();
            this.radioButton_PM = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Time
            // 
            this.textBox_Time.CausesValidation = false;
            this.textBox_Time.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_Time.Location = new System.Drawing.Point(48, 12);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(57, 20);
            this.textBox_Time.TabIndex = 1;
            this.textBox_Time.Text = "13:00";
            this.textBox_Time.Enter += new System.EventHandler(this.TextBox_Time_Enter);
            this.textBox_Time.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_Time_KeyUp);
            this.textBox_Time.Leave += new System.EventHandler(this.TextBox_Time_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            // 
            // button_AddTime
            // 
            this.button_AddTime.Enabled = false;
            this.button_AddTime.Location = new System.Drawing.Point(12, 64);
            this.button_AddTime.Name = "button_AddTime";
            this.button_AddTime.Size = new System.Drawing.Size(296, 23);
            this.button_AddTime.TabIndex = 2;
            this.button_AddTime.Text = "Add Time";
            this.button_AddTime.UseVisualStyleBackColor = true;
            this.button_AddTime.Click += new System.EventHandler(this.button_AddTime_Click);
            // 
            // listBox_Work
            // 
            this.listBox_Work.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Work.FormattingEnabled = true;
            this.listBox_Work.Location = new System.Drawing.Point(12, 93);
            this.listBox_Work.Name = "listBox_Work";
            this.listBox_Work.Size = new System.Drawing.Size(145, 251);
            this.listBox_Work.TabIndex = 3;
            this.listBox_Work.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_Work_DrawItem);
            this.listBox_Work.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Location = new System.Drawing.Point(208, 12);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(100, 20);
            this.textBox_Total.TabIndex = 0;
            // 
            // listBox_Break
            // 
            this.listBox_Break.FormattingEnabled = true;
            this.listBox_Break.Location = new System.Drawing.Point(163, 93);
            this.listBox_Break.Name = "listBox_Break";
            this.listBox_Break.Size = new System.Drawing.Size(145, 251);
            this.listBox_Break.TabIndex = 6;
            this.listBox_Break.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyUp);
            // 
            // checkBox_Break
            // 
            this.checkBox_Break.AutoSize = true;
            this.checkBox_Break.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Break.Location = new System.Drawing.Point(111, 14);
            this.checkBox_Break.Name = "checkBox_Break";
            this.checkBox_Break.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Break.TabIndex = 7;
            this.checkBox_Break.Text = "Break";
            this.checkBox_Break.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lunch";
            // 
            // textBox_LunchTotal
            // 
            this.textBox_LunchTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_LunchTotal.Enabled = false;
            this.textBox_LunchTotal.Location = new System.Drawing.Point(208, 38);
            this.textBox_LunchTotal.Name = "textBox_LunchTotal";
            this.textBox_LunchTotal.ReadOnly = true;
            this.textBox_LunchTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_LunchTotal.TabIndex = 9;
            // 
            // button_ClearFlags
            // 
            this.button_ClearFlags.Location = new System.Drawing.Point(163, 350);
            this.button_ClearFlags.Name = "button_ClearFlags";
            this.button_ClearFlags.Size = new System.Drawing.Size(145, 23);
            this.button_ClearFlags.TabIndex = 10;
            this.button_ClearFlags.Text = "Clear Flags";
            this.button_ClearFlags.UseVisualStyleBackColor = true;
            this.button_ClearFlags.Click += new System.EventHandler(this.Button_ClearFlag_Click);
            // 
            // button_Flag
            // 
            this.button_Flag.Location = new System.Drawing.Point(12, 350);
            this.button_Flag.Name = "button_Flag";
            this.button_Flag.Size = new System.Drawing.Size(145, 23);
            this.button_Flag.TabIndex = 11;
            this.button_Flag.Text = "Flag";
            this.button_Flag.UseVisualStyleBackColor = true;
            this.button_Flag.Click += new System.EventHandler(this.Button_Flag_Click);
            // 
            // radioButton_AM
            // 
            this.radioButton_AM.AutoSize = true;
            this.radioButton_AM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton_AM.Checked = true;
            this.radioButton_AM.Location = new System.Drawing.Point(7, 8);
            this.radioButton_AM.Name = "radioButton_AM";
            this.radioButton_AM.Size = new System.Drawing.Size(41, 17);
            this.radioButton_AM.TabIndex = 12;
            this.radioButton_AM.TabStop = true;
            this.radioButton_AM.Text = "AM";
            this.radioButton_AM.UseVisualStyleBackColor = true;
            // 
            // radioButton_PM
            // 
            this.radioButton_PM.AutoSize = true;
            this.radioButton_PM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton_PM.Location = new System.Drawing.Point(54, 8);
            this.radioButton_PM.Name = "radioButton_PM";
            this.radioButton_PM.Size = new System.Drawing.Size(41, 17);
            this.radioButton_PM.TabIndex = 13;
            this.radioButton_PM.Text = "PM";
            this.radioButton_PM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButton_PM);
            this.groupBox1.Controls.Add(this.radioButton_AM);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(104, 27);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_AddTime;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 382);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Flag);
            this.Controls.Add(this.button_ClearFlags);
            this.Controls.Add(this.textBox_LunchTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_Break);
            this.Controls.Add(this.listBox_Break);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Work);
            this.Controls.Add(this.button_AddTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddTime;
        private System.Windows.Forms.ListBox listBox_Work;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.ListBox listBox_Break;
        private System.Windows.Forms.CheckBox checkBox_Break;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_LunchTotal;
        private System.Windows.Forms.Button button_ClearFlags;
        private System.Windows.Forms.Button button_Flag;
        private System.Windows.Forms.RadioButton radioButton_AM;
        private System.Windows.Forms.RadioButton radioButton_PM;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

