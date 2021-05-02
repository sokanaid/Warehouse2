
namespace Warehouse
{
    partial class AddGoodForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.CanscelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.NumericUpDown();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CanscelButton
            // 
            this.CanscelButton.Location = new System.Drawing.Point(72, 345);
            this.CanscelButton.Name = "CanscelButton";
            this.CanscelButton.Size = new System.Drawing.Size(90, 28);
            this.CanscelButton.TabIndex = 1;
            this.CanscelButton.Text = "Отмена";
            this.CanscelButton.UseVisualStyleBackColor = true;
            this.CanscelButton.Click += new System.EventHandler(this.CanscelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Артикул:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Остаток:";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(164, 232);
            this.CountTextBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(144, 26);
            this.CountTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(154, 161);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(120, 26);
            this.PriceTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(190, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 26);
            this.NameTextBox.TabIndex = 8;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(154, 95);
            this.CodeTextBox.Mask = "00-0000-00";
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(120, 26);
            this.CodeTextBox.TabIndex = 10;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(366, 91);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(144, 109);
            this.checkedListBox1.TabIndex = 11;
            // 
            // AddGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(359, 392);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CanscelButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGoodForm";
            this.Text = "Добавление товара:";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CountTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CanscelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.MaskedTextBox CodeTextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}