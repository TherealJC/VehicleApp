
namespace VehicleAppForms
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
            this.txt_activityID = new System.Windows.Forms.TextBox();
            this.txt_activityName = new System.Windows.Forms.TextBox();
            this.lbl_activityID = new System.Windows.Forms.Label();
            this.lbl_activityName = new System.Windows.Forms.Label();
            this.lbl_serviceDate = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_serviceCost = new System.Windows.Forms.Label();
            this.dtp_serviceDate = new System.Windows.Forms.DateTimePicker();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_serviceCost = new System.Windows.Forms.TextBox();
            this.btn_submitActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_activityID
            // 
            this.txt_activityID.Location = new System.Drawing.Point(194, 24);
            this.txt_activityID.Name = "txt_activityID";
            this.txt_activityID.ReadOnly = true;
            this.txt_activityID.Size = new System.Drawing.Size(157, 27);
            this.txt_activityID.TabIndex = 0;
            // 
            // txt_activityName
            // 
            this.txt_activityName.Location = new System.Drawing.Point(194, 74);
            this.txt_activityName.Name = "txt_activityName";
            this.txt_activityName.Size = new System.Drawing.Size(157, 27);
            this.txt_activityName.TabIndex = 1;
            // 
            // lbl_activityID
            // 
            this.lbl_activityID.AutoSize = true;
            this.lbl_activityID.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.lbl_activityID.Location = new System.Drawing.Point(90, 26);
            this.lbl_activityID.Name = "lbl_activityID";
            this.lbl_activityID.Size = new System.Drawing.Size(87, 23);
            this.lbl_activityID.TabIndex = 2;
            this.lbl_activityID.Text = "Activity ID";
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
            // dtp_serviceDate
            // 
            this.dtp_serviceDate.Location = new System.Drawing.Point(194, 124);
            this.dtp_serviceDate.Name = "dtp_serviceDate";
            this.dtp_serviceDate.Size = new System.Drawing.Size(257, 27);
            this.dtp_serviceDate.TabIndex = 7;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(194, 174);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(157, 27);
            this.txt_description.TabIndex = 8;
            // 
            // txt_serviceCost
            // 
            this.txt_serviceCost.Location = new System.Drawing.Point(194, 224);
            this.txt_serviceCost.Name = "txt_serviceCost";
            this.txt_serviceCost.Size = new System.Drawing.Size(157, 27);
            this.txt_serviceCost.TabIndex = 9;
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
            this.Controls.Add(this.txt_serviceCost);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.dtp_serviceDate);
            this.Controls.Add(this.lbl_serviceCost);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_serviceDate);
            this.Controls.Add(this.lbl_activityName);
            this.Controls.Add(this.lbl_activityID);
            this.Controls.Add(this.txt_activityName);
            this.Controls.Add(this.txt_activityID);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ServiceActivityForm";
            this.Text = "New Service Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_activityID;
        private System.Windows.Forms.TextBox txt_activityName;
        private System.Windows.Forms.Label lbl_activityID;
        private System.Windows.Forms.Label lbl_activityName;
        private System.Windows.Forms.Label lbl_serviceDate;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_serviceCost;
        private System.Windows.Forms.DateTimePicker dtp_serviceDate;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_serviceCost;
        private System.Windows.Forms.Button btn_submitActivity;
    }
}