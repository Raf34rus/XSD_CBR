namespace XSD_CBR
{
    partial class fEdit
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRefEDDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEDTypeNo = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerEDDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownEDNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEDAuthor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRepeatReceptInqCode = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownARMNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRefEDNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRefEDAuthor = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEDNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEDAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatReceptInqCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownARMNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefEDNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefEDAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(255, 417);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер ЭС в течение опердня.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата составления ЭС.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Уникальный идентификатор составителя ЭС - УИС.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип запроса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Тип ЭС";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Номер АРМ.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownRefEDAuthor);
            this.groupBox1.Controls.Add(this.numericUpDownRefEDNo);
            this.groupBox1.Controls.Add(this.dateTimePickerRefEDDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(17, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Идентификаторы ЭC.";
            // 
            // dateTimePickerRefEDDate
            // 
            this.dateTimePickerRefEDDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerRefEDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRefEDDate.Location = new System.Drawing.Point(9, 71);
            this.dateTimePickerRefEDDate.Name = "dateTimePickerRefEDDate";
            this.dateTimePickerRefEDDate.Size = new System.Drawing.Size(373, 20);
            this.dateTimePickerRefEDDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Уникальный идентификатор составителя ЭС - УИС.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Дата составления ЭС.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Номер ЭС в течение опердня.";
            // 
            // textBoxEDTypeNo
            // 
            this.textBoxEDTypeNo.Enabled = false;
            this.textBoxEDTypeNo.Location = new System.Drawing.Point(17, 199);
            this.textBoxEDTypeNo.Name = "textBoxEDTypeNo";
            this.textBoxEDTypeNo.Size = new System.Drawing.Size(384, 20);
            this.textBoxEDTypeNo.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(336, 417);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEDDate
            // 
            this.dateTimePickerEDDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEDDate.Location = new System.Drawing.Point(17, 82);
            this.dateTimePickerEDDate.Name = "dateTimePickerEDDate";
            this.dateTimePickerEDDate.Size = new System.Drawing.Size(385, 20);
            this.dateTimePickerEDDate.TabIndex = 15;
            // 
            // numericUpDownEDNo
            // 
            this.numericUpDownEDNo.Location = new System.Drawing.Point(17, 43);
            this.numericUpDownEDNo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownEDNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEDNo.Name = "numericUpDownEDNo";
            this.numericUpDownEDNo.Size = new System.Drawing.Size(384, 20);
            this.numericUpDownEDNo.TabIndex = 16;
            this.numericUpDownEDNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownEDAuthor
            // 
            this.numericUpDownEDAuthor.Location = new System.Drawing.Point(16, 121);
            this.numericUpDownEDAuthor.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownEDAuthor.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownEDAuthor.Name = "numericUpDownEDAuthor";
            this.numericUpDownEDAuthor.Size = new System.Drawing.Size(384, 20);
            this.numericUpDownEDAuthor.TabIndex = 17;
            this.numericUpDownEDAuthor.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // numericUpDownRepeatReceptInqCode
            // 
            this.numericUpDownRepeatReceptInqCode.Location = new System.Drawing.Point(17, 160);
            this.numericUpDownRepeatReceptInqCode.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownRepeatReceptInqCode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRepeatReceptInqCode.Name = "numericUpDownRepeatReceptInqCode";
            this.numericUpDownRepeatReceptInqCode.Size = new System.Drawing.Size(384, 20);
            this.numericUpDownRepeatReceptInqCode.TabIndex = 18;
            this.numericUpDownRepeatReceptInqCode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownARMNo
            // 
            this.numericUpDownARMNo.Location = new System.Drawing.Point(17, 238);
            this.numericUpDownARMNo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownARMNo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownARMNo.Name = "numericUpDownARMNo";
            this.numericUpDownARMNo.Size = new System.Drawing.Size(384, 20);
            this.numericUpDownARMNo.TabIndex = 19;
            this.numericUpDownARMNo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownRefEDNo
            // 
            this.numericUpDownRefEDNo.Location = new System.Drawing.Point(9, 32);
            this.numericUpDownRefEDNo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownRefEDNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRefEDNo.Name = "numericUpDownRefEDNo";
            this.numericUpDownRefEDNo.Size = new System.Drawing.Size(374, 20);
            this.numericUpDownRefEDNo.TabIndex = 18;
            this.numericUpDownRefEDNo.Value = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            // 
            // numericUpDownRefEDAuthor
            // 
            this.numericUpDownRefEDAuthor.Location = new System.Drawing.Point(9, 110);
            this.numericUpDownRefEDAuthor.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownRefEDAuthor.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownRefEDAuthor.Name = "numericUpDownRefEDAuthor";
            this.numericUpDownRefEDAuthor.Size = new System.Drawing.Size(374, 20);
            this.numericUpDownRefEDAuthor.TabIndex = 19;
            this.numericUpDownRefEDAuthor.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // fEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 448);
            this.Controls.Add(this.numericUpDownARMNo);
            this.Controls.Add(this.numericUpDownRepeatReceptInqCode);
            this.Controls.Add(this.numericUpDownEDAuthor);
            this.Controls.Add(this.numericUpDownEDNo);
            this.Controls.Add(this.dateTimePickerEDDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxEDTypeNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Name = "fEdit";
            this.Text = "Реквизиты ЭС";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEDNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEDAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatReceptInqCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownARMNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefEDNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefEDAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEDTypeNo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerRefEDDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEDDate;
        private System.Windows.Forms.NumericUpDown numericUpDownEDNo;
        private System.Windows.Forms.NumericUpDown numericUpDownEDAuthor;
        private System.Windows.Forms.NumericUpDown numericUpDownRefEDAuthor;
        private System.Windows.Forms.NumericUpDown numericUpDownRefEDNo;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeatReceptInqCode;
        private System.Windows.Forms.NumericUpDown numericUpDownARMNo;
    }
}