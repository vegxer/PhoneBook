
namespace Lab3
{
    partial class SearchPhoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPhoneForm));
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(125, 12);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(197, 26);
            this.maskedTextBoxPhone.TabIndex = 0;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(10, 15);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(86, 20);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(12, 137);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResults.Size = new System.Drawing.Size(308, 206);
            this.textBoxResults.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(125, 61);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 40);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // SearchPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchPhoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск абонента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button buttonSearch;
    }
}