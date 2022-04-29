
namespace testSustem
{
    partial class menuAdmin
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
            this.button2 = new System.Windows.Forms.Button();
            this.loginFieldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактирование базы данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginFieldLabel
            // 
            this.loginFieldLabel.AutoSize = true;
            this.loginFieldLabel.Location = new System.Drawing.Point(364, 42);
            this.loginFieldLabel.Name = "loginFieldLabel";
            this.loginFieldLabel.Size = new System.Drawing.Size(54, 17);
            this.loginFieldLabel.TabIndex = 16;
            this.loginFieldLabel.Text = "label11";
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginFieldLabel);
            this.Controls.Add(this.button2);
            this.Name = "menuAdmin";
            this.Text = "menuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label loginFieldLabel;
    }
}