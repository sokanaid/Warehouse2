
namespace Warehouse
{
    partial class AddCategoryForm
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.LableSortCode = new System.Windows.Forms.Label();
            this.NumericUpDownSortCode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSortCode)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(45, 69);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(272, 26);
            this.TextBox1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(76, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(213, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Введите название категории:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(199, 157);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 28);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(62, 157);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(90, 28);
            this.CancelButton1.TabIndex = 3;
            this.CancelButton1.Text = "Отмена";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LableSortCode
            // 
            this.LableSortCode.AutoSize = true;
            this.LableSortCode.Location = new System.Drawing.Point(45, 121);
            this.LableSortCode.Name = "LableSortCode";
            this.LableSortCode.Size = new System.Drawing.Size(121, 20);
            this.LableSortCode.TabIndex = 4;
            this.LableSortCode.Text = "Код сортировки";
            // 
            // NumericUpDownSortCode
            // 
            this.NumericUpDownSortCode.Location = new System.Drawing.Point(213, 119);
            this.NumericUpDownSortCode.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericUpDownSortCode.Name = "NumericUpDownSortCode";
            this.NumericUpDownSortCode.Size = new System.Drawing.Size(120, 26);
            this.NumericUpDownSortCode.TabIndex = 5;
            // 
            // AddCategoryForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(383, 197);
            this.Controls.Add(this.NumericUpDownSortCode);
            this.Controls.Add(this.LableSortCode);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCategoryForm";
            this.Text = "Добавление категории";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSortCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextBox1;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.Button CancelButton1;
        public System.Windows.Forms.Label LableSortCode;
        public System.Windows.Forms.NumericUpDown NumericUpDownSortCode;
    }
}