
namespace VehicleAppForms
{
    partial class MainForm
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
            this.btn_createVehicle = new System.Windows.Forms.Button();
            this.btn_editVehicle = new System.Windows.Forms.Button();
            this.btn_deleteVehicle = new System.Windows.Forms.Button();
            this.lst_registration = new System.Windows.Forms.ListBox();
            this.lbl_quickView = new System.Windows.Forms.Label();
            this.lst_quickView = new System.Windows.Forms.ListBox();
            this.lbl_totalRevenue = new System.Windows.Forms.Label();
            this.lbl_displayTotalRevenue = new System.Windows.Forms.Label();
            this.btn_viewActivityLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createVehicle
            // 
            this.btn_createVehicle.Location = new System.Drawing.Point(23, 29);
            this.btn_createVehicle.Name = "btn_createVehicle";
            this.btn_createVehicle.Size = new System.Drawing.Size(156, 42);
            this.btn_createVehicle.TabIndex = 0;
            this.btn_createVehicle.Text = "Create New Vehicle";
            this.btn_createVehicle.UseVisualStyleBackColor = false;
            this.btn_createVehicle.Click += new System.EventHandler(this.btn_createVehicle_Click);
            // 
            // btn_editVehicle
            // 
            this.btn_editVehicle.Location = new System.Drawing.Point(23, 91);
            this.btn_editVehicle.Name = "btn_editVehicle";
            this.btn_editVehicle.Size = new System.Drawing.Size(156, 42);
            this.btn_editVehicle.TabIndex = 1;
            this.btn_editVehicle.Text = "Edit Vehicle";
            this.btn_editVehicle.UseVisualStyleBackColor = false;
            // 
            // btn_deleteVehicle
            // 
            this.btn_deleteVehicle.Location = new System.Drawing.Point(23, 172);
            this.btn_deleteVehicle.Name = "btn_deleteVehicle";
            this.btn_deleteVehicle.Size = new System.Drawing.Size(156, 42);
            this.btn_deleteVehicle.TabIndex = 2;
            this.btn_deleteVehicle.Text = "Delete Vehicle";
            this.btn_deleteVehicle.UseVisualStyleBackColor = false;
            this.btn_deleteVehicle.Click += new System.EventHandler(this.btn_deleteVehicle_Click);
            // 
            // lst_registration
            // 
            this.lst_registration.FormattingEnabled = true;
            this.lst_registration.ItemHeight = 20;
            this.lst_registration.Location = new System.Drawing.Point(219, 29);
            this.lst_registration.Name = "lst_registration";
            this.lst_registration.Size = new System.Drawing.Size(238, 264);
            this.lst_registration.TabIndex = 3;
            // 
            // lbl_quickView
            // 
            this.lbl_quickView.AutoSize = true;
            this.lbl_quickView.Location = new System.Drawing.Point(205, 354);
            this.lbl_quickView.Name = "lbl_quickView";
            this.lbl_quickView.Size = new System.Drawing.Size(82, 20);
            this.lbl_quickView.TabIndex = 4;
            this.lbl_quickView.Text = "Quick View";
            // 
            // lst_quickView
            // 
            this.lst_quickView.FormattingEnabled = true;
            this.lst_quickView.ItemHeight = 20;
            this.lst_quickView.Location = new System.Drawing.Point(23, 377);
            this.lst_quickView.Name = "lst_quickView";
            this.lst_quickView.Size = new System.Drawing.Size(434, 144);
            this.lst_quickView.TabIndex = 5;
            // 
            // lbl_totalRevenue
            // 
            this.lbl_totalRevenue.AutoSize = true;
            this.lbl_totalRevenue.Location = new System.Drawing.Point(19, 548);
            this.lbl_totalRevenue.Name = "lbl_totalRevenue";
            this.lbl_totalRevenue.Size = new System.Drawing.Size(122, 20);
            this.lbl_totalRevenue.TabIndex = 6;
            this.lbl_totalRevenue.Text = "Total Revenue   $";
            // 
            // lbl_displayTotalRevenue
            // 
            this.lbl_displayTotalRevenue.AutoSize = true;
            this.lbl_displayTotalRevenue.Location = new System.Drawing.Point(159, 548);
            this.lbl_displayTotalRevenue.Name = "lbl_displayTotalRevenue";
            this.lbl_displayTotalRevenue.Size = new System.Drawing.Size(36, 20);
            this.lbl_displayTotalRevenue.TabIndex = 7;
            this.lbl_displayTotalRevenue.Text = "0.00";
            // 
            // btn_viewActivityLog
            // 
            this.btn_viewActivityLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_viewActivityLog.Location = new System.Drawing.Point(329, 527);
            this.btn_viewActivityLog.Name = "btn_viewActivityLog";
            this.btn_viewActivityLog.Size = new System.Drawing.Size(128, 49);
            this.btn_viewActivityLog.TabIndex = 8;
            this.btn_viewActivityLog.Text = "View Activity Log";
            this.btn_viewActivityLog.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 588);
            this.Controls.Add(this.btn_viewActivityLog);
            this.Controls.Add(this.lbl_displayTotalRevenue);
            this.Controls.Add(this.lbl_totalRevenue);
            this.Controls.Add(this.lst_quickView);
            this.Controls.Add(this.lbl_quickView);
            this.Controls.Add(this.lst_registration);
            this.Controls.Add(this.btn_deleteVehicle);
            this.Controls.Add(this.btn_editVehicle);
            this.Controls.Add(this.btn_createVehicle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Application Database - Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createVehicle;
        private System.Windows.Forms.Button btn_editVehicle;
        private System.Windows.Forms.Button btn_deleteVehicle;
        private System.Windows.Forms.ListBox lst_registration;
        private System.Windows.Forms.Label lbl_quickView;
        private System.Windows.Forms.ListBox lst_quickView;
        private System.Windows.Forms.Label lbl_totalRevenue;
        private System.Windows.Forms.Label lbl_displayTotalRevenue;
        private System.Windows.Forms.Button btn_viewActivityLog;
    }
}

