
namespace SDV601_Project.Forms
{
    partial class Service_Activity_Form
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
            this.lbl_workshop = new System.Windows.Forms.Label();
            this.lbl_dateOfService = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_serviceCost = new System.Windows.Forms.Label();
            this.txt_serviceCost = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_workshop = new System.Windows.Forms.TextBox();
            this.dtp_dateOfService = new System.Windows.Forms.DateTimePicker();
            this.btn_submitServiceActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_workshop
            // 
            this.lbl_workshop.AutoSize = true;
            this.lbl_workshop.Location = new System.Drawing.Point(73, 398);
            this.lbl_workshop.Name = "lbl_workshop";
            this.lbl_workshop.Size = new System.Drawing.Size(132, 17);
            this.lbl_workshop.TabIndex = 15;
            this.lbl_workshop.Text = "Workshop / Garage";
            // 
            // lbl_dateOfService
            // 
            this.lbl_dateOfService.AutoSize = true;
            this.lbl_dateOfService.Location = new System.Drawing.Point(94, 439);
            this.lbl_dateOfService.Name = "lbl_dateOfService";
            this.lbl_dateOfService.Size = new System.Drawing.Size(105, 17);
            this.lbl_dateOfService.TabIndex = 16;
            this.lbl_dateOfService.Text = "Date of Service";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(120, 481);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(79, 17);
            this.lbl_description.TabIndex = 17;
            this.lbl_description.Text = "Description";
            // 
            // lbl_serviceCost
            // 
            this.lbl_serviceCost.AutoSize = true;
            this.lbl_serviceCost.Location = new System.Drawing.Point(112, 558);
            this.lbl_serviceCost.Name = "lbl_serviceCost";
            this.lbl_serviceCost.Size = new System.Drawing.Size(87, 17);
            this.lbl_serviceCost.TabIndex = 18;
            this.lbl_serviceCost.Text = "Service Cost";
            // 
            // txt_serviceCost
            // 
            this.txt_serviceCost.Location = new System.Drawing.Point(220, 555);
            this.txt_serviceCost.Name = "txt_serviceCost";
            this.txt_serviceCost.Size = new System.Drawing.Size(100, 22);
            this.txt_serviceCost.TabIndex = 19;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(220, 481);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(247, 66);
            this.txt_description.TabIndex = 20;
            // 
            // txt_workshop
            // 
            this.txt_workshop.Location = new System.Drawing.Point(220, 395);
            this.txt_workshop.Name = "txt_workshop";
            this.txt_workshop.Size = new System.Drawing.Size(204, 22);
            this.txt_workshop.TabIndex = 21;
            // 
            // dtp_dateOfService
            // 
            this.dtp_dateOfService.Location = new System.Drawing.Point(220, 439);
            this.dtp_dateOfService.Name = "dtp_dateOfService";
            this.dtp_dateOfService.Size = new System.Drawing.Size(247, 22);
            this.dtp_dateOfService.TabIndex = 22;
            // 
            // btn_submitServiceActivity
            // 
            this.btn_submitServiceActivity.Location = new System.Drawing.Point(441, 584);
            this.btn_submitServiceActivity.Name = "btn_submitServiceActivity";
            this.btn_submitServiceActivity.Size = new System.Drawing.Size(139, 42);
            this.btn_submitServiceActivity.TabIndex = 23;
            this.btn_submitServiceActivity.Text = "Submit";
            this.btn_submitServiceActivity.UseVisualStyleBackColor = true;
            // 
            // Service_Activity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(592, 648);
            this.Controls.Add(this.btn_submitServiceActivity);
            this.Controls.Add(this.dtp_dateOfService);
            this.Controls.Add(this.txt_workshop);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_serviceCost);
            this.Controls.Add(this.lbl_serviceCost);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_dateOfService);
            this.Controls.Add(this.lbl_workshop);
            this.Name = "Service_Activity_Form";
            this.Text = "Service Activity Form";
            this.Controls.SetChildIndex(this.lbl_workshop, 0);
            this.Controls.SetChildIndex(this.lbl_dateOfService, 0);
            this.Controls.SetChildIndex(this.lbl_description, 0);
            this.Controls.SetChildIndex(this.lbl_serviceCost, 0);
            this.Controls.SetChildIndex(this.txt_serviceCost, 0);
            this.Controls.SetChildIndex(this.txt_description, 0);
            this.Controls.SetChildIndex(this.txt_workshop, 0);
            this.Controls.SetChildIndex(this.dtp_dateOfService, 0);
            this.Controls.SetChildIndex(this.btn_submitServiceActivity, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_workshop;
        private System.Windows.Forms.Label lbl_dateOfService;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_serviceCost;
        private System.Windows.Forms.TextBox txt_serviceCost;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_workshop;
        private System.Windows.Forms.DateTimePicker dtp_dateOfService;
        private System.Windows.Forms.Button btn_submitServiceActivity;
    }
}
