
namespace SDV601_Project
{
    partial class Add_Activity_Form
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
            this.txt_activityId = new System.Windows.Forms.TextBox();
            this.txt_registrationNumberActivityForm = new System.Windows.Forms.TextBox();
            this.txt_activityName = new System.Windows.Forms.TextBox();
            this.lbl_activityId = new System.Windows.Forms.Label();
            this.lbl_registrationNumberActivityForm = new System.Windows.Forms.Label();
            this.lbl_activityName = new System.Windows.Forms.Label();
            this.lbl_activityDate = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.lbl_selectActivityType = new System.Windows.Forms.Label();
            this.rbtn_relocation = new System.Windows.Forms.RadioButton();
            this.rbtn_service = new System.Windows.Forms.RadioButton();
            this.rbtn_hiring = new System.Windows.Forms.RadioButton();
            this.dtp_activityDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_activityId
            // 
            this.txt_activityId.Location = new System.Drawing.Point(166, 28);
            this.txt_activityId.Name = "txt_activityId";
            this.txt_activityId.Size = new System.Drawing.Size(223, 22);
            this.txt_activityId.TabIndex = 0;
            // 
            // txt_registrationNumberActivityForm
            // 
            this.txt_registrationNumberActivityForm.Location = new System.Drawing.Point(211, 65);
            this.txt_registrationNumberActivityForm.Name = "txt_registrationNumberActivityForm";
            this.txt_registrationNumberActivityForm.Size = new System.Drawing.Size(178, 22);
            this.txt_registrationNumberActivityForm.TabIndex = 1;
            // 
            // txt_activityName
            // 
            this.txt_activityName.Location = new System.Drawing.Point(166, 100);
            this.txt_activityName.Name = "txt_activityName";
            this.txt_activityName.Size = new System.Drawing.Size(223, 22);
            this.txt_activityName.TabIndex = 2;
            // 
            // lbl_activityId
            // 
            this.lbl_activityId.AutoSize = true;
            this.lbl_activityId.Location = new System.Drawing.Point(67, 31);
            this.lbl_activityId.Name = "lbl_activityId";
            this.lbl_activityId.Size = new System.Drawing.Size(69, 17);
            this.lbl_activityId.TabIndex = 5;
            this.lbl_activityId.Text = "Activity ID";
            // 
            // lbl_registrationNumberActivityForm
            // 
            this.lbl_registrationNumberActivityForm.AutoSize = true;
            this.lbl_registrationNumberActivityForm.Location = new System.Drawing.Point(67, 65);
            this.lbl_registrationNumberActivityForm.Name = "lbl_registrationNumberActivityForm";
            this.lbl_registrationNumberActivityForm.Size = new System.Drawing.Size(138, 17);
            this.lbl_registrationNumberActivityForm.TabIndex = 6;
            this.lbl_registrationNumberActivityForm.Text = "Registration Number";
            // 
            // lbl_activityName
            // 
            this.lbl_activityName.AutoSize = true;
            this.lbl_activityName.Location = new System.Drawing.Point(67, 101);
            this.lbl_activityName.Name = "lbl_activityName";
            this.lbl_activityName.Size = new System.Drawing.Size(93, 17);
            this.lbl_activityName.TabIndex = 7;
            this.lbl_activityName.Text = "Activity Name";
            // 
            // lbl_activityDate
            // 
            this.lbl_activityDate.AutoSize = true;
            this.lbl_activityDate.Location = new System.Drawing.Point(67, 136);
            this.lbl_activityDate.Name = "lbl_activityDate";
            this.lbl_activityDate.Size = new System.Drawing.Size(86, 17);
            this.lbl_activityDate.TabIndex = 8;
            this.lbl_activityDate.Text = "Activity Date";
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(441, 269);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(103, 36);
            this.btn_continue.TabIndex = 13;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            // 
            // lbl_selectActivityType
            // 
            this.lbl_selectActivityType.AutoSize = true;
            this.lbl_selectActivityType.Location = new System.Drawing.Point(67, 170);
            this.lbl_selectActivityType.Name = "lbl_selectActivityType";
            this.lbl_selectActivityType.Size = new System.Drawing.Size(295, 17);
            this.lbl_selectActivityType.TabIndex = 12;
            this.lbl_selectActivityType.Text = "Please Select the type of activity being added";
            // 
            // rbtn_relocation
            // 
            this.rbtn_relocation.AutoSize = true;
            this.rbtn_relocation.Location = new System.Drawing.Point(67, 256);
            this.rbtn_relocation.Name = "rbtn_relocation";
            this.rbtn_relocation.Size = new System.Drawing.Size(96, 21);
            this.rbtn_relocation.TabIndex = 11;
            this.rbtn_relocation.TabStop = true;
            this.rbtn_relocation.Text = "Relocation";
            this.rbtn_relocation.UseVisualStyleBackColor = true;
            // 
            // rbtn_service
            // 
            this.rbtn_service.AutoSize = true;
            this.rbtn_service.Location = new System.Drawing.Point(67, 229);
            this.rbtn_service.Name = "rbtn_service";
            this.rbtn_service.Size = new System.Drawing.Size(76, 21);
            this.rbtn_service.TabIndex = 10;
            this.rbtn_service.TabStop = true;
            this.rbtn_service.Text = "Service";
            this.rbtn_service.UseVisualStyleBackColor = true;
            // 
            // rbtn_hiring
            // 
            this.rbtn_hiring.AutoSize = true;
            this.rbtn_hiring.Location = new System.Drawing.Point(67, 202);
            this.rbtn_hiring.Name = "rbtn_hiring";
            this.rbtn_hiring.Size = new System.Drawing.Size(66, 21);
            this.rbtn_hiring.TabIndex = 9;
            this.rbtn_hiring.TabStop = true;
            this.rbtn_hiring.Text = "Hiring";
            this.rbtn_hiring.UseVisualStyleBackColor = true;
            // 
            // dtp_activityDate
            // 
            this.dtp_activityDate.Location = new System.Drawing.Point(166, 136);
            this.dtp_activityDate.Name = "dtp_activityDate";
            this.dtp_activityDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_activityDate.TabIndex = 14;
            // 
            // Add_Activity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 320);
            this.Controls.Add(this.dtp_activityDate);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.lbl_selectActivityType);
            this.Controls.Add(this.rbtn_relocation);
            this.Controls.Add(this.rbtn_service);
            this.Controls.Add(this.rbtn_hiring);
            this.Controls.Add(this.lbl_activityDate);
            this.Controls.Add(this.lbl_activityName);
            this.Controls.Add(this.lbl_registrationNumberActivityForm);
            this.Controls.Add(this.lbl_activityId);
            this.Controls.Add(this.txt_activityName);
            this.Controls.Add(this.txt_registrationNumberActivityForm);
            this.Controls.Add(this.txt_activityId);
            this.Name = "Add_Activity_Form";
            this.Text = "Add Activity Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_activityId;
        private System.Windows.Forms.TextBox txt_registrationNumberActivityForm;
        private System.Windows.Forms.TextBox txt_activityName;
        private System.Windows.Forms.Label lbl_activityId;
        private System.Windows.Forms.Label lbl_registrationNumberActivityForm;
        private System.Windows.Forms.Label lbl_activityName;
        private System.Windows.Forms.Label lbl_activityDate;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label lbl_selectActivityType;
        private System.Windows.Forms.RadioButton rbtn_relocation;
        private System.Windows.Forms.RadioButton rbtn_service;
        private System.Windows.Forms.RadioButton rbtn_hiring;
        private System.Windows.Forms.DateTimePicker dtp_activityDate;
    }
}