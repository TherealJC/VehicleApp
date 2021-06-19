
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_hiring = new System.Windows.Forms.RadioButton();
            this.rbtn_service = new System.Windows.Forms.RadioButton();
            this.rbtn_relocation = new System.Windows.Forms.RadioButton();
            this.btn_continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the Activity Type that you want to create";
            // 
            // rbtn_hiring
            // 
            this.rbtn_hiring.AutoSize = true;
            this.rbtn_hiring.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_hiring.Location = new System.Drawing.Point(48, 52);
            this.rbtn_hiring.Name = "rbtn_hiring";
            this.rbtn_hiring.Size = new System.Drawing.Size(86, 29);
            this.rbtn_hiring.TabIndex = 1;
            this.rbtn_hiring.TabStop = true;
            this.rbtn_hiring.Text = "Hiring";
            this.rbtn_hiring.UseVisualStyleBackColor = true;
            // 
            // rbtn_service
            // 
            this.rbtn_service.AutoSize = true;
            this.rbtn_service.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_service.Location = new System.Drawing.Point(163, 52);
            this.rbtn_service.Name = "rbtn_service";
            this.rbtn_service.Size = new System.Drawing.Size(94, 29);
            this.rbtn_service.TabIndex = 2;
            this.rbtn_service.TabStop = true;
            this.rbtn_service.Text = "Service";
            this.rbtn_service.UseVisualStyleBackColor = true;
            // 
            // rbtn_relocation
            // 
            this.rbtn_relocation.AutoSize = true;
            this.rbtn_relocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_relocation.Location = new System.Drawing.Point(281, 52);
            this.rbtn_relocation.Name = "rbtn_relocation";
            this.rbtn_relocation.Size = new System.Drawing.Size(125, 29);
            this.rbtn_relocation.TabIndex = 3;
            this.rbtn_relocation.TabStop = true;
            this.rbtn_relocation.Text = "Relocation";
            this.rbtn_relocation.UseVisualStyleBackColor = true;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_continue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.Location = new System.Drawing.Point(303, 103);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(131, 42);
            this.btn_continue.TabIndex = 4;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // SelectActivityType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 162);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.rbtn_relocation);
            this.Controls.Add(this.rbtn_service);
            this.Controls.Add(this.rbtn_hiring);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SelectActivityType";
            this.Text = "Select Activity Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_hiring;
        private System.Windows.Forms.RadioButton rbtn_service;
        private System.Windows.Forms.RadioButton rbtn_relocation;
        private System.Windows.Forms.Button btn_continue;
    }
}