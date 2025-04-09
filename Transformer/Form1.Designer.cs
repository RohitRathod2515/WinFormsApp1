namespace Transformer
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.btSAVE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNAME = new System.Windows.Forms.TextBox();
            this.tbTYPE = new System.Windows.Forms.TextBox();
            this.tbCAPACITY = new System.Windows.Forms.TextBox();
            this.tbAREA = new System.Windows.Forms.TextBox();
            this.tbIMAGE_PATH = new System.Windows.Forms.TextBox();
            this.tbLATITUDE = new System.Windows.Forms.TextBox();
            this.tbLONGITUDE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.Window;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(305, 96);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(189, 24);
            this.tbID.TabIndex = 1;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // btSAVE
            // 
            this.btSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSAVE.Location = new System.Drawing.Point(396, 400);
            this.btSAVE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSAVE.Name = "btSAVE";
            this.btSAVE.Size = new System.Drawing.Size(144, 62);
            this.btSAVE.TabIndex = 2;
            this.btSAVE.Text = "SAVE";
            this.btSAVE.UseVisualStyleBackColor = true;
            this.btSAVE.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSFORMER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "TYPE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "CAPACITY";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "AREA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "IMAGE_PATH";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "LATITUDE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "LONGITUDE";
            // 
            // tbNAME
            // 
            this.tbNAME.BackColor = System.Drawing.SystemColors.Window;
            this.tbNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNAME.Location = new System.Drawing.Point(305, 129);
            this.tbNAME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNAME.Name = "tbNAME";
            this.tbNAME.Size = new System.Drawing.Size(189, 24);
            this.tbNAME.TabIndex = 11;
            this.tbNAME.TextChanged += new System.EventHandler(this.tbNAME_TextChanged);
            // 
            // tbTYPE
            // 
            this.tbTYPE.BackColor = System.Drawing.SystemColors.Window;
            this.tbTYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTYPE.Location = new System.Drawing.Point(305, 161);
            this.tbTYPE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTYPE.Name = "tbTYPE";
            this.tbTYPE.Size = new System.Drawing.Size(189, 24);
            this.tbTYPE.TabIndex = 12;
            this.tbTYPE.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbCAPACITY
            // 
            this.tbCAPACITY.BackColor = System.Drawing.SystemColors.Window;
            this.tbCAPACITY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCAPACITY.Location = new System.Drawing.Point(305, 191);
            this.tbCAPACITY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCAPACITY.Name = "tbCAPACITY";
            this.tbCAPACITY.Size = new System.Drawing.Size(189, 24);
            this.tbCAPACITY.TabIndex = 13;
            this.tbCAPACITY.TextChanged += new System.EventHandler(this.tbCAPACITY_TextChanged);
            // 
            // tbAREA
            // 
            this.tbAREA.BackColor = System.Drawing.SystemColors.Window;
            this.tbAREA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAREA.Location = new System.Drawing.Point(305, 224);
            this.tbAREA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAREA.Name = "tbAREA";
            this.tbAREA.Size = new System.Drawing.Size(189, 24);
            this.tbAREA.TabIndex = 14;
            this.tbAREA.TextChanged += new System.EventHandler(this.tbAREA_TextChanged);
            // 
            // tbIMAGE_PATH
            // 
            this.tbIMAGE_PATH.BackColor = System.Drawing.SystemColors.Window;
            this.tbIMAGE_PATH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIMAGE_PATH.Location = new System.Drawing.Point(305, 256);
            this.tbIMAGE_PATH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbIMAGE_PATH.Name = "tbIMAGE_PATH";
            this.tbIMAGE_PATH.Size = new System.Drawing.Size(189, 24);
            this.tbIMAGE_PATH.TabIndex = 15;
            this.tbIMAGE_PATH.TextChanged += new System.EventHandler(this.tbIMAGE_PATH_TextChanged);
            // 
            // tbLATITUDE
            // 
            this.tbLATITUDE.BackColor = System.Drawing.SystemColors.Window;
            this.tbLATITUDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLATITUDE.Location = new System.Drawing.Point(305, 295);
            this.tbLATITUDE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLATITUDE.Name = "tbLATITUDE";
            this.tbLATITUDE.Size = new System.Drawing.Size(189, 24);
            this.tbLATITUDE.TabIndex = 16;
            this.tbLATITUDE.TextChanged += new System.EventHandler(this.tbLATITUDE_TextChanged);
            // 
            // tbLONGITUDE
            // 
            this.tbLONGITUDE.BackColor = System.Drawing.SystemColors.Window;
            this.tbLONGITUDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLONGITUDE.Location = new System.Drawing.Point(305, 334);
            this.tbLONGITUDE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLONGITUDE.Name = "tbLONGITUDE";
            this.tbLONGITUDE.Size = new System.Drawing.Size(189, 24);
            this.tbLONGITUDE.TabIndex = 17;
            this.tbLONGITUDE.TextChanged += new System.EventHandler(this.tbLONGITUDE_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.tbLONGITUDE);
            this.Controls.Add(this.tbLATITUDE);
            this.Controls.Add(this.tbIMAGE_PATH);
            this.Controls.Add(this.tbAREA);
            this.Controls.Add(this.tbCAPACITY);
            this.Controls.Add(this.tbTYPE);
            this.Controls.Add(this.tbNAME);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSAVE);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "TRANSFORMER UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btSAVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNAME;
        private System.Windows.Forms.TextBox tbTYPE;
        private System.Windows.Forms.TextBox tbCAPACITY;
        private System.Windows.Forms.TextBox tbAREA;
        private System.Windows.Forms.TextBox tbIMAGE_PATH;
        private System.Windows.Forms.TextBox tbLATITUDE;
        private System.Windows.Forms.TextBox tbLONGITUDE;
    }
}

