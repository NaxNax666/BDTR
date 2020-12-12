namespace BDTR
{
    partial class InvForm
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
            this.DataView = new System.Windows.Forms.DataGridView();
            this.AddInvButt = new System.Windows.Forms.Button();
            this.AddinvProg = new System.Windows.Forms.Button();
            this.WrtFFInv = new System.Windows.Forms.Button();
            this.NewInvName = new System.Windows.Forms.TextBox();
            this.Program_list = new System.Windows.Forms.ComboBox();
            this.Inv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bdate = new System.Windows.Forms.DateTimePicker();
            this.CostBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 12);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(761, 187);
            this.DataView.TabIndex = 0;
            // 
            // AddInvButt
            // 
            this.AddInvButt.Location = new System.Drawing.Point(56, 383);
            this.AddInvButt.Name = "AddInvButt";
            this.AddInvButt.Size = new System.Drawing.Size(185, 36);
            this.AddInvButt.TabIndex = 1;
            this.AddInvButt.Text = "Добавить Инвентарь";
            this.AddInvButt.UseVisualStyleBackColor = true;
            this.AddInvButt.Click += new System.EventHandler(this.AddInvButt_Click);
            // 
            // AddinvProg
            // 
            this.AddinvProg.Location = new System.Drawing.Point(368, 373);
            this.AddinvProg.Name = "AddinvProg";
            this.AddinvProg.Size = new System.Drawing.Size(185, 57);
            this.AddinvProg.TabIndex = 2;
            this.AddinvProg.Text = "Добавить инвентарь в программу";
            this.AddinvProg.UseVisualStyleBackColor = true;
            this.AddinvProg.Click += new System.EventHandler(this.AddinvProg_Click);
            // 
            // WrtFFInv
            // 
            this.WrtFFInv.Location = new System.Drawing.Point(570, 373);
            this.WrtFFInv.Name = "WrtFFInv";
            this.WrtFFInv.Size = new System.Drawing.Size(185, 57);
            this.WrtFFInv.TabIndex = 3;
            this.WrtFFInv.Text = "Списать Инвентарь";
            this.WrtFFInv.UseVisualStyleBackColor = true;
            this.WrtFFInv.Click += new System.EventHandler(this.WrtFFInv_Click);
            // 
            // NewInvName
            // 
            this.NewInvName.Location = new System.Drawing.Point(45, 234);
            this.NewInvName.Name = "NewInvName";
            this.NewInvName.Size = new System.Drawing.Size(185, 22);
            this.NewInvName.TabIndex = 4;
            // 
            // Program_list
            // 
            this.Program_list.FormattingEnabled = true;
            this.Program_list.Location = new System.Drawing.Point(287, 291);
            this.Program_list.Name = "Program_list";
            this.Program_list.Size = new System.Drawing.Size(185, 24);
            this.Program_list.TabIndex = 7;
            // 
            // Inv
            // 
            this.Inv.FormattingEnabled = true;
            this.Inv.Location = new System.Drawing.Point(464, 234);
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(185, 24);
            this.Inv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название инвентаря";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Целевая Программа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата приобретения";
            // 
            // Bdate
            // 
            this.Bdate.CustomFormat = "yyyy-MM-dd";
            this.Bdate.Location = new System.Drawing.Point(45, 346);
            this.Bdate.Name = "Bdate";
            this.Bdate.Size = new System.Drawing.Size(185, 22);
            this.Bdate.TabIndex = 14;
            this.Bdate.Value = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(45, 316);
            this.CostBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(185, 22);
            this.CostBox.TabIndex = 15;
            // 
            // InvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.Bdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inv);
            this.Controls.Add(this.Program_list);
            this.Controls.Add(this.NewInvName);
            this.Controls.Add(this.WrtFFInv);
            this.Controls.Add(this.AddinvProg);
            this.Controls.Add(this.AddInvButt);
            this.Controls.Add(this.DataView);
            this.Name = "InvForm";
            this.Text = "InvForm";
            this.Load += new System.EventHandler(this.InvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button AddInvButt;
        private System.Windows.Forms.Button AddinvProg;
        private System.Windows.Forms.Button WrtFFInv;
        private System.Windows.Forms.TextBox NewInvName;
        private System.Windows.Forms.ComboBox Program_list;
        private System.Windows.Forms.ComboBox Inv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Bdate;
        private System.Windows.Forms.NumericUpDown CostBox;
    }
}