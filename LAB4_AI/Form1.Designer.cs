namespace LAB4_AI
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
            this.I = new System.Windows.Forms.CheckBox();
            this.G = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.K = new System.Windows.Forms.CheckBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.A = new System.Windows.Forms.CheckBox();
            this.E = new System.Windows.Forms.CheckBox();
            this.N = new System.Windows.Forms.CheckBox();
            this.M = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.P = new System.Windows.Forms.CheckBox();
            this.D = new System.Windows.Forms.CheckBox();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.I);
            this.groupBox1.Controls.Add(this.G);
            this.groupBox1.Location = new System.Drawing.Point(217, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anotimpul";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Location = new System.Drawing.Point(6, 42);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(50, 17);
            this.I.TabIndex = 1;
            this.I.Text = "Iarna";
            this.I.UseVisualStyleBackColor = true;
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(6, 19);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(48, 17);
            this.G.TabIndex = 0;
            this.G.Text = "Vara";
            this.G.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASPERSOR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.K);
            this.groupBox2.Controls.Add(this.C);
            this.groupBox2.Location = new System.Drawing.Point(316, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cerul";
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Location = new System.Drawing.Point(6, 42);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(45, 17);
            this.K.TabIndex = 1;
            this.K.Text = "Nori";
            this.K.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(6, 19);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(53, 17);
            this.C.TabIndex = 0;
            this.C.Text = "Senin";
            this.C.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.A);
            this.groupBox3.Controls.Add(this.E);
            this.groupBox3.Controls.Add(this.N);
            this.groupBox3.Controls.Add(this.M);
            this.groupBox3.Location = new System.Drawing.Point(12, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temperatura";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(6, 88);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(64, 17);
            this.A.TabIndex = 5;
            this.A.Text = "t > 40*C";
            this.A.UseVisualStyleBackColor = true;
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(6, 65);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(64, 17);
            this.E.TabIndex = 4;
            this.E.Text = "t > 25*C";
            this.E.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(6, 42);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(64, 17);
            this.N.TabIndex = 2;
            this.N.Text = "t > 15*C";
            this.N.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(6, 19);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(64, 17);
            this.M.TabIndex = 1;
            this.M.Text = "t < 25*C";
            this.M.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.P);
            this.groupBox4.Controls.Add(this.D);
            this.groupBox4.Location = new System.Drawing.Point(120, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(80, 65);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Umiditatea";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(6, 42);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(58, 17);
            this.P.TabIndex = 1;
            this.P.Text = "U > 50";
            this.P.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(6, 19);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(58, 17);
            this.D.TabIndex = 0;
            this.D.Text = "U < 50";
            this.D.UseVisualStyleBackColor = true;
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRezultat.Location = new System.Drawing.Point(123, 132);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(52, 13);
            this.lblRezultat.TabIndex = 5;
            this.lblRezultat.Text = "Rezultat: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculeaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox I;
        private System.Windows.Forms.CheckBox G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox K;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox A;
        private System.Windows.Forms.CheckBox E;
        private System.Windows.Forms.CheckBox N;
        private System.Windows.Forms.CheckBox M;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox D;
        private System.Windows.Forms.CheckBox P;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Button button1;
    }
}

