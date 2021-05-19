
namespace SDV601_Project.Forms
{
    partial class Hiring_Activity_Form
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
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.txt_hiringCost = new System.Windows.Forms.TextBox();
            this.lbl_hiringCost = new System.Windows.Forms.Label();
            this.btn_submitHiringActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Location = new System.Drawing.Point(51, 358);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(109, 17);
            this.lbl_customerName.TabIndex = 14;
            this.lbl_customerName.Text = "Customer Name";
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(166, 397);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_startDate.TabIndex = 15;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Location = new System.Drawing.Point(164, 438);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_endDate.TabIndex = 16;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(164, 355);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(223, 22);
            this.txt_customerName.TabIndex = 17;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(88, 402);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(72, 17);
            this.lbl_startDate.TabIndex = 18;
            this.lbl_startDate.Text = "Start Date";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(91, 438);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(67, 17);
            this.lbl_endDate.TabIndex = 19;
            this.lbl_endDate.Text = "End Date";
            // 
            // txt_hiringCost
            // 
            this.txt_hiringCost.Location = new System.Drawing.Point(166, 482);
            this.txt_hiringCost.Name = "txt_hiringCost";
            this.txt_hiringCost.Size = new System.Drawing.Size(100, 22);
            this.txt_hiringCost.TabIndex = 20;
            this.txt_hiringCost.Text = "$0.00";
            // 
            // lbl_hiringCost
            // 
            this.lbl_hiringCost.AutoSize = true;
            this.lbl_hiringCost.Location = new System.Drawing.Point(83, 485);
            this.lbl_hiringCost.Name = "lbl_hiringCost";
            this.lbl_hiringCost.Size = new System.Drawing.Size(77, 17);
            this.lbl_hiringCost.TabIndex = 21;
            this.lbl_hiringCost.Text = "Hiring Cost";
            // 
            // btn_submitHiringActivity
            // 
            this.btn_submitHiringActivity.Location = new System.Drawing.Point(399, 533);
            this.btn_submitHiringActivity.Name = "btn_submitHiringActivity";
            this.btn_submitHiringActivity.Size = new System.Drawing.Size(75, 23);
            this.btn_submitHiringActivity.TabIndex = 22;
            this.btn_submitHiringActivity.Text = "Submit";
            this.btn_submitHiringActivity.UseVisualStyleBackColor = true;
            // 
            // Hiring_Activity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(568, 643);
            this.Controls.Add(this.btn_submitHiringActivity);
            this.Controls.Add(this.lbl_hiringCost);
            this.Controls.Add(this.txt_hiringCost);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.lbl_startDate);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.dtp_endDate);
            this.Controls.Add(this.dtp_startDate);
            this.Controls.Add(this.lbl_customerName);
            this.Name = "Hiring_Activity_Form";
            this.Text = "Hiring Activity Form";
            this.Controls.SetChildIndex(this.lbl_customerName, 0);
            this.Controls.SetChildIndex(this.dtp_startDate, 0);
            this.Controls.SetChildIndex(this.dtp_endDate, 0);
            this.Controls.SetChildIndex(this.txt_customerName, 0);
            this.Controls.SetChildIndex(this.lbl_startDate, 0);
            this.Controls.SetChildIndex(this.lbl_endDate, 0);
            this.Controls.SetChildIndex(this.txt_hiringCost, 0);
            this.Controls.SetChildIndex(this.lbl_hiringCost, 0);
            this.Controls.SetChildIndex(this.btn_submitHiringActivity, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.TextBox txt_hiringCost;
        private System.Windows.Forms.Label lbl_hiringCost;
        private System.Windows.Forms.Button btn_submitHiringActivity;
    }
}
