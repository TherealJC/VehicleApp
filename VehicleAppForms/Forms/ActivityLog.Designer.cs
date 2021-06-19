
namespace VehicleAppForms
{
    partial class ActivityLog
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
            this.lst_activityLog = new System.Windows.Forms.ListBox();
            this.btn_addNewActivity = new System.Windows.Forms.Button();
            this.btn_editSelectedActivity = new System.Windows.Forms.Button();
            this.btn_deleteSelectedActivity = new System.Windows.Forms.Button();
            this.lbl_vehiclesActivityRevenue = new System.Windows.Forms.Label();
            this.lbl_activityDollarSign = new System.Windows.Forms.Label();
            this.txt_vehicleActivityRevenueAmount = new System.Windows.Forms.TextBox();
            this.cmb_sortBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_closeActivityLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_activityLog
            // 
            this.lst_activityLog.FormattingEnabled = true;
            this.lst_activityLog.ItemHeight = 20;
            this.lst_activityLog.Location = new System.Drawing.Point(214, 51);
            this.lst_activityLog.Name = "lst_activityLog";
            this.lst_activityLog.Size = new System.Drawing.Size(469, 184);
            this.lst_activityLog.TabIndex = 0;
            // 
            // btn_addNewActivity
            // 
            this.btn_addNewActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addNewActivity.Location = new System.Drawing.Point(22, 20);
            this.btn_addNewActivity.Name = "btn_addNewActivity";
            this.btn_addNewActivity.Size = new System.Drawing.Size(158, 54);
            this.btn_addNewActivity.TabIndex = 1;
            this.btn_addNewActivity.Text = "Add New Activity";
            this.btn_addNewActivity.UseVisualStyleBackColor = false;
            // 
            // btn_editSelectedActivity
            // 
            this.btn_editSelectedActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editSelectedActivity.Location = new System.Drawing.Point(22, 80);
            this.btn_editSelectedActivity.Name = "btn_editSelectedActivity";
            this.btn_editSelectedActivity.Size = new System.Drawing.Size(158, 54);
            this.btn_editSelectedActivity.TabIndex = 2;
            this.btn_editSelectedActivity.Text = "Modify Activity";
            this.btn_editSelectedActivity.UseVisualStyleBackColor = false;
            // 
            // btn_deleteSelectedActivity
            // 
            this.btn_deleteSelectedActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_deleteSelectedActivity.Location = new System.Drawing.Point(22, 155);
            this.btn_deleteSelectedActivity.Name = "btn_deleteSelectedActivity";
            this.btn_deleteSelectedActivity.Size = new System.Drawing.Size(158, 49);
            this.btn_deleteSelectedActivity.TabIndex = 3;
            this.btn_deleteSelectedActivity.Text = "Delete Activity";
            this.btn_deleteSelectedActivity.UseVisualStyleBackColor = false;
            // 
            // lbl_vehiclesActivityRevenue
            // 
            this.lbl_vehiclesActivityRevenue.AutoSize = true;
            this.lbl_vehiclesActivityRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiclesActivityRevenue.Location = new System.Drawing.Point(210, 248);
            this.lbl_vehiclesActivityRevenue.Name = "lbl_vehiclesActivityRevenue";
            this.lbl_vehiclesActivityRevenue.Size = new System.Drawing.Size(189, 20);
            this.lbl_vehiclesActivityRevenue.TabIndex = 4;
            this.lbl_vehiclesActivityRevenue.Text = "Vehicle\'s Activity Revenue";
            // 
            // lbl_activityDollarSign
            // 
            this.lbl_activityDollarSign.AutoSize = true;
            this.lbl_activityDollarSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_activityDollarSign.Location = new System.Drawing.Point(396, 244);
            this.lbl_activityDollarSign.Name = "lbl_activityDollarSign";
            this.lbl_activityDollarSign.Size = new System.Drawing.Size(24, 28);
            this.lbl_activityDollarSign.TabIndex = 5;
            this.lbl_activityDollarSign.Text = "$";
            // 
            // txt_vehicleActivityRevenueAmount
            // 
            this.txt_vehicleActivityRevenueAmount.Location = new System.Drawing.Point(426, 248);
            this.txt_vehicleActivityRevenueAmount.Name = "txt_vehicleActivityRevenueAmount";
            this.txt_vehicleActivityRevenueAmount.Size = new System.Drawing.Size(100, 27);
            this.txt_vehicleActivityRevenueAmount.TabIndex = 6;
            // 
            // cmb_sortBy
            // 
            this.cmb_sortBy.FormattingEnabled = true;
            this.cmb_sortBy.Items.AddRange(new object[] {
            "Name",
            "Date",
            "Max Revenue",
            "Activity Type"});
            this.cmb_sortBy.Location = new System.Drawing.Point(278, 17);
            this.cmb_sortBy.Name = "cmb_sortBy";
            this.cmb_sortBy.Size = new System.Drawing.Size(121, 28);
            this.cmb_sortBy.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sort By";
            // 
            // btn_closeActivityLog
            // 
            this.btn_closeActivityLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_closeActivityLog.Location = new System.Drawing.Point(564, 280);
            this.btn_closeActivityLog.Name = "btn_closeActivityLog";
            this.btn_closeActivityLog.Size = new System.Drawing.Size(119, 35);
            this.btn_closeActivityLog.TabIndex = 9;
            this.btn_closeActivityLog.Text = "Close";
            this.btn_closeActivityLog.UseVisualStyleBackColor = false;
            // 
            // ActivityLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 327);
            this.Controls.Add(this.btn_closeActivityLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_sortBy);
            this.Controls.Add(this.txt_vehicleActivityRevenueAmount);
            this.Controls.Add(this.lbl_activityDollarSign);
            this.Controls.Add(this.lbl_vehiclesActivityRevenue);
            this.Controls.Add(this.btn_deleteSelectedActivity);
            this.Controls.Add(this.btn_editSelectedActivity);
            this.Controls.Add(this.btn_addNewActivity);
            this.Controls.Add(this.lst_activityLog);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ActivityLog";
            this.Text = "Vehicles Activity Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_activityLog;
        private System.Windows.Forms.Button btn_addNewActivity;
        private System.Windows.Forms.Button btn_editSelectedActivity;
        private System.Windows.Forms.Button btn_deleteSelectedActivity;
        private System.Windows.Forms.Label lbl_vehiclesActivityRevenue;
        private System.Windows.Forms.Label lbl_activityDollarSign;
        private System.Windows.Forms.TextBox txt_vehicleActivityRevenueAmount;
        private System.Windows.Forms.ComboBox cmb_sortBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_closeActivityLog;
    }
}