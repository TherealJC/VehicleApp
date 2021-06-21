
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
            this.Txt_ActivityID = new System.Windows.Forms.TextBox();
            this.Txt_ActivityName = new System.Windows.Forms.TextBox();
            this.Lbl_ActivityID = new System.Windows.Forms.Label();
            this.Lbl_ActivityName = new System.Windows.Forms.Label();
            this.Lbl_ServiceDate = new System.Windows.Forms.Label();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Lbl_ServiceCost = new System.Windows.Forms.Label();
            this.Dtp_ServiceDate = new System.Windows.Forms.DateTimePicker();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.Txt_ServiceCost = new System.Windows.Forms.TextBox();
            this.Btn_SubmitActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_ActivityID
            // 
            this.Txt_ActivityID.Location = new System.Drawing.Point(164, 21);
            this.Txt_ActivityID.Name = "Txt_ActivityID";
            this.Txt_ActivityID.ReadOnly = true;
            this.Txt_ActivityID.Size = new System.Drawing.Size(157, 27);
            this.Txt_ActivityID.TabIndex = 0;
            // 
            // Txt_ActivityName
            // 
            this.Txt_ActivityName.Location = new System.Drawing.Point(164, 69);
            this.Txt_ActivityName.MaxLength = 30;
            this.Txt_ActivityName.Name = "Txt_ActivityName";
            this.Txt_ActivityName.Size = new System.Drawing.Size(257, 27);
            this.Txt_ActivityName.TabIndex = 1;
            // 
            // Lbl_ActivityID
            // 
            this.Lbl_ActivityID.AutoSize = true;
            this.Lbl_ActivityID.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.Lbl_ActivityID.Location = new System.Drawing.Point(73, 23);
            this.Lbl_ActivityID.Name = "Lbl_ActivityID";
            this.Lbl_ActivityID.Size = new System.Drawing.Size(87, 23);
            this.Lbl_ActivityID.TabIndex = 2;
            this.Lbl_ActivityID.Text = "Activity ID";
            // 
            // Lbl_ActivityName
            // 
            this.Lbl_ActivityName.AutoSize = true;
            this.Lbl_ActivityName.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.Lbl_ActivityName.Location = new System.Drawing.Point(12, 71);
            this.Lbl_ActivityName.Name = "Lbl_ActivityName";
            this.Lbl_ActivityName.Size = new System.Drawing.Size(148, 23);
            this.Lbl_ActivityName.TabIndex = 3;
            this.Lbl_ActivityName.Text = "Workshop/Garage";
            // 
            // Lbl_ServiceDate
            // 
            this.Lbl_ServiceDate.AutoSize = true;
            this.Lbl_ServiceDate.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.Lbl_ServiceDate.Location = new System.Drawing.Point(54, 119);
            this.Lbl_ServiceDate.Name = "Lbl_ServiceDate";
            this.Lbl_ServiceDate.Size = new System.Drawing.Size(104, 23);
            this.Lbl_ServiceDate.TabIndex = 4;
            this.Lbl_ServiceDate.Text = "Service Date";
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.AutoSize = true;
            this.Lbl_Description.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.Lbl_Description.Location = new System.Drawing.Point(62, 169);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(96, 23);
            this.Lbl_Description.TabIndex = 5;
            this.Lbl_Description.Text = "Description";
            // 
            // Lbl_ServiceCost
            // 
            this.Lbl_ServiceCost.AutoSize = true;
            this.Lbl_ServiceCost.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.Lbl_ServiceCost.Location = new System.Drawing.Point(58, 278);
            this.Lbl_ServiceCost.Name = "Lbl_ServiceCost";
            this.Lbl_ServiceCost.Size = new System.Drawing.Size(102, 23);
            this.Lbl_ServiceCost.TabIndex = 6;
            this.Lbl_ServiceCost.Text = "Service Cost";
            // 
            // Dtp_ServiceDate
            // 
            this.Dtp_ServiceDate.Location = new System.Drawing.Point(164, 119);
            this.Dtp_ServiceDate.Name = "Dtp_ServiceDate";
            this.Dtp_ServiceDate.Size = new System.Drawing.Size(257, 27);
            this.Dtp_ServiceDate.TabIndex = 7;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Location = new System.Drawing.Point(164, 169);
            this.Txt_Description.MaxLength = 200;
            this.Txt_Description.Multiline = true;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(257, 86);
            this.Txt_Description.TabIndex = 8;
            // 
            // Txt_ServiceCost
            // 
            this.Txt_ServiceCost.Location = new System.Drawing.Point(164, 274);
            this.Txt_ServiceCost.MaxLength = 10;
            this.Txt_ServiceCost.Name = "Txt_ServiceCost";
            this.Txt_ServiceCost.Size = new System.Drawing.Size(157, 27);
            this.Txt_ServiceCost.TabIndex = 9;
            // 
            // Btn_SubmitActivity
            // 
            this.Btn_SubmitActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_SubmitActivity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Btn_SubmitActivity.Location = new System.Drawing.Point(294, 325);
            this.Btn_SubmitActivity.Name = "Btn_SubmitActivity";
            this.Btn_SubmitActivity.Size = new System.Drawing.Size(153, 48);
            this.Btn_SubmitActivity.TabIndex = 10;
            this.Btn_SubmitActivity.Text = "Submit Activity";
            this.Btn_SubmitActivity.UseVisualStyleBackColor = false;
            this.Btn_SubmitActivity.Click += new System.EventHandler(this.Btn_SubmitActivity_Click);
            // 
            // ServiceActivityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 385);
            this.Controls.Add(this.Btn_SubmitActivity);
            this.Controls.Add(this.Txt_ServiceCost);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.Dtp_ServiceDate);
            this.Controls.Add(this.Lbl_ServiceCost);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.Lbl_ServiceDate);
            this.Controls.Add(this.Lbl_ActivityName);
            this.Controls.Add(this.Lbl_ActivityID);
            this.Controls.Add(this.Txt_ActivityName);
            this.Controls.Add(this.Txt_ActivityID);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ServiceActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Service Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ActivityID;
        private System.Windows.Forms.TextBox Txt_ActivityName;
        private System.Windows.Forms.Label Lbl_ActivityID;
        private System.Windows.Forms.Label Lbl_ActivityName;
        private System.Windows.Forms.Label Lbl_ServiceDate;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.Label Lbl_ServiceCost;
        private System.Windows.Forms.DateTimePicker Dtp_ServiceDate;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.TextBox Txt_ServiceCost;
        private System.Windows.Forms.Button Btn_SubmitActivity;
    }
}