
namespace Lab3
{
    partial class SearchAdressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAdressForm));
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelFlat = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.numericUpDownFlat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBuilding = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(12, 193);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResults.Size = new System.Drawing.Size(308, 206);
            this.textBoxResults.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(132, 144);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 40);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(123, 12);
            this.textBoxStreet.MaxLength = 25;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(197, 26);
            this.textBoxStreet.TabIndex = 0;
            // 
            // labelFlat
            // 
            this.labelFlat.AutoSize = true;
            this.labelFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFlat.Location = new System.Drawing.Point(8, 102);
            this.labelFlat.Name = "labelFlat";
            this.labelFlat.Size = new System.Drawing.Size(90, 20);
            this.labelFlat.TabIndex = 16;
            this.labelFlat.Text = "Квартира";
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuilding.Location = new System.Drawing.Point(8, 57);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(44, 20);
            this.labelBuilding.TabIndex = 15;
            this.labelBuilding.Text = "Дом";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStreet.Location = new System.Drawing.Point(8, 15);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(61, 20);
            this.labelStreet.TabIndex = 14;
            this.labelStreet.Text = "Улица";
            // 
            // numericUpDownFlat
            // 
            this.numericUpDownFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownFlat.Location = new System.Drawing.Point(123, 100);
            this.numericUpDownFlat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownFlat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFlat.Name = "numericUpDownFlat";
            this.numericUpDownFlat.Size = new System.Drawing.Size(197, 26);
            this.numericUpDownFlat.TabIndex = 2;
            this.numericUpDownFlat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBuilding
            // 
            this.numericUpDownBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownBuilding.Location = new System.Drawing.Point(123, 55);
            this.numericUpDownBuilding.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownBuilding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBuilding.Name = "numericUpDownBuilding";
            this.numericUpDownBuilding.Size = new System.Drawing.Size(197, 26);
            this.numericUpDownBuilding.TabIndex = 1;
            this.numericUpDownBuilding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SearchAdressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.numericUpDownFlat);
            this.Controls.Add(this.numericUpDownBuilding);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.labelFlat);
            this.Controls.Add(this.labelBuilding);
            this.Controls.Add(this.labelStreet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchAdressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск абонента";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelFlat;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.NumericUpDown numericUpDownFlat;
        private System.Windows.Forms.NumericUpDown numericUpDownBuilding;
    }
}