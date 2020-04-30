namespace projectnew2
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.onmath = new System.Windows.Forms.TextBox();
            this.onsci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oneng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.onthai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.onsoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.onsoc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.onthai);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.oneng);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.onsci);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.onmath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 360);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onet Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "คณิตศาสตร์";
            // 
            // onmath
            // 
            this.onmath.Location = new System.Drawing.Point(24, 101);
            this.onmath.Name = "onmath";
            this.onmath.Size = new System.Drawing.Size(211, 22);
            this.onmath.TabIndex = 2;
            // 
            // onsci
            // 
            this.onsci.Location = new System.Drawing.Point(24, 183);
            this.onsci.Name = "onsci";
            this.onsci.Size = new System.Drawing.Size(211, 22);
            this.onsci.TabIndex = 4;
            this.onsci.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "วิทยาศาสตร์";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // oneng
            // 
            this.oneng.Location = new System.Drawing.Point(24, 273);
            this.oneng.Name = "oneng";
            this.oneng.Size = new System.Drawing.Size(211, 22);
            this.oneng.TabIndex = 6;
            this.oneng.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(19, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "ภาษาอังกฤษ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // onthai
            // 
            this.onthai.Location = new System.Drawing.Point(362, 101);
            this.onthai.Name = "onthai";
            this.onthai.Size = new System.Drawing.Size(211, 22);
            this.onthai.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(357, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "ภาษาไทย";
            // 
            // onsoc
            // 
            this.onsoc.Location = new System.Drawing.Point(361, 183);
            this.onsoc.Name = "onsoc";
            this.onsoc.Size = new System.Drawing.Size(211, 22);
            this.onsoc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(356, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "สังคมศึกษา ศาสนาและวัฒนธรรม";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(698, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(3, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oneng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox onsci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox onmath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox onsoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox onthai;
        private System.Windows.Forms.Label label5;
    }
}