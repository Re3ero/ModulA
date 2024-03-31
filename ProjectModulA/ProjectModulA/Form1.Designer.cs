namespace ProjectModulA
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.loginFild = new System.Windows.Forms.TextBox();
            this.passwordFild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(161, 294);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(135, 43);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Вход";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // loginFild
            // 
            this.loginFild.Location = new System.Drawing.Point(130, 172);
            this.loginFild.Name = "loginFild";
            this.loginFild.Size = new System.Drawing.Size(196, 20);
            this.loginFild.TabIndex = 1;
            // 
            // passwordFild
            // 
            this.passwordFild.Location = new System.Drawing.Point(130, 230);
            this.passwordFild.Name = "passwordFild";
            this.passwordFild.Size = new System.Drawing.Size(195, 20);
            this.passwordFild.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 493);
            this.Controls.Add(this.passwordFild);
            this.Controls.Add(this.loginFild);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox loginFild;
        private System.Windows.Forms.TextBox passwordFild;
    }
}

