
namespace DAT601_Project
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
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.editVehicleBtn = new System.Windows.Forms.Button();
            this.removeVehicleBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Location = new System.Drawing.Point(56, 46);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(145, 45);
            this.addVehicleBtn.TabIndex = 0;
            this.addVehicleBtn.Text = "Add Vehicle";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // editVehicleBtn
            // 
            this.editVehicleBtn.Location = new System.Drawing.Point(56, 97);
            this.editVehicleBtn.Name = "editVehicleBtn";
            this.editVehicleBtn.Size = new System.Drawing.Size(145, 45);
            this.editVehicleBtn.TabIndex = 1;
            this.editVehicleBtn.Text = "Edit Vehicle";
            this.editVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // removeVehicleBtn
            // 
            this.removeVehicleBtn.Location = new System.Drawing.Point(56, 148);
            this.removeVehicleBtn.Name = "removeVehicleBtn";
            this.removeVehicleBtn.Size = new System.Drawing.Size(145, 45);
            this.removeVehicleBtn.TabIndex = 2;
            this.removeVehicleBtn.Text = "Remove Vehicle";
            this.removeVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(244, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.removeVehicleBtn);
            this.Controls.Add(this.editVehicleBtn);
            this.Controls.Add(this.addVehicleBtn);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Button editVehicleBtn;
        private System.Windows.Forms.Button removeVehicleBtn;
        private System.Windows.Forms.ListView listView1;
    }
}