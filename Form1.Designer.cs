
namespace RegForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.middlenameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.datebirthField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phonefield = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.RegistrationClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 475);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.labelName.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(38, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(143, 22);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Введите ваше имя";
            this.labelName.UseMnemonic = false;
            // 
            // middlenameField
            // 
            this.middlenameField.Location = new System.Drawing.Point(25, 156);
            this.middlenameField.Multiline = true;
            this.middlenameField.Name = "middlenameField";
            this.middlenameField.Size = new System.Drawing.Size(222, 32);
            this.middlenameField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите ваше отчество";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(25, 91);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(222, 32);
            this.NameField.TabIndex = 3;
            // 
            // datebirthField
            // 
            this.datebirthField.Location = new System.Drawing.Point(25, 283);
            this.datebirthField.Multiline = true;
            this.datebirthField.Name = "datebirthField";
            this.datebirthField.Size = new System.Drawing.Size(222, 32);
            this.datebirthField.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введите дату рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Введите вашу фамилию";
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(25, 221);
            this.surnameField.Multiline = true;
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(222, 32);
            this.surnameField.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Введите номер телефона";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // phonefield
            // 
            this.phonefield.Location = new System.Drawing.Point(25, 348);
            this.phonefield.Multiline = true;
            this.phonefield.Name = "phonefield";
            this.phonefield.Size = new System.Drawing.Size(222, 34);
            this.phonefield.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(38, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Введите электронную почту";
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(25, 421);
            this.emailField.Multiline = true;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(222, 33);
            this.emailField.TabIndex = 7;
            // 
            // RegistrationClick
            // 
            this.RegistrationClick.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrationClick.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationClick.Location = new System.Drawing.Point(496, 275);
            this.RegistrationClick.Name = "RegistrationClick";
            this.RegistrationClick.Size = new System.Drawing.Size(237, 33);
            this.RegistrationClick.TabIndex = 8;
            this.RegistrationClick.Text = "Зарегистрироваться";
            this.RegistrationClick.UseVisualStyleBackColor = false;
            this.RegistrationClick.Click += new System.EventHandler(this.RegistrationClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 477);
            this.Controls.Add(this.RegistrationClick);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phonefield);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.datebirthField);
            this.Controls.Add(this.middlenameField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox middlenameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox datebirthField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phonefield;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Button RegistrationClick;
    }
}

