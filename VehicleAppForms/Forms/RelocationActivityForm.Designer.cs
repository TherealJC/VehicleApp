
namespace VehicleAppForms
{
    partial class RelocationActivityForm
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
            this.Lbl_ActivityID = new System.Windows.Forms.Label();
            this.Lbl_ActivityName = new System.Windows.Forms.Label();
            this.Lbl_RelocationDate = new System.Windows.Forms.Label();
            this.Lbl_KmsUsed = new System.Windows.Forms.Label();
            this.Lbl_RelocationCost = new System.Windows.Forms.Label();
            this.Txt_ActivityID = new System.Windows.Forms.TextBox();
            this.Txt_ActivityName = new System.Windows.Forms.TextBox();
            this.Txt_KmsUsed = new System.Windows.Forms.TextBox();
            this.Txt_RelocationCost = new System.Windows.Forms.TextBox();
            this.Dtp_RelocationDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_SubmitActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_ActivityID
            // 
            this.Lbl_ActivityID.AutoSize = true;
            this.Lbl_ActivityID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_ActivityID.Location = new System.Drawing.Point(102, 22);
            this.Lbl_ActivityID.Name = "Lbl_ActivityID";
            this.Lbl_ActivityID.Size = new System.Drawing.Size(87, 23);
            this.Lbl_ActivityID.TabIndex = 0;
            this.Lbl_ActivityID.Text = "Activity ID";
            // 
            // Lbl_ActivityName
            // 
            this.Lbl_ActivityName.AutoSize = true;
            this.Lbl_ActivityName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_ActivityName.Location = new System.Drawing.Point(46, 72);
            this.Lbl_ActivityName.Name = "Lbl_ActivityName";
            this.Lbl_ActivityName.Size = new System.Drawing.Size(143, 23);
            this.Lbl_ActivityName.TabIndex = 1;
            this.Lbl_ActivityName.Text = "Location From/To";
            // 
            // Lbl_RelocationDate
            // 
            this.Lbl_RelocationDate.AutoSize = true;
            this.Lbl_RelocationDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_RelocationDate.Location = new System.Drawing.Point(58, 119);
            this.Lbl_RelocationDate.Name = "Lbl_RelocationDate";
            this.Lbl_RelocationDate.Size = new System.Drawing.Size(131, 23);
            this.Lbl_RelocationDate.TabIndex = 2;
            this.Lbl_RelocationDate.Text = "Relocation Date";
            // 
            // Lbl_KmsUsed
            // 
            this.Lbl_KmsUsed.AutoSize = true;
            this.Lbl_KmsUsed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_KmsUsed.Location = new System.Drawing.Point(56, 169);
            this.Lbl_KmsUsed.Name = "Lbl_KmsUsed";
            this.Lbl_KmsUsed.Size = new System.Drawing.Size(133, 23);
            this.Lbl_KmsUsed.TabIndex = 3;
            this.Lbl_KmsUsed.Text = "Kilometres Used";
            // 
            // Lbl_RelocationCost
            // 
            this.Lbl_RelocationCost.AutoSize = true;
            this.Lbl_RelocationCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_RelocationCost.Location = new System.Drawing.Point(46, 219);
            this.Lbl_RelocationCost.Name = "Lbl_RelocationCost";
            this.Lbl_RelocationCost.Size = new System.Drawing.Size(143, 23);
            this.Lbl_RelocationCost.TabIndex = 4;
            this.Lbl_RelocationCost.Text = "Relocation Cost $";
            // 
            // Txt_ActivityID
            // 
            this.Txt_ActivityID.Location = new System.Drawing.Point(195, 18);
            this.Txt_ActivityID.Name = "Txt_ActivityID";
            this.Txt_ActivityID.ReadOnly = true;
            this.Txt_ActivityID.Size = new System.Drawing.Size(164, 27);
            this.Txt_ActivityID.TabIndex = 5;
            // 
            // Txt_ActivityName
            // 
            this.Txt_ActivityName.Location = new System.Drawing.Point(195, 71);
            this.Txt_ActivityName.MaxLength = 30;
            this.Txt_ActivityName.Name = "Txt_ActivityName";
            this.Txt_ActivityName.Size = new System.Drawing.Size(264, 27);
            this.Txt_ActivityName.TabIndex = 6;
            // 
            // Txt_KmsUsed
            // 
            this.Txt_KmsUsed.Location = new System.Drawing.Point(195, 168);
            this.Txt_KmsUsed.MaxLength = 5;
            this.Txt_KmsUsed.Name = "Txt_KmsUsed";
            this.Txt_KmsUsed.Size = new System.Drawing.Size(164, 27);
            this.Txt_KmsUsed.TabIndex = 7;
            // 
            // Txt_RelocationCost
            // 
            this.Txt_RelocationCost.Location = new System.Drawing.Point(195, 218);
            this.Txt_RelocationCost.MaxLength = 10;
            this.Txt_RelocationCost.Name = "Txt_RelocationCost";
            this.Txt_RelocationCost.Size = new System.Drawing.Size(164, 27);
            this.Txt_RelocationCost.TabIndex = 8;
            // 
            // Dtp_RelocationDate
            // 
            this.Dtp_RelocationDate.Location = new System.Drawing.Point(195, 118);
            this.Dtp_RelocationDate.Name = "Dtp_RelocationDate";
            this.Dtp_RelocationDate.Size = new System.Drawing.Size(264, 27);
            this.Dtp_RelocationDate.TabIndex = 9;
            // 
            // Btn_SubmitActivity
            // 
            this.Btn_SubmitActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_SubmitActivity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Btn_SubmitActivity.Location = new System.Drawing.Point(380, 245);
            this.Btn_SubmitActivity.Name = "Btn_SubmitActivity";
            this.Btn_SubmitActivity.Size = new System.Drawing.Size(145, 42);
            this.Btn_SubmitActivity.TabIndex = 10;
            this.Btn_SubmitActivity.Text = "Submit Activity";
            this.Btn_SubmitActivity.UseVisualStyleBackColor = false;
            this.Btn_SubmitActivity.Click += new System.EventHandler(this.Btn_SubmitActivity_Click);
            // 
            // RelocationActivityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 301);
            this.Controls.Add(this.Btn_SubmitActivity);
            this.Controls.Add(this.Dtp_RelocationDate);
            this.Controls.Add(this.Txt_RelocationCost);
            this.Controls.Add(this.Txt_KmsUsed);
            this.Controls.Add(this.Txt_ActivityName);
            this.Controls.Add(this.Txt_ActivityID);
            this.Controls.Add(this.Lbl_RelocationCost);
            this.Controls.Add(this.Lbl_KmsUsed);
            this.Controls.Add(this.Lbl_RelocationDate);
            this.Controls.Add(this.Lbl_ActivityName);
            this.Controls.Add(this.Lbl_ActivityID);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "RelocationActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Relocation Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ActivityID;
        private System.Windows.Forms.Label Lbl_ActivityName;
        private System.Windows.Forms.Label Lbl_RelocationDate;
        private System.Windows.Forms.Label Lbl_KmsUsed;
        private System.Windows.Forms.Label Lbl_RelocationCost;
        private System.Windows.Forms.TextBox Txt_ActivityID;
        private System.Windows.Forms.TextBox Txt_ActivityName;
        private System.Windows.Forms.TextBox Txt_KmsUsed;
        private System.Windows.Forms.TextBox Txt_RelocationCost;
        private System.Windows.Forms.DateTimePicker Dtp_RelocationDate;
        private System.Windows.Forms.Button Btn_SubmitActivity;
    }
}