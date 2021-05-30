
namespace Lab3
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDownFlat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBuilding = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFlat = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(125, 281);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(197, 26);
            this.maskedTextBoxPhone.TabIndex = 6;
            // 
            // numericUpDownFlat
            // 
            this.numericUpDownFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownFlat.Location = new System.Drawing.Point(125, 237);
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
            this.numericUpDownFlat.TabIndex = 5;
            this.numericUpDownFlat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBuilding
            // 
            this.numericUpDownBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownBuilding.Location = new System.Drawing.Point(125, 190);
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
            this.numericUpDownBuilding.TabIndex = 4;
            this.numericUpDownBuilding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(125, 54);
            this.textBoxName.MaxLength = 25;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(125, 141);
            this.textBoxStreet.MaxLength = 40;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(197, 26);
            this.textBoxStreet.TabIndex = 3;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(125, 99);
            this.textBoxPatronymic.MaxLength = 25;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(197, 26);
            this.textBoxPatronymic.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(125, 12);
            this.textBoxSurname.MaxLength = 25;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(197, 26);
            this.textBoxSurname.TabIndex = 0;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(10, 284);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(86, 20);
            this.labelPhone.TabIndex = 22;
            this.labelPhone.Text = "Телефон";
            // 
            // labelFlat
            // 
            this.labelFlat.AutoSize = true;
            this.labelFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFlat.Location = new System.Drawing.Point(10, 239);
            this.labelFlat.Name = "labelFlat";
            this.labelFlat.Size = new System.Drawing.Size(90, 20);
            this.labelFlat.TabIndex = 21;
            this.labelFlat.Text = "Квартира";
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuilding.Location = new System.Drawing.Point(10, 192);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(44, 20);
            this.labelBuilding.TabIndex = 20;
            this.labelBuilding.Text = "Дом";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStreet.Location = new System.Drawing.Point(10, 144);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(61, 20);
            this.labelStreet.TabIndex = 19;
            this.labelStreet.Text = "Улица";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(10, 102);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(91, 20);
            this.labelPatronymic.TabIndex = 18;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(10, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 20);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(10, 15);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(88, 20);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Фамилия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(115, 332);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 391);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.numericUpDownFlat);
            this.Controls.Add(this.numericUpDownBuilding);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelFlat);
            this.Controls.Add(this.labelBuilding);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление абонента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.NumericUpDown numericUpDownFlat;
        private System.Windows.Forms.NumericUpDown numericUpDownBuilding;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFlat;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonAdd;
    }
}