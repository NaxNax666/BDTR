namespace BDTR
{
    partial class Contractfrom
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataIn = new System.Windows.Forms.Button();
            this.ContractAccept = new System.Windows.Forms.Button();
            this.Program_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Offer_Button = new System.Windows.Forms.Button();
            this.fitClub_primaryDataSet = new BDTR.FitClub_primaryDataSet();
            this.programlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.program_listTableAdapter = new BDTR.FitClub_primaryDataSetTableAdapters.Program_listTableAdapter();
            this.programlistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClub_primaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programlistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataIn
            // 
            this.DataIn.Location = new System.Drawing.Point(511, 209);
            this.DataIn.Name = "DataIn";
            this.DataIn.Size = new System.Drawing.Size(259, 67);
            this.DataIn.TabIndex = 1;
            this.DataIn.Text = "Ввести данные";
            this.DataIn.UseVisualStyleBackColor = true;
            this.DataIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContractAccept
            // 
            this.ContractAccept.Location = new System.Drawing.Point(511, 360);
            this.ContractAccept.Name = "ContractAccept";
            this.ContractAccept.Size = new System.Drawing.Size(259, 67);
            this.ContractAccept.TabIndex = 2;
            this.ContractAccept.Text = "Заключить контракт";
            this.ContractAccept.UseVisualStyleBackColor = true;
            this.ContractAccept.Click += new System.EventHandler(this.button2_Click);
            // 
            // Program_list
            // 
            this.Program_list.FormattingEnabled = true;
            this.Program_list.Location = new System.Drawing.Point(155, 192);
            this.Program_list.Name = "Program_list";
            this.Program_list.Size = new System.Drawing.Size(165, 24);
            this.Program_list.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Программа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Срок прогрммы";
            // 
            // Offer_Button
            // 
            this.Offer_Button.Location = new System.Drawing.Point(511, 282);
            this.Offer_Button.Name = "Offer_Button";
            this.Offer_Button.Size = new System.Drawing.Size(259, 72);
            this.Offer_Button.TabIndex = 8;
            this.Offer_Button.Text = "Подобрать по предпочтениям";
            this.Offer_Button.UseVisualStyleBackColor = true;
            this.Offer_Button.Click += new System.EventHandler(this.Offer_Button_Click);
            // 
            // fitClub_primaryDataSet
            // 
            this.fitClub_primaryDataSet.DataSetName = "FitClub_primaryDataSet";
            this.fitClub_primaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programlistBindingSource
            // 
            this.programlistBindingSource.DataMember = "Program_list";
            this.programlistBindingSource.DataSource = this.fitClub_primaryDataSet;
            // 
            // program_listTableAdapter
            // 
            this.program_listTableAdapter.ClearBeforeFill = true;
            // 
            // programlistBindingSource1
            // 
            this.programlistBindingSource1.DataMember = "Program_list";
            this.programlistBindingSource1.DataSource = this.fitClub_primaryDataSet;
            // 
            // Contractfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Offer_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Program_list);
            this.Controls.Add(this.ContractAccept);
            this.Controls.Add(this.DataIn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Contractfrom";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Contractfrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClub_primaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programlistBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DataIn;
        private System.Windows.Forms.Button ContractAccept;
        private System.Windows.Forms.ComboBox Program_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Offer_Button;
        private FitClub_primaryDataSet fitClub_primaryDataSet;
        private System.Windows.Forms.BindingSource programlistBindingSource;
        private FitClub_primaryDataSetTableAdapters.Program_listTableAdapter program_listTableAdapter;
        private System.Windows.Forms.BindingSource programlistBindingSource1;
    }
}