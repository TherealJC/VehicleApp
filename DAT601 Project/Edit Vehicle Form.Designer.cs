
namespace DAT601_Project
{
    partial class Edit_Vehicle_Form
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
            this.activityLogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activityLogBtn
            // 
            this.activityLogBtn.Location = new System.Drawing.Point(366, 169);
            this.activityLogBtn.Name = "activityLogBtn";
            this.activityLogBtn.Size = new System.Drawing.Size(91, 45);
            this.activityLogBtn.TabIndex = 12;
            this.activityLogBtn.Text = "View Activity Log";
            this.activityLogBtn.UseVisualStyleBackColor = true;
            // 
            // Edit_Vehicle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(469, 270);
            this.Controls.Add(this.activityLogBtn);
            this.Name = "Edit_Vehicle_Form";
            this.Controls.SetChildIndex(this.activityLogBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button activityLogBtn;
    }
}
