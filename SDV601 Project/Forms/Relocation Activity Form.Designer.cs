
namespace SDV601_Project.Forms
{
    partial class Relocation_Activity_Form
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
            this.lbl_relocation = new System.Windows.Forms.Label();
            this.lbl_kmsUsed = new System.Windows.Forms.Label();
            this.lbl_relocationCost = new System.Windows.Forms.Label();
            this.txt_relocation = new System.Windows.Forms.TextBox();
            this.txt_kmsUsed = new System.Windows.Forms.TextBox();
            this.txt_relocationCost = new System.Windows.Forms.TextBox();
            this.btn_submitRelocationActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_relocation
            // 
            this.lbl_relocation.AutoSize = true;
            this.lbl_relocation.Location = new System.Drawing.Point(68, 369);
            this.lbl_relocation.Name = "lbl_relocation";
            this.lbl_relocation.Size = new System.Drawing.Size(129, 17);
            this.lbl_relocation.TabIndex = 15;
            this.lbl_relocation.Text = "Relocated From/To";
            // 
            // lbl_kmsUsed
            // 
            this.lbl_kmsUsed.AutoSize = true;
            this.lbl_kmsUsed.Location = new System.Drawing.Point(86, 423);
            this.lbl_kmsUsed.Name = "lbl_kmsUsed";
            this.lbl_kmsUsed.Size = new System.Drawing.Size(111, 17);
            this.lbl_kmsUsed.TabIndex = 16;
            this.lbl_kmsUsed.Text = "Kilometres Used";
            // 
            // lbl_relocationCost
            // 
            this.lbl_relocationCost.AutoSize = true;
            this.lbl_relocationCost.Location = new System.Drawing.Point(62, 476);
            this.lbl_relocationCost.Name = "lbl_relocationCost";
            this.lbl_relocationCost.Size = new System.Drawing.Size(135, 17);
            this.lbl_relocationCost.TabIndex = 17;
            this.lbl_relocationCost.Text = "Relocation Cost     $";
            // 
            // txt_relocation
            // 
            this.txt_relocation.Location = new System.Drawing.Point(205, 366);
            this.txt_relocation.Name = "txt_relocation";
            this.txt_relocation.Size = new System.Drawing.Size(184, 22);
            this.txt_relocation.TabIndex = 18;
            // 
            // txt_kmsUsed
            // 
            this.txt_kmsUsed.Location = new System.Drawing.Point(205, 420);
            this.txt_kmsUsed.Name = "txt_kmsUsed";
            this.txt_kmsUsed.Size = new System.Drawing.Size(184, 22);
            this.txt_kmsUsed.TabIndex = 19;
            // 
            // txt_relocationCost
            // 
            this.txt_relocationCost.Location = new System.Drawing.Point(205, 473);
            this.txt_relocationCost.Name = "txt_relocationCost";
            this.txt_relocationCost.Size = new System.Drawing.Size(184, 22);
            this.txt_relocationCost.TabIndex = 20;
            // 
            // btn_submitRelocationActivity
            // 
            this.btn_submitRelocationActivity.Location = new System.Drawing.Point(399, 536);
            this.btn_submitRelocationActivity.Name = "btn_submitRelocationActivity";
            this.btn_submitRelocationActivity.Size = new System.Drawing.Size(132, 47);
            this.btn_submitRelocationActivity.TabIndex = 21;
            this.btn_submitRelocationActivity.Text = "Submit";
            this.btn_submitRelocationActivity.UseVisualStyleBackColor = true;
            // 
            // Relocation_Activity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(566, 615);
            this.Controls.Add(this.btn_submitRelocationActivity);
            this.Controls.Add(this.txt_relocationCost);
            this.Controls.Add(this.txt_kmsUsed);
            this.Controls.Add(this.txt_relocation);
            this.Controls.Add(this.lbl_relocationCost);
            this.Controls.Add(this.lbl_kmsUsed);
            this.Controls.Add(this.lbl_relocation);
            this.Name = "Relocation_Activity_Form";
            this.Text = "Relocation Activity Form";
            this.Controls.SetChildIndex(this.lbl_relocation, 0);
            this.Controls.SetChildIndex(this.lbl_kmsUsed, 0);
            this.Controls.SetChildIndex(this.lbl_relocationCost, 0);
            this.Controls.SetChildIndex(this.txt_relocation, 0);
            this.Controls.SetChildIndex(this.txt_kmsUsed, 0);
            this.Controls.SetChildIndex(this.txt_relocationCost, 0);
            this.Controls.SetChildIndex(this.btn_submitRelocationActivity, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_relocation;
        private System.Windows.Forms.Label lbl_kmsUsed;
        private System.Windows.Forms.Label lbl_relocationCost;
        private System.Windows.Forms.TextBox txt_relocation;
        private System.Windows.Forms.TextBox txt_kmsUsed;
        private System.Windows.Forms.TextBox txt_relocationCost;
        private System.Windows.Forms.Button btn_submitRelocationActivity;
    }
}
