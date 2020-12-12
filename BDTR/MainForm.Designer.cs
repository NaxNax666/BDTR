namespace BDTR
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CoachLoginButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.ClientLoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.fitClub_primaryDataSet = new BDTR.FitClub_primaryDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new BDTR.FitClub_primaryDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fitClub_primaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 138);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро Пожаловать\r\nв фитнес-клуб JOJOfit\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CoachLoginButton
            // 
            this.CoachLoginButton.Location = new System.Drawing.Point(145, 368);
            this.CoachLoginButton.Name = "CoachLoginButton";
            this.CoachLoginButton.Size = new System.Drawing.Size(153, 37);
            this.CoachLoginButton.TabIndex = 1;
            this.CoachLoginButton.Text = "Тренер";
            this.CoachLoginButton.UseVisualStyleBackColor = true;
            this.CoachLoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(304, 368);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(153, 37);
            this.AdminButton.TabIndex = 2;
            this.AdminButton.Text = "Администратор";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientLoginButton
            // 
            this.ClientLoginButton.Location = new System.Drawing.Point(463, 368);
            this.ClientLoginButton.Name = "ClientLoginButton";
            this.ClientLoginButton.Size = new System.Drawing.Size(153, 37);
            this.ClientLoginButton.TabIndex = 3;
            this.ClientLoginButton.Text = "Клиент";
            this.ClientLoginButton.UseVisualStyleBackColor = true;
            this.ClientLoginButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(304, 244);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(209, 22);
            this.LoginField.TabIndex = 6;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(304, 283);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(209, 22);
            this.PasswordField.TabIndex = 7;
            // 
            // fitClub_primaryDataSet
            // 
            this.fitClub_primaryDataSet.DataSetName = "FitClub_primaryDataSet";
            this.fitClub_primaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.fitClub_primaryDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientLoginButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.CoachLoginButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitClub_primaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CoachLoginButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button ClientLoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PasswordField;
        private FitClub_primaryDataSet fitClub_primaryDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private FitClub_primaryDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}

