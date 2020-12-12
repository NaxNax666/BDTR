namespace BDTR
{
    partial class ClientChoose
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
            this.CheckProgramButton = new System.Windows.Forms.Button();
            this.NewProgramButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckProgramButton
            // 
            this.CheckProgramButton.Location = new System.Drawing.Point(200, 116);
            this.CheckProgramButton.Name = "CheckProgramButton";
            this.CheckProgramButton.Size = new System.Drawing.Size(492, 38);
            this.CheckProgramButton.TabIndex = 1;
            this.CheckProgramButton.Text = "Просмотреть свои программы";
            this.CheckProgramButton.UseVisualStyleBackColor = true;
            this.CheckProgramButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewProgramButton
            // 
            this.NewProgramButton.Location = new System.Drawing.Point(218, 39);
            this.NewProgramButton.Name = "NewProgramButton";
            this.NewProgramButton.Size = new System.Drawing.Size(455, 61);
            this.NewProgramButton.TabIndex = 2;
            this.NewProgramButton.Text = "Запись на новую программу";
            this.NewProgramButton.UseVisualStyleBackColor = true;
            this.NewProgramButton.Click += new System.EventHandler(this.NewProgramButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 196);
            this.dataGridView1.TabIndex = 3;
            // 
            // ClientChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 404);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewProgramButton);
            this.Controls.Add(this.CheckProgramButton);
            this.Controls.Add(this.label1);
            this.Name = "ClientChoose";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ClientChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckProgramButton;
        private System.Windows.Forms.Button NewProgramButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}