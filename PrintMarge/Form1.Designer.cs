namespace PrintMarge
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
            this.button1 = new System.Windows.Forms.Button();
            this.filenameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nznamenaka = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nznamenaka)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filenameText
            // 
            this.filenameText.Location = new System.Drawing.Point(66, 12);
            this.filenameText.Name = "filenameText";
            this.filenameText.Size = new System.Drawing.Size(151, 20);
            this.filenameText.TabIndex = 0;
            this.filenameText.DoubleClick += new System.EventHandler(this.filenameText_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poèetni broj kartice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kolièina kartica:";
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(119, 38);
            this.numeric1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(161, 20);
            this.numeric1.TabIndex = 1;
            this.numeric1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric1.ValueChanged += new System.EventHandler(this.numeric1_ValueChanged);
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(119, 64);
            this.numeric2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(161, 20);
            this.numeric2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Broj znamenaka";
            // 
            // nznamenaka
            // 
            this.nznamenaka.Location = new System.Drawing.Point(119, 90);
            this.nznamenaka.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nznamenaka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nznamenaka.Name = "nznamenaka";
            this.nznamenaka.Size = new System.Drawing.Size(161, 20);
            this.nznamenaka.TabIndex = 3;
            this.nznamenaka.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Create for MT85";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 189);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nznamenaka);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filenameText);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 227);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(308, 227);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nznamenaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filenameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.NumericUpDown numeric2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nznamenaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}

