namespace BDTR
{
    partial class OtherForm
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
            this.Showdata = new System.Windows.Forms.DataGridView();
            this.ClientCheck = new System.Windows.Forms.Button();
            this.showProgram = new System.Windows.Forms.Button();
            this.Coachshow = new System.Windows.Forms.Button();
            this.Invbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Showdata)).BeginInit();
            this.SuspendLayout();
            // 
            // Showdata
            // 
            this.Showdata.AllowUserToAddRows = false;
            this.Showdata.AllowUserToDeleteRows = false;
            this.Showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Showdata.Location = new System.Drawing.Point(32, 12);
            this.Showdata.Name = "Showdata";
            this.Showdata.ReadOnly = true;
            this.Showdata.RowHeadersWidth = 51;
            this.Showdata.RowTemplate.Height = 24;
            this.Showdata.Size = new System.Drawing.Size(542, 408);
            this.Showdata.TabIndex = 0;
            // 
            // ClientCheck
            // 
            this.ClientCheck.AutoEllipsis = true;
            this.ClientCheck.Location = new System.Drawing.Point(597, 12);
            this.ClientCheck.Name = "ClientCheck";
            this.ClientCheck.Size = new System.Drawing.Size(191, 79);
            this.ClientCheck.TabIndex = 1;
            this.ClientCheck.Text = "Показать всех клиентов";
            this.ClientCheck.UseVisualStyleBackColor = true;
            this.ClientCheck.Click += new System.EventHandler(this.ClientCheck_Click);
            // 
            // showProgram
            // 
            this.showProgram.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.showProgram.Location = new System.Drawing.Point(597, 120);
            this.showProgram.Name = "showProgram";
            this.showProgram.Size = new System.Drawing.Size(191, 73);
            this.showProgram.TabIndex = 2;
            this.showProgram.Text = "Показать все Программы";
            this.showProgram.UseVisualStyleBackColor = true;
            this.showProgram.Click += new System.EventHandler(this.showProgram_Click);
            // 
            // Coachshow
            // 
            this.Coachshow.Location = new System.Drawing.Point(597, 235);
            this.Coachshow.Name = "Coachshow";
            this.Coachshow.Size = new System.Drawing.Size(191, 73);
            this.Coachshow.TabIndex = 3;
            this.Coachshow.Text = "Показать всех тренеров";
            this.Coachshow.UseVisualStyleBackColor = true;
            this.Coachshow.Click += new System.EventHandler(this.Coachshow_Click);
            // 
            // Invbutton
            // 
            this.Invbutton.Location = new System.Drawing.Point(597, 327);
            this.Invbutton.Name = "Invbutton";
            this.Invbutton.Size = new System.Drawing.Size(191, 56);
            this.Invbutton.TabIndex = 4;
            this.Invbutton.Text = "Показать инвентарь";
            this.Invbutton.UseVisualStyleBackColor = true;
            this.Invbutton.Click += new System.EventHandler(this.Invbutton_Click);
            // 
            // OtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Invbutton);
            this.Controls.Add(this.Coachshow);
            this.Controls.Add(this.showProgram);
            this.Controls.Add(this.ClientCheck);
            this.Controls.Add(this.Showdata);
            this.Name = "OtherForm";
            this.Text = "OtherForm";
            this.Load += new System.EventHandler(this.OtherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Showdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Showdata;
        private System.Windows.Forms.Button ClientCheck;
        private System.Windows.Forms.Button showProgram;
        private System.Windows.Forms.Button Coachshow;
        private System.Windows.Forms.Button Invbutton;
    }
}