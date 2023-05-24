using System;

namespace Prayer_Timing_Project
{
    partial class windowLabel
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
        private void windowLabel_Load_1(object sender, EventArgs e)
        {
            // Event handler code
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSunrise = new System.Windows.Forms.Label();
            this.txtSunset = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.txtFajr = new System.Windows.Forms.Label();
            this.txtDhuhr = new System.Windows.Forms.Label();
            this.txtAsr = new System.Windows.Forms.Label();
            this.txtMaghrib = new System.Windows.Forms.Label();
            this.txtIsha = new System.Windows.Forms.Label();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItem1.Text = "Home";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.helpToolStripMenuItem.Text = "Option";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "sunrise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "sunset";
            // 
            // txtSunrise
            // 
            this.txtSunrise.AutoSize = true;
            this.txtSunrise.Location = new System.Drawing.Point(50, 133);
            this.txtSunrise.Name = "txtSunrise";
            this.txtSunrise.Size = new System.Drawing.Size(28, 16);
            this.txtSunrise.TabIndex = 7;
            this.txtSunrise.Text = "___";
            // 
            // txtSunset
            // 
            this.txtSunset.AutoSize = true;
            this.txtSunset.Location = new System.Drawing.Point(227, 133);
            this.txtSunset.Name = "txtSunset";
            this.txtSunset.Size = new System.Drawing.Size(28, 16);
            this.txtSunset.TabIndex = 8;
            this.txtSunset.Text = "___";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(339, 39);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 22);
            this.DateTime.TabIndex = 9;
            // 
            // txtFajr
            // 
            this.txtFajr.AutoSize = true;
            this.txtFajr.Location = new System.Drawing.Point(193, 205);
            this.txtFajr.Name = "txtFajr";
            this.txtFajr.Size = new System.Drawing.Size(42, 16);
            this.txtFajr.TabIndex = 10;
            this.txtFajr.Text = "txtFajr";
            // 
            // txtDhuhr
            // 
            this.txtDhuhr.AutoSize = true;
            this.txtDhuhr.Location = new System.Drawing.Point(193, 242);
            this.txtDhuhr.Name = "txtDhuhr";
            this.txtDhuhr.Size = new System.Drawing.Size(54, 16);
            this.txtDhuhr.TabIndex = 11;
            this.txtDhuhr.Text = "txtDhuhr";
            // 
            // txtAsr
            // 
            this.txtAsr.AutoSize = true;
            this.txtAsr.Location = new System.Drawing.Point(39, 305);
            this.txtAsr.Name = "txtAsr";
            this.txtAsr.Size = new System.Drawing.Size(39, 16);
            this.txtAsr.TabIndex = 12;
            this.txtAsr.Text = "txtAsr";
            // 
            // txtMaghrib
            // 
            this.txtMaghrib.AutoSize = true;
            this.txtMaghrib.Location = new System.Drawing.Point(42, 346);
            this.txtMaghrib.Name = "txtMaghrib";
            this.txtMaghrib.Size = new System.Drawing.Size(68, 16);
            this.txtMaghrib.TabIndex = 13;
            this.txtMaghrib.Text = "txtMaghrib";
            // 
            // txtIsha
            // 
            this.txtIsha.AutoSize = true;
            this.txtIsha.Location = new System.Drawing.Point(45, 390);
            this.txtIsha.Name = "txtIsha";
            this.txtIsha.Size = new System.Drawing.Size(44, 16);
            this.txtIsha.TabIndex = 14;
            this.txtIsha.Text = "txtIsha";
            // 
            // countryCombo
            // 
            this.countryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Location = new System.Drawing.Point(39, 77);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(121, 24);
            this.countryCombo.TabIndex = 15;
            // 
            // cityCombo
            // 
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(205, 77);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.Size = new System.Drawing.Size(121, 24);
            this.cityCombo.TabIndex = 16;
            // 
            // windowLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.countryCombo);
            this.Controls.Add(this.txtIsha);
            this.Controls.Add(this.txtMaghrib);
            this.Controls.Add(this.txtAsr);
            this.Controls.Add(this.txtDhuhr);
            this.Controls.Add(this.txtFajr);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.txtSunset);
            this.Controls.Add(this.txtSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "windowLabel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.windowLabel_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSunrise;
        private System.Windows.Forms.Label txtSunset;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label txtFajr;
        private System.Windows.Forms.Label txtDhuhr;
        private System.Windows.Forms.Label txtAsr;
        private System.Windows.Forms.Label txtMaghrib;
        private System.Windows.Forms.Label txtIsha;
        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.ComboBox cityCombo;
    }
}

