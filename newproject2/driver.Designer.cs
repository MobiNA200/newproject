namespace newproject2
{
    partial class driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(driver));
            this.button1 = new System.Windows.Forms.Button();
            this.lblCarPlate = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtcodemeli = new System.Windows.Forms.TextBox();
            this.txtcarmodel = new System.Windows.Forms.TextBox();
            this.txtpelak = new System.Windows.Forms.TextBox();
            this.txttravels = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(442, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "نمایش سفر های اخیر";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCarPlate
            // 
            this.lblCarPlate.AutoSize = true;
            this.lblCarPlate.Location = new System.Drawing.Point(221, 125);
            this.lblCarPlate.Name = "lblCarPlate";
            this.lblCarPlate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarPlate.Size = new System.Drawing.Size(31, 13);
            this.lblCarPlate.TabIndex = 8;
            this.lblCarPlate.Text = "پلاک :";
            this.lblCarPlate.Click += new System.EventHandler(this.lblCarPlate_Click);
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(221, 98);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarModel.Size = new System.Drawing.Size(62, 13);
            this.lblCarModel.TabIndex = 7;
            this.lblCarModel.Text = "مدل ماشین :";
            this.lblCarModel.Click += new System.EventHandler(this.lblCarModel_Click);
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(221, 66);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationalCode.Size = new System.Drawing.Size(46, 13);
            this.lblNationalCode.TabIndex = 6;
            this.lblNationalCode.Text = "کد ملی :";
            this.lblNationalCode.Click += new System.EventHandler(this.lblNationalCode_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(221, 35);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "نام :";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtcodemeli
            // 
            this.txtcodemeli.Location = new System.Drawing.Point(92, 63);
            this.txtcodemeli.Name = "txtcodemeli";
            this.txtcodemeli.Size = new System.Drawing.Size(113, 20);
            this.txtcodemeli.TabIndex = 10;
            // 
            // txtcarmodel
            // 
            this.txtcarmodel.Location = new System.Drawing.Point(92, 94);
            this.txtcarmodel.Name = "txtcarmodel";
            this.txtcarmodel.Size = new System.Drawing.Size(113, 20);
            this.txtcarmodel.TabIndex = 11;
            this.txtcarmodel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtpelak
            // 
            this.txtpelak.Location = new System.Drawing.Point(92, 122);
            this.txtpelak.Name = "txtpelak";
            this.txtpelak.Size = new System.Drawing.Size(113, 20);
            this.txtpelak.TabIndex = 12;
            this.txtpelak.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txttravels
            // 
            this.txttravels.Location = new System.Drawing.Point(353, 24);
            this.txttravels.Multiline = true;
            this.txttravels.Name = "txttravels";
            this.txttravels.Size = new System.Drawing.Size(295, 336);
            this.txttravels.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Location = new System.Drawing.Point(12, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "درامد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 153);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ایمیل:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(92, 150);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(113, 20);
            this.txtemail.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-41, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "اطلاعات شما";
            // 
            // driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txttravels);
            this.Controls.Add(this.txtpelak);
            this.Controls.Add(this.txtcarmodel);
            this.Controls.Add(this.txtcodemeli);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCarPlate);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "driver";
            this.Text = "driver";
            this.Load += new System.EventHandler(this.driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCarPlate;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtcodemeli;
        private System.Windows.Forms.TextBox txtcarmodel;
        private System.Windows.Forms.TextBox txtpelak;
        private System.Windows.Forms.TextBox txttravels;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}