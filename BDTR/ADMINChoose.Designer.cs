namespace BDTR
{
    partial class ADMINChoose
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
            this.CoachAddButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.delProg = new System.Windows.Forms.Button();
            this.Program_list = new System.Windows.Forms.ComboBox();
            this.InvBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientAddButton
            // 
            this.ClientAddButton.Location = new System.Drawing.Point(11, 6);
            this.ClientAddButton.Name = "ClientAddButton";
            this.ClientAddButton.Size = new System.Drawing.Size(169, 74);
            this.ClientAddButton.TabIndex = 0;
            this.ClientAddButton.Text = "Управление Клиентами";
            this.ClientAddButton.UseVisualStyleBackColor = true;
            this.ClientAddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CoachAddButton
            // 
            this.CoachAddButton.Location = new System.Drawing.Point(11, 86);
            this.CoachAddButton.Name = "CoachAddButton";
            this.CoachAddButton.Size = new System.Drawing.Size(169, 69);
            this.CoachAddButton.TabIndex = 1;
            this.CoachAddButton.Text = "Управление Тренерами";
            this.CoachAddButton.UseVisualStyleBackColor = true;
            this.CoachAddButton.Click += new System.EventHandler(this.CoachAddButton_Click);
            // 
            // OtherButton
            // 
            this.OtherButton.Location = new System.Drawing.Point(223, 217);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(109, 29);
            this.OtherButton.TabIndex = 2;
            this.OtherButton.Text = "Другое...";
            this.OtherButton.UseVisualStyleBackColor = true;
            this.OtherButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // delProg
            // 
            this.delProg.Location = new System.Drawing.Point(12, 298);
            this.delProg.Name = "delProg";
            this.delProg.Size = new System.Drawing.Size(168, 40);
            this.delProg.TabIndex = 3;
            this.delProg.Text = "Удалить программу";
            this.delProg.UseVisualStyleBackColor = true;
            this.delProg.Click += new System.EventHandler(this.delProg_Click);
            // 
            // Program_list
            // 
            this.Program_list.FormattingEnabled = true;
            this.Program_list.Location = new System.Drawing.Point(185, 307);
            this.Program_list.Name = "Program_list";
            this.Program_list.Size = new System.Drawing.Size(147, 24);
            this.Program_list.TabIndex = 4;
            // 
            // InvBut
            // 
            this.InvBut.Location = new System.Drawing.Point(12, 161);
            this.InvBut.Name = "InvBut";
            this.InvBut.Size = new System.Drawing.Size(163, 57);
            this.InvBut.TabIndex = 5;
            this.InvBut.Text = "Управление Инвентарем";
            this.InvBut.UseVisualStyleBackColor = true;
            this.InvBut.Click += new System.EventHandler(this.InvBut_Click);
            // 
            // ADMINChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 362);
            this.Controls.Add(this.InvBut);
            this.Controls.Add(this.Program_list);
            this.Controls.Add(this.delProg);
            this.Controls.Add(this.OtherButton);
            this.Controls.Add(this.CoachAddButton);
            this.Controls.Add(this.ClientAddButton);
            this.Name = "ADMINChoose";
            this.Text = "ADMINChoose";
            this.Load += new System.EventHandler(this.ADMINChoose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientAddButton;
        private System.Windows.Forms.Button CoachAddButton;
        private System.Windows.Forms.Button OtherButton;
        private System.Windows.Forms.Button delProg;
        private System.Windows.Forms.ComboBox Program_list;
        private System.Windows.Forms.Button InvBut;
    }
}