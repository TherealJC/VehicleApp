
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
            this.Lst_ActivityLog = new System.Windows.Forms.ListBox();
            this.Btn_AddNewActivity = new System.Windows.Forms.Button();
            this.Btn_EditSelectedActivity = new System.Windows.Forms.Button();
            this.Btn_DeleteSelectedActivity = new System.Windows.Forms.Button();
            this.Lbl_VehiclesActivityRevenue = new System.Windows.Forms.Label();
            this.Lbl_activityDollarSign = new System.Windows.Forms.Label();
            this.Txt_VehicleActivityRevenueAmount = new System.Windows.Forms.TextBox();
            this.Cmb_SortBy = new System.Windows.Forms.ComboBox();
            this.Lbl_SortBy = new System.Windows.Forms.Label();
            this.Btn_CloseActivityLog = new System.Windows.Forms.Button();
            this.Lbl_ActivityType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lst_ActivityLog
            // 
            this.Lst_ActivityLog.FormattingEnabled = true;
            this.Lst_ActivityLog.ItemHeight = 20;
            this.Lst_ActivityLog.Location = new System.Drawing.Point(214, 52);
            this.Lst_ActivityLog.Name = "Lst_ActivityLog";
            this.Lst_ActivityLog.Size = new System.Drawing.Size(663, 184);
            this.Lst_ActivityLog.TabIndex = 0;
            // 
            // Btn_AddNewActivity
            // 
            this.Btn_AddNewActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_AddNewActivity.Location = new System.Drawing.Point(22, 20);
            this.Btn_AddNewActivity.Name = "Btn_AddNewActivity";
            this.Btn_AddNewActivity.Size = new System.Drawing.Size(158, 54);
            this.Btn_AddNewActivity.TabIndex = 1;
            this.Btn_AddNewActivity.Text = "Add New Activity";
            this.Btn_AddNewActivity.UseVisualStyleBackColor = false;
            this.Btn_AddNewActivity.Click += new System.EventHandler(this.Btn_AddNewActivity_Click);
            // 
            // Btn_EditSelectedActivity
            // 
            this.Btn_EditSelectedActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_EditSelectedActivity.Location = new System.Drawing.Point(22, 80);
            this.Btn_EditSelectedActivity.Name = "Btn_EditSelectedActivity";
            this.Btn_EditSelectedActivity.Size = new System.Drawing.Size(158, 54);
            this.Btn_EditSelectedActivity.TabIndex = 2;
            this.Btn_EditSelectedActivity.Text = "Modify Activity";
            this.Btn_EditSelectedActivity.UseVisualStyleBackColor = false;
            this.Btn_EditSelectedActivity.Click += new System.EventHandler(this.Btn_EditSelectedActivity_Click);
            // 
            // Btn_DeleteSelectedActivity
            // 
            this.Btn_DeleteSelectedActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_DeleteSelectedActivity.Location = new System.Drawing.Point(22, 155);
            this.Btn_DeleteSelectedActivity.Name = "Btn_DeleteSelectedActivity";
            this.Btn_DeleteSelectedActivity.Size = new System.Drawing.Size(158, 49);
            this.Btn_DeleteSelectedActivity.TabIndex = 3;
            this.Btn_DeleteSelectedActivity.Text = "Delete Activity";
            this.Btn_DeleteSelectedActivity.UseVisualStyleBackColor = false;
            this.Btn_DeleteSelectedActivity.Click += new System.EventHandler(this.Btn_DeleteSelectedActivity_Click);
            // 
            // Lbl_VehiclesActivityRevenue
            // 
            this.Lbl_VehiclesActivityRevenue.AutoSize = true;
            this.Lbl_VehiclesActivityRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_VehiclesActivityRevenue.Location = new System.Drawing.Point(210, 245);
            this.Lbl_VehiclesActivityRevenue.Name = "Lbl_VehiclesActivityRevenue";
            this.Lbl_VehiclesActivityRevenue.Size = new System.Drawing.Size(189, 20);
            this.Lbl_VehiclesActivityRevenue.TabIndex = 4;
            this.Lbl_VehiclesActivityRevenue.Text = "Vehicle\'s Activity Revenue";
            // 
            // Lbl_activityDollarSign
            // 
            this.Lbl_activityDollarSign.AutoSize = true;
            this.Lbl_activityDollarSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_activityDollarSign.Location = new System.Drawing.Point(396, 241);
            this.Lbl_activityDollarSign.Name = "Lbl_activityDollarSign";
            this.Lbl_activityDollarSign.Size = new System.Drawing.Size(24, 28);
            this.Lbl_activityDollarSign.TabIndex = 5;
            this.Lbl_activityDollarSign.Text = "$";
            // 
            // Txt_VehicleActivityRevenueAmount
            // 
            this.Txt_VehicleActivityRevenueAmount.Location = new System.Drawing.Point(426, 241);
            this.Txt_VehicleActivityRevenueAmount.Name = "Txt_VehicleActivityRevenueAmount";
            this.Txt_VehicleActivityRevenueAmount.ReadOnly = true;
            this.Txt_VehicleActivityRevenueAmount.Size = new System.Drawing.Size(142, 27);
            this.Txt_VehicleActivityRevenueAmount.TabIndex = 6;
            // 
            // Cmb_SortBy
            // 
            this.Cmb_SortBy.FormattingEnabled = true;
            this.Cmb_SortBy.Items.AddRange(new object[] {
            "Name",
            "Date",
            "Highest Cost",
            "Activity Type",
            "Activity ID"});
            this.Cmb_SortBy.Location = new System.Drawing.Point(756, 17);
            this.Cmb_SortBy.Name = "Cmb_SortBy";
            this.Cmb_SortBy.Size = new System.Drawing.Size(121, 28);
            this.Cmb_SortBy.TabIndex = 7;
            this.Cmb_SortBy.SelectedIndexChanged += new System.EventHandler(this.Cmb_SortBy_SelectedIndexChanged);
            // 
            // Lbl_SortBy
            // 
            this.Lbl_SortBy.AutoSize = true;
            this.Lbl_SortBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SortBy.Location = new System.Drawing.Point(688, 20);
            this.Lbl_SortBy.Name = "Lbl_SortBy";
            this.Lbl_SortBy.Size = new System.Drawing.Size(60, 20);
            this.Lbl_SortBy.TabIndex = 8;
            this.Lbl_SortBy.Text = "Sort By";
            // 
            // Btn_CloseActivityLog
            // 
            this.Btn_CloseActivityLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_CloseActivityLog.Location = new System.Drawing.Point(758, 254);
            this.Btn_CloseActivityLog.Name = "Btn_CloseActivityLog";
            this.Btn_CloseActivityLog.Size = new System.Drawing.Size(119, 35);
            this.Btn_CloseActivityLog.TabIndex = 9;
            this.Btn_CloseActivityLog.Text = "Close";
            this.Btn_CloseActivityLog.UseVisualStyleBackColor = false;
            this.Btn_CloseActivityLog.Click += new System.EventHandler(this.Btn_CloseActivityLog_Click);
            // 
            // Lbl_ActivityType
            // 
            this.Lbl_ActivityType.AutoSize = true;
            this.Lbl_ActivityType.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ActivityType.Location = new System.Drawing.Point(210, 30);
            this.Lbl_ActivityType.Name = "Lbl_ActivityType";
            this.Lbl_ActivityType.Size = new System.Drawing.Size(90, 19);
            this.Lbl_ActivityType.TabIndex = 10;
            this.Lbl_ActivityType.Text = "Activity Type";
            // 
            // ActivityLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 309);
            this.Controls.Add(this.Lbl_ActivityType);
            this.Controls.Add(this.Btn_CloseActivityLog);
            this.Controls.Add(this.Lbl_SortBy);
            this.Controls.Add(this.Cmb_SortBy);
            this.Controls.Add(this.Txt_VehicleActivityRevenueAmount);
            this.Controls.Add(this.Lbl_activityDollarSign);
            this.Controls.Add(this.Lbl_VehiclesActivityRevenue);
            this.Controls.Add(this.Btn_DeleteSelectedActivity);
            this.Controls.Add(this.Btn_EditSelectedActivity);
            this.Controls.Add(this.Btn_AddNewActivity);
            this.Controls.Add(this.Lst_ActivityLog);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ActivityLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles Activity Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_ActivityLog;
        private System.Windows.Forms.Button Btn_AddNewActivity;
        private System.Windows.Forms.Button Btn_EditSelectedActivity;
        private System.Windows.Forms.Button Btn_DeleteSelectedActivity;
        private System.Windows.Forms.Label Lbl_VehiclesActivityRevenue;
        private System.Windows.Forms.Label Lbl_activityDollarSign;
        private System.Windows.Forms.TextBox Txt_VehicleActivityRevenueAmount;
        private System.Windows.Forms.ComboBox Cmb_SortBy;
        private System.Windows.Forms.Label Lbl_SortBy;
        private System.Windows.Forms.Button Btn_CloseActivityLog;
        private System.Windows.Forms.Label Lbl_ActivityType;
    }
}