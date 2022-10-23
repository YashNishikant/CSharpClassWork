
namespace secondFormPrac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bg1 = new System.Windows.Forms.RadioButton();
            this.bg2 = new System.Windows.Forms.RadioButton();
            this.tc2 = new System.Windows.Forms.RadioButton();
            this.tc3 = new System.Windows.Forms.RadioButton();
            this.bg3 = new System.Windows.Forms.RadioButton();
            this.tc1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bg3);
            this.groupBox1.Controls.Add(this.bg2);
            this.groupBox1.Controls.Add(this.bg1);
            this.groupBox1.Location = new System.Drawing.Point(119, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tc1);
            this.groupBox2.Controls.Add(this.tc3);
            this.groupBox2.Controls.Add(this.tc2);
            this.groupBox2.Location = new System.Drawing.Point(458, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // bg1
            // 
            this.bg1.AutoSize = true;
            this.bg1.Location = new System.Drawing.Point(43, 20);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(85, 17);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = true;
            this.bg1.Text = "radioButton1";
            this.bg1.UseVisualStyleBackColor = true;
            this.bg1.CheckedChanged += new System.EventHandler(this.bg1_CheckedChanged);
            // 
            // bg2
            // 
            this.bg2.AutoSize = true;
            this.bg2.Location = new System.Drawing.Point(43, 42);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(85, 17);
            this.bg2.TabIndex = 1;
            this.bg2.TabStop = true;
            this.bg2.Text = "radioButton2";
            this.bg2.UseVisualStyleBackColor = true;
            this.bg2.CheckedChanged += new System.EventHandler(this.bg2_CheckedChanged);
            // 
            // tc2
            // 
            this.tc2.AutoSize = true;
            this.tc2.Location = new System.Drawing.Point(35, 43);
            this.tc2.Name = "tc2";
            this.tc2.Size = new System.Drawing.Size(85, 17);
            this.tc2.TabIndex = 4;
            this.tc2.TabStop = true;
            this.tc2.Text = "radioButton5";
            this.tc2.UseVisualStyleBackColor = true;
            this.tc2.CheckedChanged += new System.EventHandler(this.tc2_CheckedChanged);
            // 
            // tc3
            // 
            this.tc3.AutoSize = true;
            this.tc3.Location = new System.Drawing.Point(35, 65);
            this.tc3.Name = "tc3";
            this.tc3.Size = new System.Drawing.Size(85, 17);
            this.tc3.TabIndex = 3;
            this.tc3.TabStop = true;
            this.tc3.Text = "radioButton6";
            this.tc3.UseVisualStyleBackColor = true;
            this.tc3.CheckedChanged += new System.EventHandler(this.tc3_CheckedChanged);
            // 
            // bg3
            // 
            this.bg3.AutoSize = true;
            this.bg3.Location = new System.Drawing.Point(43, 65);
            this.bg3.Name = "bg3";
            this.bg3.Size = new System.Drawing.Size(85, 17);
            this.bg3.TabIndex = 2;
            this.bg3.TabStop = true;
            this.bg3.Text = "radioButton3";
            this.bg3.UseVisualStyleBackColor = true;
            this.bg3.CheckedChanged += new System.EventHandler(this.bg3_CheckedChanged);
            // 
            // tc1
            // 
            this.tc1.AutoSize = true;
            this.tc1.Location = new System.Drawing.Point(35, 20);
            this.tc1.Name = "tc1";
            this.tc1.Size = new System.Drawing.Size(85, 17);
            this.tc1.TabIndex = 5;
            this.tc1.TabStop = true;
            this.tc1.Text = "radioButton4";
            this.tc1.UseVisualStyleBackColor = true;
            this.tc1.CheckedChanged += new System.EventHandler(this.tc1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bg3;
        private System.Windows.Forms.RadioButton bg2;
        private System.Windows.Forms.RadioButton bg1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tc1;
        private System.Windows.Forms.RadioButton tc3;
        private System.Windows.Forms.RadioButton tc2;
    }
}

