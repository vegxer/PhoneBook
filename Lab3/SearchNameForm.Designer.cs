
namespace Lab3
{
    partial class SearchNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchNameForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(121, 54);
            this.textBoxName.MaxLength = 25;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(121, 99);
            this.textBoxPatronymic.MaxLength = 25;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(197, 26);
            this.textBoxPatronymic.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(121, 12);
            this.textBoxSurname.MaxLength = 25;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(197, 26);
            this.textBoxSurname.TabIndex = 0;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(6, 102);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(91, 20);
            this.labelPatronymic.TabIndex = 8;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(6, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(6, 15);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(88, 20);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Фамилия";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(130, 144);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 40);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(10, 193);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResults.Size = new System.Drawing.Size(308, 206);
            this.textBoxResults.TabIndex = 4;
            // 
            // SearchNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск абонента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxResults;
    }
}