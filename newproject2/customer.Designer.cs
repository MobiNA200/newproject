namespace newproject2
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Chdis = new System.Windows.Forms.CheckBox();
            this.Chstop = new System.Windows.Forms.CheckBox();
            this.txtmaghsad2 = new System.Windows.Forms.TextBox();
            this.txttimestop = new System.Windows.Forms.TextBox();
            this.txtmabda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaghsad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "نمایش قیمت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 78);
            this.button1.TabIndex = 26;
            this.button1.Text = "درخواست سرویس";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtprice.Location = new System.Drawing.Point(391, 270);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(156, 41);
            this.txtprice.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-44, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.Chdis);
            this.groupBox1.Controls.Add(this.Chstop);
            this.groupBox1.Controls.Add(this.txtmaghsad2);
            this.groupBox1.Controls.Add(this.txttimestop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(385, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(287, 128);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزینه های سفر";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(151, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(98, 20);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "رفت و برگشت ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Chdis
            // 
            this.Chdis.AutoSize = true;
            this.Chdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chdis.Location = new System.Drawing.Point(151, 60);
            this.Chdis.Name = "Chdis";
            this.Chdis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Chdis.Size = new System.Drawing.Size(71, 20);
            this.Chdis.TabIndex = 29;
            this.Chdis.Text = "مقصد دوم";
            this.Chdis.UseVisualStyleBackColor = true;
            this.Chdis.CheckedChanged += new System.EventHandler(this.Chdis_CheckedChanged);
            // 
            // Chstop
            // 
            this.Chstop.AutoSize = true;
            this.Chstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chstop.Location = new System.Drawing.Point(151, 36);
            this.Chstop.Name = "Chstop";
            this.Chstop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Chstop.Size = new System.Drawing.Size(94, 20);
            this.Chstop.TabIndex = 28;
            this.Chstop.Text = "توقف در مسیر";
            this.Chstop.UseVisualStyleBackColor = true;
            this.Chstop.CheckedChanged += new System.EventHandler(this.Chstop_CheckedChanged);
            // 
            // txtmaghsad2
            // 
            this.txtmaghsad2.Location = new System.Drawing.Point(23, 64);
            this.txtmaghsad2.Multiline = true;
            this.txtmaghsad2.Name = "txtmaghsad2";
            this.txtmaghsad2.Size = new System.Drawing.Size(100, 16);
            this.txtmaghsad2.TabIndex = 27;
            this.txtmaghsad2.Visible = false;
            // 
            // txttimestop
            // 
            this.txttimestop.Location = new System.Drawing.Point(23, 40);
            this.txttimestop.Multiline = true;
            this.txttimestop.Name = "txttimestop";
            this.txttimestop.Size = new System.Drawing.Size(100, 16);
            this.txttimestop.TabIndex = 26;
            this.txttimestop.Visible = false;
            // 
            // txtmabda
            // 
            this.txtmabda.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmabda.Location = new System.Drawing.Point(385, 30);
            this.txtmabda.Name = "txtmabda";
            this.txtmabda.Size = new System.Drawing.Size(127, 20);
            this.txtmabda.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 26);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "مقصد خود را وارد کنید :";
            // 
            // txtmaghsad
            // 
            this.txtmaghsad.Location = new System.Drawing.Point(24, 27);
            this.txtmaghsad.Name = "txtmaghsad";
            this.txtmaghsad.Size = new System.Drawing.Size(135, 20);
            this.txtmaghsad.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(527, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "مبدا خود را وارد کنید :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(17, 410);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(416, 37);
            this.label3.TabIndex = 36;
            this.label3.Text = " امیدواریم سفر خوبی را تجربه کنید :)";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(688, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmabda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaghsad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox Chdis;
        private System.Windows.Forms.CheckBox Chstop;
        private System.Windows.Forms.TextBox txtmaghsad2;
        private System.Windows.Forms.TextBox txttimestop;
        private System.Windows.Forms.TextBox txtmabda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaghsad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}