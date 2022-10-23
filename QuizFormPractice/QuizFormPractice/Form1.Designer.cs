
namespace QuizFormPractice
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
            this.bkg1 = new System.Windows.Forms.RadioButton();
            this.bkg2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tc2 = new System.Windows.Forms.RadioButton();
            this.tc1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bkg2);
            this.groupBox1.Controls.Add(this.bkg1);
            this.groupBox1.Location = new System.Drawing.Point(205, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bkg1
            // 
            this.bkg1.AutoSize = true;
            this.bkg1.Location = new System.Drawing.Point(6, 19);
            this.bkg1.Name = "bkg1";
            this.bkg1.Size = new System.Drawing.Size(83, 17);
            this.bkg1.TabIndex = 0;
            this.bkg1.TabStop = true;
            this.bkg1.Text = "Background";
            this.bkg1.UseVisualStyleBackColor = true;
            this.bkg1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // bkg2
            // 
            this.bkg2.AutoSize = true;
            this.bkg2.Location = new System.Drawing.Point(6, 42);
            this.bkg2.Name = "bkg2";
            this.bkg2.Size = new System.Drawing.Size(83, 17);
            this.bkg2.TabIndex = 1;
            this.bkg2.TabStop = true;
            this.bkg2.Text = "Background";
            this.bkg2.UseVisualStyleBackColor = true;
            this.bkg2.CheckedChanged += new System.EventHandler(this.bkg2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tc2);
            this.groupBox2.Controls.Add(this.tc1);
            this.groupBox2.Location = new System.Drawing.Point(406, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tc2
            // 
            this.tc2.AutoSize = true;
            this.tc2.Location = new System.Drawing.Point(6, 42);
            this.tc2.Name = "tc2";
            this.tc2.Size = new System.Drawing.Size(70, 17);
            this.tc2.TabIndex = 1;
            this.tc2.TabStop = true;
            this.tc2.Text = "TextColor";
            this.tc2.UseVisualStyleBackColor = true;
            this.tc2.CheckedChanged += new System.EventHandler(this.tc2_CheckedChanged);
            // 
            // tc1
            // 
            this.tc1.AutoSize = true;
            this.tc1.Location = new System.Drawing.Point(6, 19);
            this.tc1.Name = "tc1";
            this.tc1.Size = new System.Drawing.Size(70, 17);
            this.tc1.TabIndex = 0;
            this.tc1.TabStop = true;
            this.tc1.Text = "TextColor";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tc2;
        private System.Windows.Forms.RadioButton tc1;
        private System.Windows.Forms.RadioButton bkg2;
        private System.Windows.Forms.RadioButton bkg1;
    }
}

