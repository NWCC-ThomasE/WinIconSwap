using System;
using System.Collections.Generic;
using System.Linq;

namespace WinIconSwap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CDPanel = new System.Windows.Forms.Panel();
            this.CDDriveSelect = new System.Windows.Forms.ListBox();
            this.CDDriveLabel = new System.Windows.Forms.Label();
            this.QAPanel = new System.Windows.Forms.Panel();
            this.qaDisabled = new System.Windows.Forms.RadioButton();
            this.qaEnabled = new System.Windows.Forms.RadioButton();
            this.QALabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ISLabel = new System.Windows.Forms.Label();
            this.ISPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.CDPanel.SuspendLayout();
            this.QAPanel.SuspendLayout();
            this.ISPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CDPanel
            // 
            this.CDPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CDPanel.Controls.Add(this.CDDriveSelect);
            this.CDPanel.Controls.Add(this.CDDriveLabel);
            this.CDPanel.Location = new System.Drawing.Point(8, 8);
            this.CDPanel.Name = "CDPanel";
            this.CDPanel.Size = new System.Drawing.Size(144, 288);
            this.CDPanel.TabIndex = 4;
            // 
            // CDDriveSelect
            // 
            this.CDDriveSelect.FormattingEnabled = true;
            this.CDDriveSelect.IntegralHeight = false;
            this.CDDriveSelect.ItemHeight = 15;
            this.CDDriveSelect.Location = new System.Drawing.Point(8, 32);
            this.CDDriveSelect.Name = "CDDriveSelect";
            this.CDDriveSelect.Size = new System.Drawing.Size(128, 248);
            this.CDDriveSelect.TabIndex = 2;
            this.CDDriveSelect.SelectedIndexChanged += new System.EventHandler(this.CDLetter_Selected);
            // 
            // CDDriveLabel
            // 
            this.CDDriveLabel.AutoSize = true;
            this.CDDriveLabel.Location = new System.Drawing.Point(16, 8);
            this.CDDriveLabel.Name = "CDDriveLabel";
            this.CDDriveLabel.Size = new System.Drawing.Size(114, 15);
            this.CDDriveLabel.TabIndex = 1;
            this.CDDriveLabel.Text = "Select your CD Drive";
            // 
            // QAPanel
            // 
            this.QAPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QAPanel.Controls.Add(this.qaDisabled);
            this.QAPanel.Controls.Add(this.qaEnabled);
            this.QAPanel.Controls.Add(this.QALabel);
            this.QAPanel.Location = new System.Drawing.Point(160, 8);
            this.QAPanel.Name = "QAPanel";
            this.QAPanel.Size = new System.Drawing.Size(192, 120);
            this.QAPanel.TabIndex = 5;
            // 
            // qaDisabled
            // 
            this.qaDisabled.AutoSize = true;
            this.qaDisabled.Location = new System.Drawing.Point(104, 56);
            this.qaDisabled.Name = "qaDisabled";
            this.qaDisabled.Size = new System.Drawing.Size(70, 19);
            this.qaDisabled.TabIndex = 2;
            this.qaDisabled.TabStop = true;
            this.qaDisabled.Text = "Disabled";
            this.qaDisabled.UseVisualStyleBackColor = true;
            this.qaDisabled.CheckedChanged += new System.EventHandler(this.qaDisabled_Checked);
            // 
            // qaEnabled
            // 
            this.qaEnabled.AutoSize = true;
            this.qaEnabled.Location = new System.Drawing.Point(16, 56);
            this.qaEnabled.Name = "qaEnabled";
            this.qaEnabled.Size = new System.Drawing.Size(67, 19);
            this.qaEnabled.TabIndex = 1;
            this.qaEnabled.TabStop = true;
            this.qaEnabled.Text = "Enabled";
            this.qaEnabled.UseVisualStyleBackColor = true;
            this.qaEnabled.CheckedChanged += new System.EventHandler(this.qaEnabled_Checked);
            // 
            // QALabel
            // 
            this.QALabel.AutoSize = true;
            this.QALabel.Location = new System.Drawing.Point(56, 8);
            this.QALabel.Name = "QALabel";
            this.QALabel.Size = new System.Drawing.Size(77, 15);
            this.QALabel.TabIndex = 0;
            this.QALabel.Text = "Quick Access";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Papirus";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ISPapirus);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Windows";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ISWindows);
            // 
            // ISLabel
            // 
            this.ISLabel.AutoSize = true;
            this.ISLabel.Location = new System.Drawing.Point(72, 8);
            this.ISLabel.Name = "ISLabel";
            this.ISLabel.Size = new System.Drawing.Size(49, 15);
            this.ISLabel.TabIndex = 0;
            this.ISLabel.Text = "Icon Set";
            // 
            // ISPanel
            // 
            this.ISPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ISPanel.Controls.Add(this.radioButton1);
            this.ISPanel.Controls.Add(this.radioButton2);
            this.ISPanel.Controls.Add(this.ISLabel);
            this.ISPanel.Location = new System.Drawing.Point(160, 136);
            this.ISPanel.Name = "ISPanel";
            this.ISPanel.Size = new System.Drawing.Size(192, 96);
            this.ISPanel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IconSwitcheroo);
            // 
            // About
            // 
            this.About.Enabled = false;
            this.About.Location = new System.Drawing.Point(8, 304);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(344, 24);
            this.About.TabIndex = 7;
            this.About.Text = "Credit to Papirus Development Team for their icons!";
            this.About.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 337);
            this.Controls.Add(this.About);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ISPanel);
            this.Controls.Add(this.QAPanel);
            this.Controls.Add(this.CDPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.CDPanel.ResumeLayout(false);
            this.CDPanel.PerformLayout();
            this.QAPanel.ResumeLayout(false);
            this.QAPanel.PerformLayout();
            this.ISPanel.ResumeLayout(false);
            this.ISPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CDPanel;
        private System.Windows.Forms.ListBox CDDriveSelect;
        private System.Windows.Forms.Label CDDriveLabel;
        private System.Windows.Forms.Panel QAPanel;
        private System.Windows.Forms.Label QALabel;
        private System.Windows.Forms.RadioButton qaDisabled;
        private System.Windows.Forms.RadioButton qaEnabled;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label ISLabel;
        private System.Windows.Forms.Panel ISPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button About;
    }
}

