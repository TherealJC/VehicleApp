
namespace VehicleAppForms
{
    partial class HiringActivityForm
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
            this.lbl_activityName = new System.Windows.Forms.Label();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_hiringCost = new System.Windows.Forms.Label();
            this.txt_activityName = new System.Windows.Forms.TextBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.txt_hiringCost = new System.Windows.Forms.TextBox();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.btn_submitActivity = new System.Windows.Forms.Button();
            this.lbl_activityID = new System.Windows.Forms.Label();
            this.txt_activityID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_activityName
            // 
            this.lbl_activityName.AutoSize = true;
            this.lbl_activityName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_activityName.Location = new System.Drawing.Point(56, 68);
            this.lbl_activityName.Name = "lbl_activityName";
            this.lbl_activityName.Size = new System.Drawing.Size(116, 23);
            this.lbl_activityName.TabIndex = 1;
            this.lbl_activityName.Text = "Activity Name";
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_customerName.Location = new System.Drawing.Point(40, 115);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(135, 23);
            this.lbl_customerName.TabIndex = 2;
            this.lbl_customerName.Text = "Customer Name";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_startDate.Location = new System.Drawing.Point(31, 159);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(142, 23);
            this.lbl_startDate.TabIndex = 3;
            this.lbl_startDate.Text = "Start of Hire Date";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_endDate.Location = new System.Drawing.Point(38, 204);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(134, 23);
            this.lbl_endDate.TabIndex = 4;
            this.lbl_endDate.Text = "End of hire Date";
            // 
            // lbl_hiringCost
            // 
            this.lbl_hiringCost.AutoSize = true;
            this.lbl_hiringCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_hiringCost.Location = new System.Drawing.Point(77, 248);
            this.lbl_hiringCost.Name = "lbl_hiringCost";
            this.lbl_hiringCost.Size = new System.Drawing.Size(109, 23);
            this.lbl_hiringCost.TabIndex = 5;
            this.lbl_hiringCost.Text = "Hiring Cost $";
            // 
            // txt_activityName
            // 
            this.txt_activityName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_activityName.Location = new System.Drawing.Point(186, 68);
            this.txt_activityName.Name = "txt_activityName";
            this.txt_activityName.Size = new System.Drawing.Size(230, 27);
            this.txt_activityName.TabIndex = 7;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_customerName.Location = new System.Drawing.Point(186, 115);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(230, 27);
            this.txt_customerName.TabIndex = 8;
            // 
            // txt_hiringCost
            // 
            this.txt_hiringCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_hiringCost.Location = new System.Drawing.Point(186, 248);
            this.txt_hiringCost.Name = "txt_hiringCost";
            this.txt_hiringCost.Size = new System.Drawing.Size(113, 27);
            this.txt_hiringCost.TabIndex = 11;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_startDate.Location = new System.Drawing.Point(186, 159);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(257, 27);
            this.dtp_startDate.TabIndex = 12;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_endDate.Location = new System.Drawing.Point(186, 204);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(257, 27);
            this.dtp_endDate.TabIndex = 13;
            // 
            // btn_submitActivity
            // 
            this.btn_submitActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submitActivity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_submitActivity.Location = new System.Drawing.Point(328, 282);
            this.btn_submitActivity.Name = "btn_submitActivity";
            this.btn_submitActivity.Size = new System.Drawing.Size(147, 44);
            this.btn_submitActivity.TabIndex = 14;
            this.btn_submitActivity.Text = "Submit Activity";
            this.btn_submitActivity.UseVisualStyleBackColor = false;
            this.btn_submitActivity.Click += new System.EventHandler(this.btn_submitActivity_Click);
            // 
            // lbl_activityID
            // 
            this.lbl_activityID.AutoSize = true;
            this.lbl_activityID.Location = new System.Drawing.Point(96, 29);
            this.lbl_activityID.Name = "lbl_activityID";
            this.lbl_activityID.Size = new System.Drawing.Size(77, 20);
            this.lbl_activityID.TabIndex = 15;
            this.lbl_activityID.Text = "Activity ID";
            // 
            // txt_activityID
            // 
            this.txt_activityID.Location = new System.Drawing.Point(186, 26);
            this.txt_activityID.Name = "txt_activityID";
            this.txt_activityID.ReadOnly = true;
            this.txt_activityID.Size = new System.Drawing.Size(145, 27);
            this.txt_activityID.TabIndex = 16;
            // 
            // HiringActivityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 337);
            this.Controls.Add(this.txt_activityID);
            this.Controls.Add(this.lbl_activityID);
            this.Controls.Add(this.btn_submitActivity);
            this.Controls.Add(this.dtp_endDate);
            this.Controls.Add(this.dtp_startDate);
            this.Controls.Add(this.txt_hiringCost);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.txt_activityName);
            this.Controls.Add(this.lbl_hiringCost);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.lbl_startDate);
            this.Controls.Add(this.lbl_customerName);
            this.Controls.Add(this.lbl_activityName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "HiringActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Hiring Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_activityName;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_hiringCost;
        private System.Windows.Forms.TextBox txt_activityName;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.TextBox txt_hiringCost;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.Button btn_submitActivity;
        private System.Windows.Forms.Label lbl_activityID;
        private System.Windows.Forms.TextBox txt_activityID;
    }
}