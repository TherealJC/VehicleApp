
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
            this.lbl_activityID = new System.Windows.Forms.Label();
            this.lbl_activityName = new System.Windows.Forms.Label();
            this.lbl_relocationDate = new System.Windows.Forms.Label();
            this.lbl_kmsUsed = new System.Windows.Forms.Label();
            this.lbl_relocationCost = new System.Windows.Forms.Label();
            this.txt_activityID = new System.Windows.Forms.TextBox();
            this.txt_activityName = new System.Windows.Forms.TextBox();
            this.txt_kmsUsed = new System.Windows.Forms.TextBox();
            this.txt_relocationCost = new System.Windows.Forms.TextBox();
            this.dtp_relocationDate = new System.Windows.Forms.DateTimePicker();
            this.btn_submitActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_activityID
            // 
            this.lbl_activityID.AutoSize = true;
            this.lbl_activityID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_activityID.Location = new System.Drawing.Point(102, 22);
            this.lbl_activityID.Name = "lbl_activityID";
            this.lbl_activityID.Size = new System.Drawing.Size(87, 23);
            this.lbl_activityID.TabIndex = 0;
            this.lbl_activityID.Text = "Activity ID";
            // 
            // lbl_activityName
            // 
            this.lbl_activityName.AutoSize = true;
            this.lbl_activityName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_activityName.Location = new System.Drawing.Point(73, 69);
            this.lbl_activityName.Name = "lbl_activityName";
            this.lbl_activityName.Size = new System.Drawing.Size(116, 23);
            this.lbl_activityName.TabIndex = 1;
            this.lbl_activityName.Text = "Activity Name";
            // 
            // lbl_relocationDate
            // 
            this.lbl_relocationDate.AutoSize = true;
            this.lbl_relocationDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_relocationDate.Location = new System.Drawing.Point(58, 119);
            this.lbl_relocationDate.Name = "lbl_relocationDate";
            this.lbl_relocationDate.Size = new System.Drawing.Size(131, 23);
            this.lbl_relocationDate.TabIndex = 2;
            this.lbl_relocationDate.Text = "Relocation Date";
            // 
            // lbl_kmsUsed
            // 
            this.lbl_kmsUsed.AutoSize = true;
            this.lbl_kmsUsed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_kmsUsed.Location = new System.Drawing.Point(56, 169);
            this.lbl_kmsUsed.Name = "lbl_kmsUsed";
            this.lbl_kmsUsed.Size = new System.Drawing.Size(133, 23);
            this.lbl_kmsUsed.TabIndex = 3;
            this.lbl_kmsUsed.Text = "Kilometres Used";
            // 
            // lbl_relocationCost
            // 
            this.lbl_relocationCost.AutoSize = true;
            this.lbl_relocationCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_relocationCost.Location = new System.Drawing.Point(60, 219);
            this.lbl_relocationCost.Name = "lbl_relocationCost";
            this.lbl_relocationCost.Size = new System.Drawing.Size(129, 23);
            this.lbl_relocationCost.TabIndex = 4;
            this.lbl_relocationCost.Text = "Relocation Cost";
            // 
            // txt_activityID
            // 
            this.txt_activityID.Location = new System.Drawing.Point(195, 18);
            this.txt_activityID.Name = "txt_activityID";
            this.txt_activityID.ReadOnly = true;
            this.txt_activityID.Size = new System.Drawing.Size(164, 27);
            this.txt_activityID.TabIndex = 5;
            // 
            // txt_activityName
            // 
            this.txt_activityName.Location = new System.Drawing.Point(195, 68);
            this.txt_activityName.Name = "txt_activityName";
            this.txt_activityName.Size = new System.Drawing.Size(164, 27);
            this.txt_activityName.TabIndex = 6;
            // 
            // txt_kmsUsed
            // 
            this.txt_kmsUsed.Location = new System.Drawing.Point(195, 168);
            this.txt_kmsUsed.Name = "txt_kmsUsed";
            this.txt_kmsUsed.Size = new System.Drawing.Size(164, 27);
            this.txt_kmsUsed.TabIndex = 7;
            // 
            // txt_relocationCost
            // 
            this.txt_relocationCost.Location = new System.Drawing.Point(195, 218);
            this.txt_relocationCost.Name = "txt_relocationCost";
            this.txt_relocationCost.Size = new System.Drawing.Size(164, 27);
            this.txt_relocationCost.TabIndex = 8;
            // 
            // dtp_relocationDate
            // 
            this.dtp_relocationDate.Location = new System.Drawing.Point(195, 118);
            this.dtp_relocationDate.Name = "dtp_relocationDate";
            this.dtp_relocationDate.Size = new System.Drawing.Size(264, 27);
            this.dtp_relocationDate.TabIndex = 9;
            // 
            // btn_submitActivity
            // 
            this.btn_submitActivity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submitActivity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_submitActivity.Location = new System.Drawing.Point(380, 245);
            this.btn_submitActivity.Name = "btn_submitActivity";
            this.btn_submitActivity.Size = new System.Drawing.Size(145, 42);
            this.btn_submitActivity.TabIndex = 10;
            this.btn_submitActivity.Text = "Submit Activity";
            this.btn_submitActivity.UseVisualStyleBackColor = false;
            this.btn_submitActivity.Click += new System.EventHandler(this.btn_submitActivity_Click);
            // 
            // RelocationActivityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 303);
            this.Controls.Add(this.btn_submitActivity);
            this.Controls.Add(this.dtp_relocationDate);
            this.Controls.Add(this.txt_relocationCost);
            this.Controls.Add(this.txt_kmsUsed);
            this.Controls.Add(this.txt_activityName);
            this.Controls.Add(this.txt_activityID);
            this.Controls.Add(this.lbl_relocationCost);
            this.Controls.Add(this.lbl_kmsUsed);
            this.Controls.Add(this.lbl_relocationDate);
            this.Controls.Add(this.lbl_activityName);
            this.Controls.Add(this.lbl_activityID);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "RelocationActivityForm";
            this.Text = "New Relocation Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_activityID;
        private System.Windows.Forms.Label lbl_activityName;
        private System.Windows.Forms.Label lbl_relocationDate;
        private System.Windows.Forms.Label lbl_kmsUsed;
        private System.Windows.Forms.Label lbl_relocationCost;
        private System.Windows.Forms.TextBox txt_activityID;
        private System.Windows.Forms.TextBox txt_activityName;
        private System.Windows.Forms.TextBox txt_kmsUsed;
        private System.Windows.Forms.TextBox txt_relocationCost;
        private System.Windows.Forms.DateTimePicker dtp_relocationDate;
        private System.Windows.Forms.Button btn_submitActivity;
    }
}