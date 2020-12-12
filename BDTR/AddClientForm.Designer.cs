namespace BDTR
{
    partial class AddClientForm
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
            this.AddLike_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PhNTBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContractAccept = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIOTBx = new System.Windows.Forms.TextBox();
            this.MainLike = new System.Windows.Forms.ComboBox();
            this.ExtraLike = new System.Windows.Forms.TextBox();
            this.Likelabel = new System.Windows.Forms.Label();
            this.ELikelabel = new System.Windows.Forms.Label();
            this.CLNTDEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddLike_Button
            // 
            this.AddLike_Button.Location = new System.Drawing.Point(511, 183);
            this.AddLike_Button.Name = "AddLike_Button";
            this.AddLike_Button.Size = new System.Drawing.Size(259, 52);
            this.AddLike_Button.TabIndex = 17;
            this.AddLike_Button.Text = "Добавить Предпочтение";
            this.AddLike_Button.UseVisualStyleBackColor = true;
            this.AddLike_Button.Click += new System.EventHandler(this.AddLike_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Номер телефона";
            // 
            // PhNTBx
            // 
            this.PhNTBx.Location = new System.Drawing.Point(182, 265);
            this.PhNTBx.Name = "PhNTBx";
            this.PhNTBx.Size = new System.Drawing.Size(165, 22);
            this.PhNTBx.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ФИО Клиента";
            // 
            // ContractAccept
            // 
            this.ContractAccept.Location = new System.Drawing.Point(511, 241);
            this.ContractAccept.Name = "ContractAccept";
            this.ContractAccept.Size = new System.Drawing.Size(259, 112);
            this.ContractAccept.TabIndex = 11;
            this.ContractAccept.Text = "Добавить клиента";
            this.ContractAccept.UseVisualStyleBackColor = true;
            this.ContractAccept.Click += new System.EventHandler(this.ContractAccept_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // FIOTBx
            // 
            this.FIOTBx.Location = new System.Drawing.Point(182, 206);
            this.FIOTBx.Name = "FIOTBx";
            this.FIOTBx.Size = new System.Drawing.Size(165, 22);
            this.FIOTBx.TabIndex = 18;
            // 
            // MainLike
            // 
            this.MainLike.FormattingEnabled = true;
            this.MainLike.Location = new System.Drawing.Point(182, 308);
            this.MainLike.Name = "MainLike";
            this.MainLike.Size = new System.Drawing.Size(165, 24);
            this.MainLike.TabIndex = 19;
            // 
            // ExtraLike
            // 
            this.ExtraLike.Location = new System.Drawing.Point(182, 353);
            this.ExtraLike.Name = "ExtraLike";
            this.ExtraLike.Size = new System.Drawing.Size(165, 22);
            this.ExtraLike.TabIndex = 20;
            // 
            // Likelabel
            // 
            this.Likelabel.AutoSize = true;
            this.Likelabel.Location = new System.Drawing.Point(3, 311);
            this.Likelabel.Name = "Likelabel";
            this.Likelabel.Size = new System.Drawing.Size(174, 17);
            this.Likelabel.TabIndex = 21;
            this.Likelabel.Text = "Основное Предпочтение";
            // 
            // ELikelabel
            // 
            this.ELikelabel.AutoSize = true;
            this.ELikelabel.Location = new System.Drawing.Point(49, 350);
            this.ELikelabel.Name = "ELikelabel";
            this.ELikelabel.Size = new System.Drawing.Size(127, 34);
            this.ELikelabel.TabIndex = 22;
            this.ELikelabel.Text = "Дополнительные \r\nпредпочтения\r\n";
            this.ELikelabel.Click += new System.EventHandler(this.ELikelabel_Click);
            // 
            // CLNTDEL
            // 
            this.CLNTDEL.Location = new System.Drawing.Point(513, 381);
            this.CLNTDEL.Name = "CLNTDEL";
            this.CLNTDEL.Size = new System.Drawing.Size(256, 53);
            this.CLNTDEL.TabIndex = 23;
            this.CLNTDEL.Text = "Удалить Клиента";
            this.CLNTDEL.UseVisualStyleBackColor = true;
            this.CLNTDEL.Click += new System.EventHandler(this.CLNTDEL_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CLNTDEL);
            this.Controls.Add(this.ELikelabel);
            this.Controls.Add(this.Likelabel);
            this.Controls.Add(this.ExtraLike);
            this.Controls.Add(this.MainLike);
            this.Controls.Add(this.FIOTBx);
            this.Controls.Add(this.AddLike_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhNTBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContractAccept);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLike_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhNTBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContractAccept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FIOTBx;
        private System.Windows.Forms.ComboBox MainLike;
        private System.Windows.Forms.TextBox ExtraLike;
        private System.Windows.Forms.Label Likelabel;
        private System.Windows.Forms.Label ELikelabel;
        private System.Windows.Forms.Button CLNTDEL;
    }
}