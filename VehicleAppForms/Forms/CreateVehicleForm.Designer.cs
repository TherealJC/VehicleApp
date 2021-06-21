
namespace VehicleAppForms
{
    partial class CreateVehicleForm
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
            this.lbl_registrationNumber = new System.Windows.Forms.Label();
            this.lbl_Make = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_dailyHireCost = new System.Windows.Forms.Label();
            this.txt_registrationNumber = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_dailyHireCost = new System.Windows.Forms.TextBox();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.lbl_dollarSignLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_registrationNumber
            // 
            this.lbl_registrationNumber.AutoSize = true;
            this.lbl_registrationNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_registrationNumber.Location = new System.Drawing.Point(22, 44);
            this.lbl_registrationNumber.Name = "lbl_registrationNumber";
            this.lbl_registrationNumber.Size = new System.Drawing.Size(157, 20);
            this.lbl_registrationNumber.TabIndex = 0;
            this.lbl_registrationNumber.Text = "Registration Number";
            // 
            // lbl_Make
            // 
            this.lbl_Make.AutoSize = true;
            this.lbl_Make.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Make.Location = new System.Drawing.Point(124, 90);
            this.lbl_Make.Name = "lbl_Make";
            this.lbl_Make.Size = new System.Drawing.Size(47, 20);
            this.lbl_Make.TabIndex = 1;
            this.lbl_Make.Text = "Make";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_model.Location = new System.Drawing.Point(117, 134);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(53, 20);
            this.lbl_model.TabIndex = 2;
            this.lbl_model.Text = "Model";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_year.Location = new System.Drawing.Point(132, 187);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(39, 20);
            this.lbl_year.TabIndex = 3;
            this.lbl_year.Text = "Year";
            // 
            // lbl_dailyHireCost
            // 
            this.lbl_dailyHireCost.AutoSize = true;
            this.lbl_dailyHireCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_dailyHireCost.Location = new System.Drawing.Point(58, 232);
            this.lbl_dailyHireCost.Name = "lbl_dailyHireCost";
            this.lbl_dailyHireCost.Size = new System.Drawing.Size(112, 20);
            this.lbl_dailyHireCost.TabIndex = 4;
            this.lbl_dailyHireCost.Text = "Daily Hire Cost";
            // 
            // txt_registrationNumber
            // 
            this.txt_registrationNumber.Location = new System.Drawing.Point(190, 41);
            this.txt_registrationNumber.MaxLength = 6;
            this.txt_registrationNumber.Name = "txt_registrationNumber";
            this.txt_registrationNumber.Size = new System.Drawing.Size(141, 27);
            this.txt_registrationNumber.TabIndex = 5;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(190, 87);
            this.txt_make.MaxLength = 30;
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(193, 27);
            this.txt_make.TabIndex = 6;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(190, 131);
            this.txt_model.MaxLength = 30;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(193, 27);
            this.txt_model.TabIndex = 7;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(190, 184);
            this.txt_year.MaxLength = 4;
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(173, 27);
            this.txt_year.TabIndex = 8;
            // 
            // txt_dailyHireCost
            // 
            this.txt_dailyHireCost.Location = new System.Drawing.Point(190, 229);
            this.txt_dailyHireCost.MaxLength = 6;
            this.txt_dailyHireCost.Name = "txt_dailyHireCost";
            this.txt_dailyHireCost.Size = new System.Drawing.Size(141, 27);
            this.txt_dailyHireCost.TabIndex = 9;
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addVehicle.Location = new System.Drawing.Point(344, 265);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(131, 43);
            this.btn_addVehicle.TabIndex = 10;
            this.btn_addVehicle.Text = "Submit Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = false;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // lbl_dollarSignLabel
            // 
            this.lbl_dollarSignLabel.AutoSize = true;
            this.lbl_dollarSignLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_dollarSignLabel.Location = new System.Drawing.Point(164, 228);
            this.lbl_dollarSignLabel.Name = "lbl_dollarSignLabel";
            this.lbl_dollarSignLabel.Size = new System.Drawing.Size(24, 28);
            this.lbl_dollarSignLabel.TabIndex = 11;
            this.lbl_dollarSignLabel.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Vehicle Details Here";
            // 
            // CreateVehicleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dollarSignLabel);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.txt_dailyHireCost);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_make);
            this.Controls.Add(this.txt_registrationNumber);
            this.Controls.Add(this.lbl_dailyHireCost);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_Make);
            this.Controls.Add(this.lbl_registrationNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter a new vehicle into the system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_registrationNumber;
        private System.Windows.Forms.Label lbl_Make;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_dailyHireCost;
        private System.Windows.Forms.TextBox txt_registrationNumber;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_dailyHireCost;
        private System.Windows.Forms.Button btn_addVehicle;
        private System.Windows.Forms.Label lbl_dollarSignLabel;
        private System.Windows.Forms.Label label1;
    }
}