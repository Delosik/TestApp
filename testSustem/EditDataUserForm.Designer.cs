
namespace testSustem
{
    partial class EditDataUserForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.fullNameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.password2Field = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль еще раз:";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(246, 130);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(329, 22);
            this.loginField.TabIndex = 4;
            // 
            // fullNameField
            // 
            this.fullNameField.Location = new System.Drawing.Point(246, 174);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(329, 22);
            this.fullNameField.TabIndex = 5;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(246, 217);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(329, 22);
            this.passwordField.TabIndex = 6;
            // 
            // password2Field
            // 
            this.password2Field.Location = new System.Drawing.Point(246, 254);
            this.password2Field.Name = "password2Field";
            this.password2Field.Size = new System.Drawing.Size(329, 22);
            this.password2Field.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Изменить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditDataUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password2Field);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.fullNameField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditDataUserForm";
            this.Text = "EditDataUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox fullNameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox password2Field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}