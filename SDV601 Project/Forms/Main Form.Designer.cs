
namespace SDV601_Project
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.btn_editVehicle = new System.Windows.Forms.Button();
            this.btn_removeVehicle = new System.Windows.Forms.Button();
            this.lbl_quickView = new System.Windows.Forms.Label();
            this.lst_registration = new System.Windows.Forms.ListBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lst_quickView = new System.Windows.Forms.ListBox();
            this.lbl_totalRevenuePrice = new System.Windows.Forms.Label();
            this.lbl_totalReventueTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.Location = new System.Drawing.Point(12, 22);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(145, 45);
            this.btn_addVehicle.TabIndex = 0;
            this.btn_addVehicle.Text = "Add Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = true;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // btn_editVehicle
            // 
            this.btn_editVehicle.Location = new System.Drawing.Point(12, 73);
            this.btn_editVehicle.Name = "btn_editVehicle";
            this.btn_editVehicle.Size = new System.Drawing.Size(145, 45);
            this.btn_editVehicle.TabIndex = 1;
            this.btn_editVehicle.Text = "Edit Vehicle";
            this.btn_editVehicle.UseVisualStyleBackColor = true;
            this.btn_editVehicle.Click += new System.EventHandler(this.btn_editVehicle_Click);
            // 
            // btn_removeVehicle
            // 
            this.btn_removeVehicle.Location = new System.Drawing.Point(12, 189);
            this.btn_removeVehicle.Name = "btn_removeVehicle";
            this.btn_removeVehicle.Size = new System.Drawing.Size(145, 45);
            this.btn_removeVehicle.TabIndex = 2;
            this.btn_removeVehicle.Text = "Remove Vehicle";
            this.btn_removeVehicle.UseVisualStyleBackColor = true;
            // 
            // lbl_quickView
            // 
            this.lbl_quickView.AutoSize = true;
            this.lbl_quickView.Location = new System.Drawing.Point(192, 272);
            this.lbl_quickView.Name = "lbl_quickView";
            this.lbl_quickView.Size = new System.Drawing.Size(77, 17);
            this.lbl_quickView.TabIndex = 4;
            this.lbl_quickView.Text = "Quick View";
            // 
            // lst_registration
            // 
            this.lst_registration.DataSource = this.vehicleBindingSource;
            this.lst_registration.DisplayMember = "RegistrationNumber";
            this.lst_registration.FormattingEnabled = true;
            this.lst_registration.ItemHeight = 16;
            this.lst_registration.Location = new System.Drawing.Point(181, 22);
            this.lst_registration.Name = "lst_registration";
            this.lst_registration.Size = new System.Drawing.Size(267, 212);
            this.lst_registration.TabIndex = 5;
            this.lst_registration.ValueMember = "RegistrationNumber";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(SDV601_Project.Vehicle);
            // 
            // lst_quickView
            // 
            this.lst_quickView.FormattingEnabled = true;
            this.lst_quickView.ItemHeight = 16;
            this.lst_quickView.Location = new System.Drawing.Point(26, 292);
            this.lst_quickView.Name = "lst_quickView";
            this.lst_quickView.Size = new System.Drawing.Size(422, 164);
            this.lst_quickView.TabIndex = 6;
            // 
            // lbl_totalRevenuePrice
            // 
            this.lbl_totalRevenuePrice.AutoSize = true;
            this.lbl_totalRevenuePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lbl_totalRevenuePrice.Location = new System.Drawing.Point(404, 492);
            this.lbl_totalRevenuePrice.Name = "lbl_totalRevenuePrice";
            this.lbl_totalRevenuePrice.Size = new System.Drawing.Size(49, 20);
            this.lbl_totalRevenuePrice.TabIndex = 7;
            this.lbl_totalRevenuePrice.Text = "$0.00";
            // 
            // lbl_totalReventueTxt
            // 
            this.lbl_totalReventueTxt.AutoSize = true;
            this.lbl_totalReventueTxt.Location = new System.Drawing.Point(297, 495);
            this.lbl_totalReventueTxt.Name = "lbl_totalReventueTxt";
            this.lbl_totalReventueTxt.Size = new System.Drawing.Size(101, 17);
            this.lbl_totalReventueTxt.TabIndex = 8;
            this.lbl_totalReventueTxt.Text = "Total Revenue";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 536);
            this.Controls.Add(this.lbl_totalReventueTxt);
            this.Controls.Add(this.lbl_totalRevenuePrice);
            this.Controls.Add(this.lst_quickView);
            this.Controls.Add(this.lst_registration);
            this.Controls.Add(this.lbl_quickView);
            this.Controls.Add(this.btn_removeVehicle);
            this.Controls.Add(this.btn_editVehicle);
            this.Controls.Add(this.btn_addVehicle);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addVehicle;
        private System.Windows.Forms.Button btn_editVehicle;
        private System.Windows.Forms.Button btn_removeVehicle;
        private System.Windows.Forms.Label lbl_quickView;
        private System.Windows.Forms.ListBox lst_registration;
        private System.Windows.Forms.ListBox lst_quickView;
        private System.Windows.Forms.Label lbl_totalRevenuePrice;
        private System.Windows.Forms.Label lbl_totalReventueTxt;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
    }
}