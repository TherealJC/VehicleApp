
namespace SDV601_Project
{
    partial class Activity_Log
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
            this.lst_ActivityLog = new System.Windows.Forms.ListBox();
            this.btn_addActivity = new System.Windows.Forms.Button();
            this.btn_removeActivity = new System.Windows.Forms.Button();
            this.btn_modifyActivity = new System.Windows.Forms.Button();
            this.cmb_toggleSort = new System.Windows.Forms.ComboBox();
            this.lbl_toggleSort = new System.Windows.Forms.Label();
            this.lbl_vehicleRevenueTxt = new System.Windows.Forms.Label();
            this.lbl_vehicleRevenuePrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_ActivityLog
            // 
            this.lst_ActivityLog.FormattingEnabled = true;
            this.lst_ActivityLog.ItemHeight = 16;
            this.lst_ActivityLog.Location = new System.Drawing.Point(174, 32);
            this.lst_ActivityLog.Name = "lst_ActivityLog";
            this.lst_ActivityLog.Size = new System.Drawing.Size(446, 180);
            this.lst_ActivityLog.TabIndex = 0;
            // 
            // btn_addActivity
            // 
            this.btn_addActivity.Location = new System.Drawing.Point(27, 32);
            this.btn_addActivity.Name = "btn_addActivity";
            this.btn_addActivity.Size = new System.Drawing.Size(120, 41);
            this.btn_addActivity.TabIndex = 1;
            this.btn_addActivity.Text = "Add Activity";
            this.btn_addActivity.UseVisualStyleBackColor = true;
            // 
            // btn_removeActivity
            // 
            this.btn_removeActivity.Location = new System.Drawing.Point(27, 170);
            this.btn_removeActivity.Name = "btn_removeActivity";
            this.btn_removeActivity.Size = new System.Drawing.Size(120, 42);
            this.btn_removeActivity.TabIndex = 2;
            this.btn_removeActivity.Text = "Remove Activity";
            this.btn_removeActivity.UseVisualStyleBackColor = true;
            // 
            // btn_modifyActivity
            // 
            this.btn_modifyActivity.Location = new System.Drawing.Point(27, 79);
            this.btn_modifyActivity.Name = "btn_modifyActivity";
            this.btn_modifyActivity.Size = new System.Drawing.Size(120, 42);
            this.btn_modifyActivity.TabIndex = 3;
            this.btn_modifyActivity.Text = "Modify Activity";
            this.btn_modifyActivity.UseVisualStyleBackColor = true;
            // 
            // cmb_toggleSort
            // 
            this.cmb_toggleSort.FormattingEnabled = true;
            this.cmb_toggleSort.Location = new System.Drawing.Point(499, 218);
            this.cmb_toggleSort.Name = "cmb_toggleSort";
            this.cmb_toggleSort.Size = new System.Drawing.Size(121, 24);
            this.cmb_toggleSort.TabIndex = 4;
            // 
            // lbl_toggleSort
            // 
            this.lbl_toggleSort.AutoSize = true;
            this.lbl_toggleSort.Location = new System.Drawing.Point(411, 221);
            this.lbl_toggleSort.Name = "lbl_toggleSort";
            this.lbl_toggleSort.Size = new System.Drawing.Size(82, 17);
            this.lbl_toggleSort.TabIndex = 5;
            this.lbl_toggleSort.Text = "Toggle Sort";
            // 
            // lbl_vehicleRevenueTxt
            // 
            this.lbl_vehicleRevenueTxt.AutoSize = true;
            this.lbl_vehicleRevenueTxt.Location = new System.Drawing.Point(177, 221);
            this.lbl_vehicleRevenueTxt.Name = "lbl_vehicleRevenueTxt";
            this.lbl_vehicleRevenueTxt.Size = new System.Drawing.Size(112, 17);
            this.lbl_vehicleRevenueTxt.TabIndex = 6;
            this.lbl_vehicleRevenueTxt.Text = "Vehice Revenue";
            // 
            // lbl_vehicleRevenuePrice
            // 
            this.lbl_vehicleRevenuePrice.AutoSize = true;
            this.lbl_vehicleRevenuePrice.Location = new System.Drawing.Point(295, 221);
            this.lbl_vehicleRevenuePrice.Name = "lbl_vehicleRevenuePrice";
            this.lbl_vehicleRevenuePrice.Size = new System.Drawing.Size(44, 17);
            this.lbl_vehicleRevenuePrice.TabIndex = 7;
            this.lbl_vehicleRevenuePrice.Text = "$0.00";
            // 
            // Activity_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 359);
            this.Controls.Add(this.lbl_vehicleRevenuePrice);
            this.Controls.Add(this.lbl_vehicleRevenueTxt);
            this.Controls.Add(this.lbl_toggleSort);
            this.Controls.Add(this.cmb_toggleSort);
            this.Controls.Add(this.btn_modifyActivity);
            this.Controls.Add(this.btn_removeActivity);
            this.Controls.Add(this.btn_addActivity);
            this.Controls.Add(this.lst_ActivityLog);
            this.Name = "Activity_Log";
            this.Text = "Activity Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_ActivityLog;
        private System.Windows.Forms.Button btn_addActivity;
        private System.Windows.Forms.Button btn_removeActivity;
        private System.Windows.Forms.Button btn_modifyActivity;
        private System.Windows.Forms.ComboBox cmb_toggleSort;
        private System.Windows.Forms.Label lbl_toggleSort;
        private System.Windows.Forms.Label lbl_vehicleRevenueTxt;
        private System.Windows.Forms.Label lbl_vehicleRevenuePrice;
    }
}