
namespace Warehouse
{
    partial class CreateWarehouse
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
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSortCode)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(199, 158);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(61, 158);
            // 
            // NumericUpDownSortCode
            // 
            this.NumericUpDownSortCode.Visible = false;
            // 
            // LableSortCode
            // 
            this.LableSortCode.Visible = false;
            // 
            // CreateWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 231);
            this.Name = "CreateWarehouse";
            this.Text = "Создание склада";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSortCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}