
namespace Warehouse
{
    partial class StartForm
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
            this.RadioButCustAvt = new System.Windows.Forms.RadioButton();
            this.RadioButSelderAvt = new System.Windows.Forms.RadioButton();
            this.ButtonRegistrate = new System.Windows.Forms.Button();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadioButCustAvt
            // 
            this.RadioButCustAvt.AutoSize = true;
            this.RadioButCustAvt.Location = new System.Drawing.Point(309, 37);
            this.RadioButCustAvt.Name = "RadioButCustAvt";
            this.RadioButCustAvt.Size = new System.Drawing.Size(108, 24);
            this.RadioButCustAvt.TabIndex = 1;
            this.RadioButCustAvt.Text = "Покупатель";
            this.RadioButCustAvt.UseVisualStyleBackColor = true;
            // 
            // RadioButSelderAvt
            // 
            this.RadioButSelderAvt.AutoSize = true;
            this.RadioButSelderAvt.Checked = true;
            this.RadioButSelderAvt.Location = new System.Drawing.Point(68, 37);
            this.RadioButSelderAvt.Name = "RadioButSelderAvt";
            this.RadioButSelderAvt.Size = new System.Drawing.Size(97, 24);
            this.RadioButSelderAvt.TabIndex = 0;
            this.RadioButSelderAvt.TabStop = true;
            this.RadioButSelderAvt.Text = "Продавец";
            this.RadioButSelderAvt.UseVisualStyleBackColor = true;
            // 
            // ButtonRegistrate
            // 
            this.ButtonRegistrate.Location = new System.Drawing.Point(101, 276);
            this.ButtonRegistrate.Name = "ButtonRegistrate";
            this.ButtonRegistrate.Size = new System.Drawing.Size(116, 28);
            this.ButtonRegistrate.TabIndex = 2;
            this.ButtonRegistrate.Text = "Регистрация";
            this.ButtonRegistrate.UseVisualStyleBackColor = true;
            this.ButtonRegistrate.Click += new System.EventHandler(this.ButtonRegistrate_Click);
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.Location = new System.Drawing.Point(352, 276);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(90, 28);
            this.ButtonLogIn.TabIndex = 3;
            this.ButtonLogIn.Text = "Вход";
            this.ButtonLogIn.UseVisualStyleBackColor = true;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(82, 129);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(244, 26);
            this.Login.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(82, 212);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(244, 26);
            this.Password.TabIndex = 5;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Логин (e-mail)";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(560, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.ButtonRegistrate);
            this.Controls.Add(this.RadioButSelderAvt);
            this.Controls.Add(this.RadioButCustAvt);
            this.Name = "StartForm";
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RadioButCustAvt;
        private System.Windows.Forms.RadioButton RadioButSelderAvt;
        private System.Windows.Forms.Button ButtonRegistrate;
        private System.Windows.Forms.Button ButtonLogIn;
        public System.Windows.Forms.TextBox Login;
        public System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}