namespace BDTR
{
    partial class AddCoachForm
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
            this.ELikelabel = new System.Windows.Forms.Label();
            this.PstnBx = new System.Windows.Forms.TextBox();
            this.FIOTBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SLTBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkCoach = new System.Windows.Forms.Button();
            this.FireCoach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Program_list = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ELikelabel
            // 
            this.ELikelabel.AutoSize = true;
            this.ELikelabel.Location = new System.Drawing.Point(56, 295);
            this.ELikelabel.Name = "ELikelabel";
            this.ELikelabel.Size = new System.Drawing.Size(0, 17);
            this.ELikelabel.TabIndex = 34;
            // 
            // PstnBx
            // 
            this.PstnBx.Location = new System.Drawing.Point(122, 144);
            this.PstnBx.Name = "PstnBx";
            this.PstnBx.Size = new System.Drawing.Size(165, 22);
            this.PstnBx.TabIndex = 32;
            // 
            // FIOTBx
            // 
            this.FIOTBx.Location = new System.Drawing.Point(122, 39);
            this.FIOTBx.Name = "FIOTBx";
            this.FIOTBx.Size = new System.Drawing.Size(165, 22);
            this.FIOTBx.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ставка";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SLTBx
            // 
            this.SLTBx.Location = new System.Drawing.Point(122, 98);
            this.SLTBx.Name = "SLTBx";
            this.SLTBx.Size = new System.Drawing.Size(165, 22);
            this.SLTBx.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "ФИО Тренера";
            // 
            // WorkCoach
            // 
            this.WorkCoach.Location = new System.Drawing.Point(337, 30);
            this.WorkCoach.Name = "WorkCoach";
            this.WorkCoach.Size = new System.Drawing.Size(259, 76);
            this.WorkCoach.TabIndex = 24;
            this.WorkCoach.Text = "Нанять тренера";
            this.WorkCoach.UseVisualStyleBackColor = true;
            this.WorkCoach.Click += new System.EventHandler(this.WorkCoach_Click);
            // 
            // FireCoach
            // 
            this.FireCoach.Location = new System.Drawing.Point(337, 133);
            this.FireCoach.Name = "FireCoach";
            this.FireCoach.Size = new System.Drawing.Size(259, 64);
            this.FireCoach.TabIndex = 35;
            this.FireCoach.Text = "Уволить тренера";
            this.FireCoach.UseVisualStyleBackColor = true;
            this.FireCoach.Click += new System.EventHandler(this.FireCoach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Программа";
            // 
            // Program_list
            // 
            this.Program_list.FormattingEnabled = true;
            this.Program_list.Location = new System.Drawing.Point(122, 190);
            this.Program_list.Name = "Program_list";
            this.Program_list.Size = new System.Drawing.Size(165, 24);
            this.Program_list.TabIndex = 37;
            this.Program_list.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 240);
            this.Controls.Add(this.Program_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FireCoach);
            this.Controls.Add(this.ELikelabel);
            this.Controls.Add(this.PstnBx);
            this.Controls.Add(this.FIOTBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SLTBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkCoach);
            this.Name = "AddCoachForm";
            this.Text = "AddCoachForm";
            this.Load += new System.EventHandler(this.AddCoachForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ELikelabel;
        private System.Windows.Forms.TextBox PstnBx;
        private System.Windows.Forms.TextBox FIOTBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SLTBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WorkCoach;
        private System.Windows.Forms.Button FireCoach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Program_list;
    }
}