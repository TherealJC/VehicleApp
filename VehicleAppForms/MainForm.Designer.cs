
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
            this.lbl_totalRevenue = new System.Windows.Forms.Label();
            this.lbl_displayTotalRevenue = new System.Windows.Forms.Label();
            this.btn_viewActivityLog = new System.Windows.Forms.Button();
            this.lbl_registrationNumber = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_dailyHireCost = new System.Windows.Forms.Label();
            this.txt_registrationNumber = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_dailyHireCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_createVehicle
            // 
            this.btn_createVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.btn_editVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editVehicle.Location = new System.Drawing.Point(23, 91);
            this.btn_editVehicle.Name = "btn_editVehicle";
            this.btn_editVehicle.Size = new System.Drawing.Size(156, 42);
            this.btn_editVehicle.TabIndex = 1;
            this.btn_editVehicle.Text = "Edit Vehicle";
            this.btn_editVehicle.UseVisualStyleBackColor = false;
            this.btn_editVehicle.Click += new System.EventHandler(this.btn_editVehicle_Click);
            // 
            // btn_deleteVehicle
            // 
            this.btn_deleteVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.lst_registration.Size = new System.Drawing.Size(196, 244);
            this.lst_registration.TabIndex = 3;
            this.lst_registration.SelectedValueChanged += new System.EventHandler(this.lst_registration_SelectedValueChanged);
            // 
            // lbl_quickView
            // 
            this.lbl_quickView.AutoSize = true;
            this.lbl_quickView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quickView.Location = new System.Drawing.Point(188, 339);
            this.lbl_quickView.Name = "lbl_quickView";
            this.lbl_quickView.Size = new System.Drawing.Size(86, 20);
            this.lbl_quickView.TabIndex = 4;
            this.lbl_quickView.Text = "Quick View";
            // 
            // lbl_totalRevenue
            // 
            this.lbl_totalRevenue.AutoSize = true;
            this.lbl_totalRevenue.Location = new System.Drawing.Point(215, 281);
            this.lbl_totalRevenue.Name = "lbl_totalRevenue";
            this.lbl_totalRevenue.Size = new System.Drawing.Size(122, 20);
            this.lbl_totalRevenue.TabIndex = 6;
            this.lbl_totalRevenue.Text = "Total Revenue   $";
            // 
            // lbl_displayTotalRevenue
            // 
            this.lbl_displayTotalRevenue.AutoSize = true;
            this.lbl_displayTotalRevenue.Location = new System.Drawing.Point(355, 281);
            this.lbl_displayTotalRevenue.Name = "lbl_displayTotalRevenue";
            this.lbl_displayTotalRevenue.Size = new System.Drawing.Size(36, 20);
            this.lbl_displayTotalRevenue.TabIndex = 7;
            this.lbl_displayTotalRevenue.Text = "0.00";
            // 
            // btn_viewActivityLog
            // 
            this.btn_viewActivityLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_viewActivityLog.Location = new System.Drawing.Point(23, 267);
            this.btn_viewActivityLog.Name = "btn_viewActivityLog";
            this.btn_viewActivityLog.Size = new System.Drawing.Size(128, 49);
            this.btn_viewActivityLog.TabIndex = 8;
            this.btn_viewActivityLog.Text = "View Activity Log";
            this.btn_viewActivityLog.UseVisualStyleBackColor = false;
            this.btn_viewActivityLog.Click += new System.EventHandler(this.btn_viewActivityLog_Click);
            // 
            // lbl_registrationNumber
            // 
            this.lbl_registrationNumber.AutoSize = true;
            this.lbl_registrationNumber.Location = new System.Drawing.Point(32, 375);
            this.lbl_registrationNumber.Name = "lbl_registrationNumber";
            this.lbl_registrationNumber.Size = new System.Drawing.Size(147, 20);
            this.lbl_registrationNumber.TabIndex = 9;
            this.lbl_registrationNumber.Text = "Registration Number";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Location = new System.Drawing.Point(134, 416);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(45, 20);
            this.lbl_make.TabIndex = 10;
            this.lbl_make.Text = "Make";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(127, 455);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(52, 20);
            this.lbl_model.TabIndex = 11;
            this.lbl_model.Text = "Model";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(142, 494);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_year.Size = new System.Drawing.Size(37, 20);
            this.lbl_year.TabIndex = 12;
            this.lbl_year.Text = "Year";
            // 
            // lbl_dailyHireCost
            // 
            this.lbl_dailyHireCost.AutoSize = true;
            this.lbl_dailyHireCost.Location = new System.Drawing.Point(71, 531);
            this.lbl_dailyHireCost.Name = "lbl_dailyHireCost";
            this.lbl_dailyHireCost.Size = new System.Drawing.Size(108, 20);
            this.lbl_dailyHireCost.TabIndex = 13;
            this.lbl_dailyHireCost.Text = "Daily Hire Cost";
            // 
            // txt_registrationNumber
            // 
            this.txt_registrationNumber.Location = new System.Drawing.Point(194, 372);
            this.txt_registrationNumber.Name = "txt_registrationNumber";
            this.txt_registrationNumber.ReadOnly = true;
            this.txt_registrationNumber.Size = new System.Drawing.Size(141, 27);
            this.txt_registrationNumber.TabIndex = 14;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(194, 413);
            this.txt_make.Name = "txt_make";
            this.txt_make.ReadOnly = true;
            this.txt_make.Size = new System.Drawing.Size(195, 27);
            this.txt_make.TabIndex = 15;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(194, 452);
            this.txt_model.Name = "txt_model";
            this.txt_model.ReadOnly = true;
            this.txt_model.Size = new System.Drawing.Size(195, 27);
            this.txt_model.TabIndex = 16;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(194, 494);
            this.txt_year.Name = "txt_year";
            this.txt_year.ReadOnly = true;
            this.txt_year.Size = new System.Drawing.Size(165, 27);
            this.txt_year.TabIndex = 17;
            // 
            // txt_dailyHireCost
            // 
            this.txt_dailyHireCost.Location = new System.Drawing.Point(194, 531);
            this.txt_dailyHireCost.Name = "txt_dailyHireCost";
            this.txt_dailyHireCost.ReadOnly = true;
            this.txt_dailyHireCost.Size = new System.Drawing.Size(141, 27);
            this.txt_dailyHireCost.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 577);
            this.Controls.Add(this.txt_dailyHireCost);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_make);
            this.Controls.Add(this.txt_registrationNumber);
            this.Controls.Add(this.lbl_dailyHireCost);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_make);
            this.Controls.Add(this.lbl_registrationNumber);
            this.Controls.Add(this.btn_viewActivityLog);
            this.Controls.Add(this.lbl_displayTotalRevenue);
            this.Controls.Add(this.lbl_totalRevenue);
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
        private System.Windows.Forms.Label lbl_totalRevenue;
        private System.Windows.Forms.Label lbl_displayTotalRevenue;
        private System.Windows.Forms.Button btn_viewActivityLog;
        private System.Windows.Forms.Label lbl_registrationNumber;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_dailyHireCost;
        private System.Windows.Forms.TextBox txt_registrationNumber;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_dailyHireCost;
    }
}

