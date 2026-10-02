namespace HospitalManagementSystem
{
    partial class frmSearchPatient
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.lblPatientContactNumber = new System.Windows.Forms.Label();
            this.lblPatientGender = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(28, 32);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(78, 16);
            this.lblPatientID.TabIndex = 1;
            this.lblPatientID.Text = "Patient ID:";
            this.lblPatientID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(28, 146);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(104, 16);
            this.lblPatientName.TabIndex = 3;
            this.lblPatientName.Text = "Patient Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(84, 192);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(64, 240);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 16);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(13, 283);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(121, 16);
            this.lblContactNumber.TabIndex = 6;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(124, 30);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(154, 22);
            this.txtPatientID.TabIndex = 7;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(154, 146);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(0, 16);
            this.lblPatient.TabIndex = 8;
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.Location = new System.Drawing.Point(154, 192);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(0, 16);
            this.lblPatientAge.TabIndex = 9;
            // 
            // lblPatientContactNumber
            // 
            this.lblPatientContactNumber.AutoSize = true;
            this.lblPatientContactNumber.Location = new System.Drawing.Point(154, 283);
            this.lblPatientContactNumber.Name = "lblPatientContactNumber";
            this.lblPatientContactNumber.Size = new System.Drawing.Size(0, 16);
            this.lblPatientContactNumber.TabIndex = 10;
            // 
            // lblPatientGender
            // 
            this.lblPatientGender.AutoSize = true;
            this.lblPatientGender.Location = new System.Drawing.Point(154, 240);
            this.lblPatientGender.Name = "lblPatientGender";
            this.lblPatientGender.Size = new System.Drawing.Size(0, 16);
            this.lblPatientGender.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(301, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "RESULT                                                                      ";
            // 
            // frmSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPatientGender);
            this.Controls.Add(this.lblPatientContactNumber);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblPatientID);
            this.Name = "frmSearchPatient";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSearchPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblPatientContactNumber;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}