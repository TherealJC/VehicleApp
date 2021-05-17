
namespace DAT601_Project
{
    partial class Add_Vehicle_Form
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
            this.registrationNumber = new System.Windows.Forms.TextBox();
            this.lbl_registrationNumber = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.dailyHireCost = new System.Windows.Forms.TextBox();
            this.lbl_dailyHireCost = new System.Windows.Forms.Label();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.txt_enterVehicleDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationNumber
            // 
            this.registrationNumber.Location = new System.Drawing.Point(158, 35);
            this.registrationNumber.Name = "registrationNumber";
            this.registrationNumber.Size = new System.Drawing.Size(161, 22);
            this.registrationNumber.TabIndex = 0;
            // 
            // lbl_registrationNumber
            // 
            this.lbl_registrationNumber.AutoSize = true;
            this.lbl_registrationNumber.Location = new System.Drawing.Point(18, 38);
            this.lbl_registrationNumber.Name = "lbl_registrationNumber";
            this.lbl_registrationNumber.Size = new System.Drawing.Size(138, 17);
            this.lbl_registrationNumber.TabIndex = 1;
            this.lbl_registrationNumber.Text = "Registration Number";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(158, 75);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(161, 22);
            this.make.TabIndex = 2;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(158, 114);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(161, 22);
            this.model.TabIndex = 3;
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Location = new System.Drawing.Point(110, 78);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(42, 17);
            this.lbl_make.TabIndex = 4;
            this.lbl_make.Text = "Make";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(110, 117);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(46, 17);
            this.lbl_model.TabIndex = 5;
            this.lbl_model.Text = "Model";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(158, 154);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(129, 22);
            this.year.TabIndex = 6;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(118, 157);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(38, 17);
            this.lbl_year.TabIndex = 7;
            this.lbl_year.Text = "Year";
            // 
            // dailyHireCost
            // 
            this.dailyHireCost.Location = new System.Drawing.Point(158, 194);
            this.dailyHireCost.Name = "dailyHireCost";
            this.dailyHireCost.Size = new System.Drawing.Size(129, 22);
            this.dailyHireCost.TabIndex = 8;
            // 
            // lbl_dailyHireCost
            // 
            this.lbl_dailyHireCost.AutoSize = true;
            this.lbl_dailyHireCost.Location = new System.Drawing.Point(55, 197);
            this.lbl_dailyHireCost.Name = "lbl_dailyHireCost";
            this.lbl_dailyHireCost.Size = new System.Drawing.Size(101, 17);
            this.lbl_dailyHireCost.TabIndex = 9;
            this.lbl_dailyHireCost.Text = "Daily Hire Cost";
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.Location = new System.Drawing.Point(307, 228);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(150, 30);
            this.btn_addVehicle.TabIndex = 10;
            this.btn_addVehicle.Text = "Add/Update Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = true;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // txt_enterVehicleDetails
            // 
            this.txt_enterVehicleDetails.AutoSize = true;
            this.txt_enterVehicleDetails.Location = new System.Drawing.Point(155, 9);
            this.txt_enterVehicleDetails.Name = "txt_enterVehicleDetails";
            this.txt_enterVehicleDetails.Size = new System.Drawing.Size(174, 17);
            this.txt_enterVehicleDetails.TabIndex = 11;
            this.txt_enterVehicleDetails.Text = "Enter Vehicle Details Here";
            // 
            // Add_Vehicle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 270);
            this.Controls.Add(this.txt_enterVehicleDetails);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.lbl_dailyHireCost);
            this.Controls.Add(this.dailyHireCost);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.year);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_make);
            this.Controls.Add(this.model);
            this.Controls.Add(this.make);
            this.Controls.Add(this.lbl_registrationNumber);
            this.Controls.Add(this.registrationNumber);
            this.Name = "Add_Vehicle_Form";
            this.Text = "Add Vehicle Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registrationNumber;
        private System.Windows.Forms.Label lbl_registrationNumber;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.TextBox dailyHireCost;
        private System.Windows.Forms.Label lbl_dailyHireCost;
        private System.Windows.Forms.Button btn_addVehicle;
        private System.Windows.Forms.Label txt_enterVehicleDetails;
    }
}