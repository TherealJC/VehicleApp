
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
            this.Btn_CreateVehicle = new System.Windows.Forms.Button();
            this.Btn_EditVehicle = new System.Windows.Forms.Button();
            this.Btn_DeleteVehicle = new System.Windows.Forms.Button();
            this.Lst_Registration = new System.Windows.Forms.ListBox();
            this.Lbl_QuickView = new System.Windows.Forms.Label();
            this.Lbl_TotalRevenue = new System.Windows.Forms.Label();
            this.Lbl_DisplayTotalRevenue = new System.Windows.Forms.Label();
            this.Btn_ViewActivityLog = new System.Windows.Forms.Button();
            this.Lbl_RegistrationNumber = new System.Windows.Forms.Label();
            this.Lbl_Make = new System.Windows.Forms.Label();
            this.Lbl_Model = new System.Windows.Forms.Label();
            this.Lbl_Year = new System.Windows.Forms.Label();
            this.Lbl_DailyHireCost = new System.Windows.Forms.Label();
            this.Txt_RegistrationNumber = new System.Windows.Forms.TextBox();
            this.Txt_Make = new System.Windows.Forms.TextBox();
            this.Txt_Model = new System.Windows.Forms.TextBox();
            this.Txt_Year = new System.Windows.Forms.TextBox();
            this.Txt_DailyHireCost = new System.Windows.Forms.TextBox();
            this.Lbl_VehicleInventory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_CreateVehicle
            // 
            this.Btn_CreateVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_CreateVehicle.Location = new System.Drawing.Point(23, 29);
            this.Btn_CreateVehicle.Name = "Btn_CreateVehicle";
            this.Btn_CreateVehicle.Size = new System.Drawing.Size(156, 42);
            this.Btn_CreateVehicle.TabIndex = 0;
            this.Btn_CreateVehicle.Text = "Create New Vehicle";
            this.Btn_CreateVehicle.UseVisualStyleBackColor = false;
            this.Btn_CreateVehicle.Click += new System.EventHandler(this.Btn_CreateVehicle_Click);
            // 
            // Btn_EditVehicle
            // 
            this.Btn_EditVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_EditVehicle.Location = new System.Drawing.Point(23, 88);
            this.Btn_EditVehicle.Name = "Btn_EditVehicle";
            this.Btn_EditVehicle.Size = new System.Drawing.Size(156, 42);
            this.Btn_EditVehicle.TabIndex = 1;
            this.Btn_EditVehicle.Text = "Edit Vehicle";
            this.Btn_EditVehicle.UseVisualStyleBackColor = false;
            this.Btn_EditVehicle.Click += new System.EventHandler(this.Btn_EditVehicle_Click);
            // 
            // Btn_DeleteVehicle
            // 
            this.Btn_DeleteVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_DeleteVehicle.Location = new System.Drawing.Point(23, 146);
            this.Btn_DeleteVehicle.Name = "Btn_DeleteVehicle";
            this.Btn_DeleteVehicle.Size = new System.Drawing.Size(156, 42);
            this.Btn_DeleteVehicle.TabIndex = 2;
            this.Btn_DeleteVehicle.Text = "Delete Vehicle";
            this.Btn_DeleteVehicle.UseVisualStyleBackColor = false;
            this.Btn_DeleteVehicle.Click += new System.EventHandler(this.Btn_DeleteVehicle_Click);
            // 
            // Lst_Registration
            // 
            this.Lst_Registration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_Registration.FormattingEnabled = true;
            this.Lst_Registration.ItemHeight = 20;
            this.Lst_Registration.Location = new System.Drawing.Point(219, 29);
            this.Lst_Registration.Name = "Lst_Registration";
            this.Lst_Registration.Size = new System.Drawing.Size(170, 224);
            this.Lst_Registration.TabIndex = 3;
            this.Lst_Registration.SelectedValueChanged += new System.EventHandler(this.Lst_Registration_SelectedValueChanged);
            // 
            // Lbl_QuickView
            // 
            this.Lbl_QuickView.AutoSize = true;
            this.Lbl_QuickView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuickView.Location = new System.Drawing.Point(200, 330);
            this.Lbl_QuickView.Name = "Lbl_QuickView";
            this.Lbl_QuickView.Size = new System.Drawing.Size(86, 20);
            this.Lbl_QuickView.TabIndex = 4;
            this.Lbl_QuickView.Text = "Quick View";
            // 
            // Lbl_TotalRevenue
            // 
            this.Lbl_TotalRevenue.AutoSize = true;
            this.Lbl_TotalRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalRevenue.Location = new System.Drawing.Point(200, 265);
            this.Lbl_TotalRevenue.Name = "Lbl_TotalRevenue";
            this.Lbl_TotalRevenue.Size = new System.Drawing.Size(174, 23);
            this.Lbl_TotalRevenue.TabIndex = 6;
            this.Lbl_TotalRevenue.Text = "Total Fleet Revenue $";
            // 
            // Lbl_DisplayTotalRevenue
            // 
            this.Lbl_DisplayTotalRevenue.AutoSize = true;
            this.Lbl_DisplayTotalRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DisplayTotalRevenue.Location = new System.Drawing.Point(345, 265);
            this.Lbl_DisplayTotalRevenue.Name = "Lbl_DisplayTotalRevenue";
            this.Lbl_DisplayTotalRevenue.Size = new System.Drawing.Size(41, 23);
            this.Lbl_DisplayTotalRevenue.TabIndex = 7;
            this.Lbl_DisplayTotalRevenue.Text = "0.00";
            // 
            // Btn_ViewActivityLog
            // 
            this.Btn_ViewActivityLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ViewActivityLog.Location = new System.Drawing.Point(36, 204);
            this.Btn_ViewActivityLog.Name = "Btn_ViewActivityLog";
            this.Btn_ViewActivityLog.Size = new System.Drawing.Size(128, 49);
            this.Btn_ViewActivityLog.TabIndex = 8;
            this.Btn_ViewActivityLog.Text = "View Vehicles Activity Log";
            this.Btn_ViewActivityLog.UseVisualStyleBackColor = false;
            this.Btn_ViewActivityLog.Click += new System.EventHandler(this.Btn_ViewActivityLog_Click);
            // 
            // Lbl_RegistrationNumber
            // 
            this.Lbl_RegistrationNumber.AutoSize = true;
            this.Lbl_RegistrationNumber.Location = new System.Drawing.Point(42, 366);
            this.Lbl_RegistrationNumber.Name = "Lbl_RegistrationNumber";
            this.Lbl_RegistrationNumber.Size = new System.Drawing.Size(147, 20);
            this.Lbl_RegistrationNumber.TabIndex = 9;
            this.Lbl_RegistrationNumber.Text = "Registration Number";
            // 
            // Lbl_Make
            // 
            this.Lbl_Make.AutoSize = true;
            this.Lbl_Make.Location = new System.Drawing.Point(144, 407);
            this.Lbl_Make.Name = "Lbl_Make";
            this.Lbl_Make.Size = new System.Drawing.Size(45, 20);
            this.Lbl_Make.TabIndex = 10;
            this.Lbl_Make.Text = "Make";
            // 
            // Lbl_Model
            // 
            this.Lbl_Model.AutoSize = true;
            this.Lbl_Model.Location = new System.Drawing.Point(137, 446);
            this.Lbl_Model.Name = "Lbl_Model";
            this.Lbl_Model.Size = new System.Drawing.Size(52, 20);
            this.Lbl_Model.TabIndex = 11;
            this.Lbl_Model.Text = "Model";
            // 
            // Lbl_Year
            // 
            this.Lbl_Year.AutoSize = true;
            this.Lbl_Year.Location = new System.Drawing.Point(152, 485);
            this.Lbl_Year.Name = "Lbl_Year";
            this.Lbl_Year.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_Year.Size = new System.Drawing.Size(37, 20);
            this.Lbl_Year.TabIndex = 12;
            this.Lbl_Year.Text = "Year";
            // 
            // Lbl_DailyHireCost
            // 
            this.Lbl_DailyHireCost.AutoSize = true;
            this.Lbl_DailyHireCost.Location = new System.Drawing.Point(81, 522);
            this.Lbl_DailyHireCost.Name = "Lbl_DailyHireCost";
            this.Lbl_DailyHireCost.Size = new System.Drawing.Size(108, 20);
            this.Lbl_DailyHireCost.TabIndex = 13;
            this.Lbl_DailyHireCost.Text = "Daily Hire Cost";
            // 
            // Txt_RegistrationNumber
            // 
            this.Txt_RegistrationNumber.Location = new System.Drawing.Point(204, 363);
            this.Txt_RegistrationNumber.Name = "Txt_RegistrationNumber";
            this.Txt_RegistrationNumber.ReadOnly = true;
            this.Txt_RegistrationNumber.Size = new System.Drawing.Size(141, 27);
            this.Txt_RegistrationNumber.TabIndex = 14;
            // 
            // Txt_Make
            // 
            this.Txt_Make.Location = new System.Drawing.Point(204, 404);
            this.Txt_Make.Name = "Txt_Make";
            this.Txt_Make.ReadOnly = true;
            this.Txt_Make.Size = new System.Drawing.Size(195, 27);
            this.Txt_Make.TabIndex = 15;
            // 
            // Txt_Model
            // 
            this.Txt_Model.Location = new System.Drawing.Point(204, 443);
            this.Txt_Model.Name = "Txt_Model";
            this.Txt_Model.ReadOnly = true;
            this.Txt_Model.Size = new System.Drawing.Size(195, 27);
            this.Txt_Model.TabIndex = 16;
            // 
            // Txt_Year
            // 
            this.Txt_Year.Location = new System.Drawing.Point(204, 485);
            this.Txt_Year.Name = "Txt_Year";
            this.Txt_Year.ReadOnly = true;
            this.Txt_Year.Size = new System.Drawing.Size(165, 27);
            this.Txt_Year.TabIndex = 17;
            // 
            // Txt_DailyHireCost
            // 
            this.Txt_DailyHireCost.Location = new System.Drawing.Point(204, 522);
            this.Txt_DailyHireCost.Name = "Txt_DailyHireCost";
            this.Txt_DailyHireCost.ReadOnly = true;
            this.Txt_DailyHireCost.Size = new System.Drawing.Size(141, 27);
            this.Txt_DailyHireCost.TabIndex = 18;
            // 
            // Lbl_VehicleInventory
            // 
            this.Lbl_VehicleInventory.AutoSize = true;
            this.Lbl_VehicleInventory.Location = new System.Drawing.Point(248, 9);
            this.Lbl_VehicleInventory.Name = "Lbl_VehicleInventory";
            this.Lbl_VehicleInventory.Size = new System.Drawing.Size(121, 20);
            this.Lbl_VehicleInventory.TabIndex = 19;
            this.Lbl_VehicleInventory.Text = "Vehicle Inventory";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 584);
            this.Controls.Add(this.Lbl_VehicleInventory);
            this.Controls.Add(this.Txt_DailyHireCost);
            this.Controls.Add(this.Txt_Year);
            this.Controls.Add(this.Txt_Model);
            this.Controls.Add(this.Txt_Make);
            this.Controls.Add(this.Txt_RegistrationNumber);
            this.Controls.Add(this.Lbl_DailyHireCost);
            this.Controls.Add(this.Lbl_Year);
            this.Controls.Add(this.Lbl_Model);
            this.Controls.Add(this.Lbl_Make);
            this.Controls.Add(this.Lbl_RegistrationNumber);
            this.Controls.Add(this.Btn_ViewActivityLog);
            this.Controls.Add(this.Lbl_DisplayTotalRevenue);
            this.Controls.Add(this.Lbl_TotalRevenue);
            this.Controls.Add(this.Lbl_QuickView);
            this.Controls.Add(this.Lst_Registration);
            this.Controls.Add(this.Btn_DeleteVehicle);
            this.Controls.Add(this.Btn_EditVehicle);
            this.Controls.Add(this.Btn_CreateVehicle);
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

        private System.Windows.Forms.Button Btn_CreateVehicle;
        private System.Windows.Forms.Button Btn_EditVehicle;
        private System.Windows.Forms.Button Btn_DeleteVehicle;
        private System.Windows.Forms.ListBox Lst_Registration;
        private System.Windows.Forms.Label Lbl_QuickView;
        private System.Windows.Forms.Label Lbl_TotalRevenue;
        private System.Windows.Forms.Label Lbl_DisplayTotalRevenue;
        private System.Windows.Forms.Button Btn_ViewActivityLog;
        private System.Windows.Forms.Label Lbl_RegistrationNumber;
        private System.Windows.Forms.Label Lbl_Make;
        private System.Windows.Forms.Label Lbl_Model;
        private System.Windows.Forms.Label Lbl_Year;
        private System.Windows.Forms.Label Lbl_DailyHireCost;
        private System.Windows.Forms.TextBox Txt_RegistrationNumber;
        private System.Windows.Forms.TextBox Txt_Make;
        private System.Windows.Forms.TextBox Txt_Model;
        private System.Windows.Forms.TextBox Txt_Year;
        private System.Windows.Forms.TextBox Txt_DailyHireCost;
        private System.Windows.Forms.Label Lbl_VehicleInventory;
    }
}

