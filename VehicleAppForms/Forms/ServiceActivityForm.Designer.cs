
namespace VehicleAppForms.Forms
{
    partial class ServiceActivityForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_registrationNumber = new System.Windows.Forms.Label();
            this.lbl_activityName = new System.Windows.Forms.Label();
            this.lbl_serviceDate = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_serviceCost = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_submitActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 27);
            this.textBox2.TabIndex = 1;
            // 
            // lbl_registrationNumber
            // 
            this.lbl_registrationNumber.AutoSize = true;
            this.lbl_registrationNumber.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.lbl_registrationNumber.Location = new System.Drawing.Point(19, 24);
            this.lbl_registrationNumber.Name = "lbl_registrationNumber";
            this.lbl_registrationNumber.Size = new System.Drawing.Size(169, 23);
            this.lbl_registrationNumber.TabIndex = 2;
            this.lbl_registrationNumber.Text = "Registration Number";
            // 
            // lbl_activityName
            // 
            this.lbl_activityName.AutoSize = true;
            this.lbl_activityName.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.lbl_activityName.Location = new System.Drawing.Point(61, 78);
            this.lbl_activityName.Name = "lbl_activityName";
            this.lbl_activityName.Size = new System.Drawing.Size(116, 23);
            this.lbl_activityName.TabIndex = 3;
            this.lbl_activityName.Text = "Activity Name";
            // 
            // lbl_serviceDate
            // 
            this.lbl_serviceDate.AutoSize = true;
            this.lbl_serviceDate.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.lbl_serviceDate.Location = new System.Drawing.Point(73, 128);
            this.lbl_serviceDate.Name = "lbl_serviceDate";
            this.lbl_serviceDate.Size = new System.Drawing.Size(104, 23);
            this.lbl_serviceDate.TabIndex = 4;
            this.lbl_serviceDate.Text = "Service Date";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.lbl_description.Location = new System.Drawing.Point(81, 178);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(96, 23);
            this.lbl_description.TabIndex = 5;
            this.lbl_description.Text = "Description";
            // 
            // lbl_serviceCost
            // 
            this.lbl_serviceCost.AutoSize = true;
            this.lbl_serviceCost.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.lbl_serviceCost.Location = new System.Drawing.Point(75, 228);
            this.lbl_serviceCost.Name = "lbl_serviceCost";
            this.lbl_serviceCost.Size = new System.Drawing.Size(102, 23);
            this.lbl_serviceCost.TabIndex = 6;
            this.lbl_serviceCost.Text = "Service Cost";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 27);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 27);
            this.textBox4.TabIndex = 9;
            // 
            // btn_submitActivity
            // 
            this.btn_submitActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submitActivity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_submitActivity.Location = new System.Drawing.Point(343, 275);
            this.btn_submitActivity.Name = "btn_submitActivity";
            this.btn_submitActivity.Size = new System.Drawing.Size(153, 48);
            this.btn_submitActivity.TabIndex = 10;
            this.btn_submitActivity.Text = "Submit Activity";
            this.btn_submitActivity.UseVisualStyleBackColor = false;
            // 
            // ServiceActivityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 338);
            this.Controls.Add(this.btn_submitActivity);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_serviceCost);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_serviceDate);
            this.Controls.Add(this.lbl_activityName);
            this.Controls.Add(this.lbl_registrationNumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ServiceActivityForm";
            this.Text = "New Service Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_registrationNumber;
        private System.Windows.Forms.Label lbl_activityName;
        private System.Windows.Forms.Label lbl_serviceDate;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_serviceCost;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_submitActivity;
    }
}