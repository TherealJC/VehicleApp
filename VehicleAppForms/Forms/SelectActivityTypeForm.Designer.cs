
namespace VehicleAppForms
{
    partial class SelectActivityType
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
            this.Lbl_FormExplanation = new System.Windows.Forms.Label();
            this.Rbtn_Hiring = new System.Windows.Forms.RadioButton();
            this.Rbtn_Service = new System.Windows.Forms.RadioButton();
            this.Rbtn_Relocation = new System.Windows.Forms.RadioButton();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_FormExplanation
            // 
            this.Lbl_FormExplanation.AutoSize = true;
            this.Lbl_FormExplanation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FormExplanation.Location = new System.Drawing.Point(9, 9);
            this.Lbl_FormExplanation.Name = "Lbl_FormExplanation";
            this.Lbl_FormExplanation.Size = new System.Drawing.Size(425, 23);
            this.Lbl_FormExplanation.TabIndex = 0;
            this.Lbl_FormExplanation.Text = "Please select the Activity Type that you want to create";
            // 
            // Rbtn_Hiring
            // 
            this.Rbtn_Hiring.AutoSize = true;
            this.Rbtn_Hiring.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Hiring.Location = new System.Drawing.Point(48, 52);
            this.Rbtn_Hiring.Name = "Rbtn_Hiring";
            this.Rbtn_Hiring.Size = new System.Drawing.Size(86, 29);
            this.Rbtn_Hiring.TabIndex = 1;
            this.Rbtn_Hiring.TabStop = true;
            this.Rbtn_Hiring.Text = "Hiring";
            this.Rbtn_Hiring.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Service
            // 
            this.Rbtn_Service.AutoSize = true;
            this.Rbtn_Service.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Service.Location = new System.Drawing.Point(163, 52);
            this.Rbtn_Service.Name = "Rbtn_Service";
            this.Rbtn_Service.Size = new System.Drawing.Size(94, 29);
            this.Rbtn_Service.TabIndex = 2;
            this.Rbtn_Service.TabStop = true;
            this.Rbtn_Service.Text = "Service";
            this.Rbtn_Service.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Relocation
            // 
            this.Rbtn_Relocation.AutoSize = true;
            this.Rbtn_Relocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Relocation.Location = new System.Drawing.Point(281, 52);
            this.Rbtn_Relocation.Name = "Rbtn_Relocation";
            this.Rbtn_Relocation.Size = new System.Drawing.Size(125, 29);
            this.Rbtn_Relocation.TabIndex = 3;
            this.Rbtn_Relocation.TabStop = true;
            this.Rbtn_Relocation.Text = "Relocation";
            this.Rbtn_Relocation.UseVisualStyleBackColor = true;
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Continue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Continue.Location = new System.Drawing.Point(303, 103);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(131, 42);
            this.Btn_Continue.TabIndex = 4;
            this.Btn_Continue.Text = "Continue";
            this.Btn_Continue.UseVisualStyleBackColor = false;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // SelectActivityType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 162);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.Rbtn_Relocation);
            this.Controls.Add(this.Rbtn_Service);
            this.Controls.Add(this.Rbtn_Hiring);
            this.Controls.Add(this.Lbl_FormExplanation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SelectActivityType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Activity Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_FormExplanation;
        private System.Windows.Forms.RadioButton Rbtn_Hiring;
        private System.Windows.Forms.RadioButton Rbtn_Service;
        private System.Windows.Forms.RadioButton Rbtn_Relocation;
        private System.Windows.Forms.Button Btn_Continue;
    }
}