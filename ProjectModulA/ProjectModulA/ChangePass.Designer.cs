namespace ProjectModulA
{
    partial class ChangePass
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
            this.ChengePassButton = new System.Windows.Forms.Button();
            this.oldPasswordFild = new System.Windows.Forms.TextBox();
            this.newPasswordFild = new System.Windows.Forms.TextBox();
            this.LoginFild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChengePassButton
            // 
            this.ChengePassButton.Location = new System.Drawing.Point(368, 254);
            this.ChengePassButton.Name = "ChengePassButton";
            this.ChengePassButton.Size = new System.Drawing.Size(125, 39);
            this.ChengePassButton.TabIndex = 0;
            this.ChengePassButton.Text = "Принять";
            this.ChengePassButton.UseVisualStyleBackColor = true;
            this.ChengePassButton.Click += new System.EventHandler(this.ChengePassButton_Click);
            // 
            // oldPasswordFild
            // 
            this.oldPasswordFild.Location = new System.Drawing.Point(323, 150);
            this.oldPasswordFild.Name = "oldPasswordFild";
            this.oldPasswordFild.Size = new System.Drawing.Size(226, 20);
            this.oldPasswordFild.TabIndex = 1;
            // 
            // newPasswordFild
            // 
            this.newPasswordFild.Location = new System.Drawing.Point(325, 204);
            this.newPasswordFild.Name = "newPasswordFild";
            this.newPasswordFild.Size = new System.Drawing.Size(224, 20);
            this.newPasswordFild.TabIndex = 2;
            // 
            // LoginFild
            // 
            this.LoginFild.Location = new System.Drawing.Point(325, 100);
            this.LoginFild.Name = "LoginFild";
            this.LoginFild.Size = new System.Drawing.Size(226, 20);
            this.LoginFild.TabIndex = 3;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginFild);
            this.Controls.Add(this.newPasswordFild);
            this.Controls.Add(this.oldPasswordFild);
            this.Controls.Add(this.ChengePassButton);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChengePassButton;
        private System.Windows.Forms.TextBox oldPasswordFild;
        private System.Windows.Forms.TextBox newPasswordFild;
        private System.Windows.Forms.TextBox LoginFild;
    }
}