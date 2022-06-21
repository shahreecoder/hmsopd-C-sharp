namespace HMS_OPD
{
    partial class Add_Delete_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Delete_Appointment));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdocid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdocspeci = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpgender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpdob = new System.Windows.Forms.TextBox();
            this.listView8 = new System.Windows.Forms.ListView();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.panel2.Location = new System.Drawing.Point(210, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 5);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.panel1.Location = new System.Drawing.Point(210, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 5);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(168, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "    Appointment Add or Delete    ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtdocid
            // 
            this.txtdocid.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtdocid.Location = new System.Drawing.Point(242, 80);
            this.txtdocid.Name = "txtdocid";
            this.txtdocid.Size = new System.Drawing.Size(202, 28);
            this.txtdocid.TabIndex = 73;
            this.txtdocid.Visible = false;
            this.txtdocid.Enter += new System.EventHandler(this.txtdocid_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label3.Location = new System.Drawing.Point(84, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "Doctor Name:-";
            // 
            // txtdocspeci
            // 
            this.txtdocspeci.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtdocspeci.Location = new System.Drawing.Point(242, 170);
            this.txtdocspeci.Name = "txtdocspeci";
            this.txtdocspeci.ReadOnly = true;
            this.txtdocspeci.Size = new System.Drawing.Size(202, 28);
            this.txtdocspeci.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label7.Location = new System.Drawing.Point(84, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 23);
            this.label7.TabIndex = 76;
            this.label7.Text = "Specialization:-";
            // 
            // txtfees
            // 
            this.txtfees.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtfees.Location = new System.Drawing.Point(242, 219);
            this.txtfees.Name = "txtfees";
            this.txtfees.ReadOnly = true;
            this.txtfees.Size = new System.Drawing.Size(202, 28);
            this.txtfees.TabIndex = 0;
            this.txtfees.TextChanged += new System.EventHandler(this.txtfees_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label8.Location = new System.Drawing.Point(84, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 78;
            this.label8.Text = "Fees:-";
            // 
            // txtpid
            // 
            this.txtpid.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtpid.Location = new System.Drawing.Point(617, 80);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(205, 28);
            this.txtpid.TabIndex = 81;
            this.txtpid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label5.Location = new System.Drawing.Point(464, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 82;
            this.label5.Text = "Patient Name:-";
            // 
            // txtpgender
            // 
            this.txtpgender.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtpgender.Location = new System.Drawing.Point(619, 175);
            this.txtpgender.Name = "txtpgender";
            this.txtpgender.ReadOnly = true;
            this.txtpgender.Size = new System.Drawing.Size(205, 28);
            this.txtpgender.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label9.Location = new System.Drawing.Point(464, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 84;
            this.label9.Text = "Gender:-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label6.Location = new System.Drawing.Point(464, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 86;
            this.label6.Text = "DOB:-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AdatePicker
            // 
            this.AdatePicker.CustomFormat = "dd-MM-yyyy";
            this.AdatePicker.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.AdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AdatePicker.Location = new System.Drawing.Point(371, 307);
            this.AdatePicker.Name = "AdatePicker";
            this.AdatePicker.Size = new System.Drawing.Size(196, 28);
            this.AdatePicker.TabIndex = 3;
            this.AdatePicker.Value = new System.DateTime(2020, 1, 30, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.label10.Location = new System.Drawing.Point(367, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 23);
            this.label10.TabIndex = 88;
            this.label10.Text = "Appointment Date:-";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(471, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Add  ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(345, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 90;
            this.button1.Text = "&Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpdob
            // 
            this.txtpdob.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtpdob.Location = new System.Drawing.Point(619, 223);
            this.txtpdob.Name = "txtpdob";
            this.txtpdob.ReadOnly = true;
            this.txtpdob.Size = new System.Drawing.Size(205, 28);
            this.txtpdob.TabIndex = 0;
            // 
            // listView8
            // 
            this.listView8.BackColor = System.Drawing.Color.White;
            this.listView8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.listView8.GridLines = true;
            this.listView8.Location = new System.Drawing.Point(88, 430);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(822, 155);
            this.listView8.TabIndex = 0;
            this.listView8.UseCompatibleStateImageBehavior = false;
            this.listView8.View = System.Windows.Forms.View.Details;
            this.listView8.SelectedIndexChanged += new System.EventHandler(this.listView8_SelectedIndexChanged);
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdoctor.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(242, 114);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(202, 27);
            this.cmbdoctor.TabIndex = 1;
            this.cmbdoctor.SelectedIndexChanged += new System.EventHandler(this.cmbdoctor_SelectedIndexChanged);
            this.cmbdoctor.DropDownClosed += new System.EventHandler(this.cmbdoctor_DropDownClosed_1);
            this.cmbdoctor.Leave += new System.EventHandler(this.cmbdoctor_Leave);
            // 
            // cmbpatient
            // 
            this.cmbpatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpatient.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(619, 114);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(205, 27);
            this.cmbpatient.TabIndex = 2;
            this.cmbpatient.SelectedIndexChanged += new System.EventHandler(this.cmbpatient_SelectedIndexChanged);
            this.cmbpatient.DropDownClosed += new System.EventHandler(this.cmbpatient_DropDownClosed);
            this.cmbpatient.Leave += new System.EventHandler(this.cmbpatient_Leave);
            // 
            // Add_Delete_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 597);
            this.Controls.Add(this.cmbpatient);
            this.Controls.Add(this.cmbdoctor);
            this.Controls.Add(this.listView8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdatePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpdob);
            this.Controls.Add(this.txtpgender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.txtfees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdocspeci);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdocid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(253)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(280, 85);
            this.Name = "Add_Delete_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add_Delete_Appointment";
            this.Load += new System.EventHandler(this.Add_Delete_Appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdocid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdocspeci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpgender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker AdatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpdob;
        private System.Windows.Forms.ListView listView8;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.ComboBox cmbpatient;
    }
}