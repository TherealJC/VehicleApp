
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
            this.Lbl_ActivityName = new System.Windows.Forms.Label();
            this.Lbl_customerName = new System.Windows.Forms.Label();
            this.Lbl_StartDate = new System.Windows.Forms.Label();
            this.Lbl_EndDate = new System.Windows.Forms.Label();
            this.Lbl_HiringCost = new System.Windows.Forms.Label();
            this.Txt_ActivityName = new System.Windows.Forms.TextBox();
            this.Txt_CustomerName = new System.Windows.Forms.TextBox();
            this.Txt_HiringCost = new System.Windows.Forms.TextBox();
            this.Dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.Dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_SubmitActivity = new System.Windows.Forms.Button();
            this.Lbl_ActivityID = new System.Windows.Forms.Label();
            this.Txt_ActivityID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_ActivityName
            // 
            this.Lbl_ActivityName.AutoSize = true;
            this.Lbl_ActivityName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_ActivityName.Location = new System.Drawing.Point(56, 72);
            this.Lbl_ActivityName.Name = "Lbl_ActivityName";
            this.Lbl_ActivityName.Size = new System.Drawing.Size(116, 23);
            this.Lbl_ActivityName.TabIndex = 1;
            this.Lbl_ActivityName.Text = "Activity Name";
            // 
            // Lbl_customerName
            // 
            this.Lbl_customerName.AutoSize = true;
            this.Lbl_customerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_customerName.Location = new System.Drawing.Point(40, 115);
            this.Lbl_customerName.Name = "Lbl_customerName";
            this.Lbl_customerName.Size = new System.Drawing.Size(135, 23);
            this.Lbl_customerName.TabIndex = 2;
            this.Lbl_customerName.Text = "Customer Name";
            // 
            // Lbl_StartDate
            // 
            this.Lbl_StartDate.AutoSize = true;
            this.Lbl_StartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_StartDate.Location = new System.Drawing.Point(31, 159);
            this.Lbl_StartDate.Name = "Lbl_StartDate";
            this.Lbl_StartDate.Size = new System.Drawing.Size(142, 23);
            this.Lbl_StartDate.TabIndex = 3;
            this.Lbl_StartDate.Text = "Start of Hire Date";
            // 
            // Lbl_EndDate
            // 
            this.Lbl_EndDate.AutoSize = true;
            this.Lbl_EndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_EndDate.Location = new System.Drawing.Point(38, 204);
            this.Lbl_EndDate.Name = "Lbl_EndDate";
            this.Lbl_EndDate.Size = new System.Drawing.Size(134, 23);
            this.Lbl_EndDate.TabIndex = 4;
            this.Lbl_EndDate.Text = "End of hire Date";
            // 
            // Lbl_HiringCost
            // 
            this.Lbl_HiringCost.AutoSize = true;
            this.Lbl_HiringCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_HiringCost.Location = new System.Drawing.Point(77, 248);
            this.Lbl_HiringCost.Name = "Lbl_HiringCost";
            this.Lbl_HiringCost.Size = new System.Drawing.Size(109, 23);
            this.Lbl_HiringCost.TabIndex = 5;
            this.Lbl_HiringCost.Text = "Hiring Cost $";
            // 
            // Txt_ActivityName
            // 
            this.Txt_ActivityName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_ActivityName.Location = new System.Drawing.Point(186, 71);
            this.Txt_ActivityName.MaxLength = 30;
            this.Txt_ActivityName.Name = "Txt_ActivityName";
            this.Txt_ActivityName.Size = new System.Drawing.Size(230, 27);
            this.Txt_ActivityName.TabIndex = 7;
            // 
            // Txt_CustomerName
            // 
            this.Txt_CustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_CustomerName.Location = new System.Drawing.Point(186, 115);
            this.Txt_CustomerName.MaxLength = 30;
            this.Txt_CustomerName.Name = "Txt_CustomerName";
            this.Txt_CustomerName.Size = new System.Drawing.Size(230, 27);
            this.Txt_CustomerName.TabIndex = 8;
            // 
            // Txt_HiringCost
            // 
            this.Txt_HiringCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_HiringCost.Location = new System.Drawing.Point(186, 248);
            this.Txt_HiringCost.MaxLength = 10;
            this.Txt_HiringCost.Name = "Txt_HiringCost";
            this.Txt_HiringCost.ReadOnly = true;
            this.Txt_HiringCost.Size = new System.Drawing.Size(129, 27);
            this.Txt_HiringCost.TabIndex = 11;
            // 
            // Dtp_StartDate
            // 
            this.Dtp_StartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dtp_StartDate.Location = new System.Drawing.Point(186, 159);
            this.Dtp_StartDate.Name = "Dtp_StartDate";
            this.Dtp_StartDate.Size = new System.Drawing.Size(257, 27);
            this.Dtp_StartDate.TabIndex = 12;
            this.Dtp_StartDate.ValueChanged += new System.EventHandler(this.Dtp_StartDate_ValueChanged);
            // 
            // Dtp_EndDate
            // 
            this.Dtp_EndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dtp_EndDate.Location = new System.Drawing.Point(186, 204);
            this.Dtp_EndDate.Name = "Dtp_EndDate";
            this.Dtp_EndDate.Size = new System.Drawing.Size(257, 27);
            this.Dtp_EndDate.TabIndex = 13;
            this.Dtp_EndDate.ValueChanged += new System.EventHandler(this.Dtp_EndDate_ValueChanged);
            // 
            // Btn_SubmitActivity
            // 
            this.Btn_SubmitActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_SubmitActivity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Btn_SubmitActivity.Location = new System.Drawing.Point(328, 282);
            this.Btn_SubmitActivity.Name = "Btn_SubmitActivity";
            this.Btn_SubmitActivity.Size = new System.Drawing.Size(147, 44);
            this.Btn_SubmitActivity.TabIndex = 14;
            this.Btn_SubmitActivity.Text = "Submit Activity";
            this.Btn_SubmitActivity.UseVisualStyleBackColor = false;
            this.Btn_SubmitActivity.Click += new System.EventHandler(this.Btn_SubmitActivity_Click);
            // 
            // Lbl_ActivityID
            // 
            this.Lbl_ActivityID.AutoSize = true;
            this.Lbl_ActivityID.Location = new System.Drawing.Point(96, 29);
            this.Lbl_ActivityID.Name = "Lbl_ActivityID";
            this.Lbl_ActivityID.Size = new System.Drawing.Size(77, 20);
            this.Lbl_ActivityID.TabIndex = 15;
            this.Lbl_ActivityID.Text = "Activity ID";
            // 
            // Txt_ActivityID
            // 
            this.Txt_ActivityID.Location = new System.Drawing.Point(186, 26);
            this.Txt_ActivityID.Name = "Txt_ActivityID";
            this.Txt_ActivityID.ReadOnly = true;
            this.Txt_ActivityID.Size = new System.Drawing.Size(145, 27);
            this.Txt_ActivityID.TabIndex = 16;
            // 
            // HiringActivityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 337);
            this.Controls.Add(this.Txt_ActivityID);
            this.Controls.Add(this.Lbl_ActivityID);
            this.Controls.Add(this.Btn_SubmitActivity);
            this.Controls.Add(this.Dtp_EndDate);
            this.Controls.Add(this.Dtp_StartDate);
            this.Controls.Add(this.Txt_HiringCost);
            this.Controls.Add(this.Txt_CustomerName);
            this.Controls.Add(this.Txt_ActivityName);
            this.Controls.Add(this.Lbl_HiringCost);
            this.Controls.Add(this.Lbl_EndDate);
            this.Controls.Add(this.Lbl_StartDate);
            this.Controls.Add(this.Lbl_customerName);
            this.Controls.Add(this.Lbl_ActivityName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "HiringActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Hiring Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_ActivityName;
        private System.Windows.Forms.Label Lbl_customerName;
        private System.Windows.Forms.Label Lbl_StartDate;
        private System.Windows.Forms.Label Lbl_EndDate;
        private System.Windows.Forms.Label Lbl_HiringCost;
        private System.Windows.Forms.TextBox Txt_ActivityName;
        private System.Windows.Forms.TextBox Txt_CustomerName;
        private System.Windows.Forms.TextBox Txt_HiringCost;
        private System.Windows.Forms.DateTimePicker Dtp_StartDate;
        private System.Windows.Forms.DateTimePicker Dtp_EndDate;
        private System.Windows.Forms.Button Btn_SubmitActivity;
        private System.Windows.Forms.Label Lbl_ActivityID;
        private System.Windows.Forms.TextBox Txt_ActivityID;
    }
}