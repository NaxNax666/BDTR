namespace BDTR
{
    partial class CoachForm
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
            this.ClientAddButton = new System.Windows.Forms.Button();
            this.Other_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientAddButton
            // 
            this.ClientAddButton.Location = new System.Drawing.Point(75, 47);
            this.ClientAddButton.Name = "ClientAddButton";
            this.ClientAddButton.Size = new System.Drawing.Size(191, 37);
            this.ClientAddButton.TabIndex = 0;
            this.ClientAddButton.Text = "Добавить Клиента";
            this.ClientAddButton.UseVisualStyleBackColor = true;
            this.ClientAddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Other_Button
            // 
            this.Other_Button.Location = new System.Drawing.Point(234, 106);
            this.Other_Button.Name = "Other_Button";
            this.Other_Button.Size = new System.Drawing.Size(83, 30);
            this.Other_Button.TabIndex = 1;
            this.Other_Button.Text = "Другое...";
            this.Other_Button.UseVisualStyleBackColor = true;
            this.Other_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // CoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 148);
            this.Controls.Add(this.Other_Button);
            this.Controls.Add(this.ClientAddButton);
            this.Name = "CoachForm";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientAddButton;
        private System.Windows.Forms.Button Other_Button;
    }
}