namespace SistemaCadastro
{
    partial class RegisterForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirthData = new System.Windows.Forms.Label();
            this.labelMaritalStatus = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.datePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.mskTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.chkBoxOwnHome = new System.Windows.Forms.CheckBox();
            this.chkBoxOwnVehicle = new System.Windows.Forms.CheckBox();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.radioBtnOther = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculine = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome";
            // 
            // labelBirthData
            // 
            this.labelBirthData.AutoSize = true;
            this.labelBirthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthData.Location = new System.Drawing.Point(12, 64);
            this.labelBirthData.Name = "labelBirthData";
            this.labelBirthData.Size = new System.Drawing.Size(206, 25);
            this.labelBirthData.TabIndex = 1;
            this.labelBirthData.Text = "Data de Nascimento";
            // 
            // labelMaritalStatus
            // 
            this.labelMaritalStatus.AutoSize = true;
            this.labelMaritalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaritalStatus.Location = new System.Drawing.Point(12, 110);
            this.labelMaritalStatus.Name = "labelMaritalStatus";
            this.labelMaritalStatus.Size = new System.Drawing.Size(126, 25);
            this.labelMaritalStatus.TabIndex = 2;
            this.labelMaritalStatus.Text = "Estado Civil";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephone.Location = new System.Drawing.Point(12, 156);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(96, 25);
            this.labelTelephone.TabIndex = 3;
            this.labelTelephone.Text = "Telefone";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(263, 15);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(416, 31);
            this.txtBoxName.TabIndex = 4;
            // 
            // datePickerBirthDate
            // 
            this.datePickerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerBirthDate.Location = new System.Drawing.Point(263, 61);
            this.datePickerBirthDate.Name = "datePickerBirthDate";
            this.datePickerBirthDate.Size = new System.Drawing.Size(416, 31);
            this.datePickerBirthDate.TabIndex = 5;
            // 
            // comboBoxMaritalStatus
            // 
            this.comboBoxMaritalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaritalStatus.FormattingEnabled = true;
            this.comboBoxMaritalStatus.Location = new System.Drawing.Point(263, 107);
            this.comboBoxMaritalStatus.Name = "comboBoxMaritalStatus";
            this.comboBoxMaritalStatus.Size = new System.Drawing.Size(416, 33);
            this.comboBoxMaritalStatus.TabIndex = 6;
            // 
            // mskTxtBoxTelephone
            // 
            this.mskTxtBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelephone.Location = new System.Drawing.Point(263, 155);
            this.mskTxtBoxTelephone.Mask = "(00) 00000-0000";
            this.mskTxtBoxTelephone.Name = "mskTxtBoxTelephone";
            this.mskTxtBoxTelephone.Size = new System.Drawing.Size(416, 31);
            this.mskTxtBoxTelephone.TabIndex = 7;
            // 
            // chkBoxOwnHome
            // 
            this.chkBoxOwnHome.AutoSize = true;
            this.chkBoxOwnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxOwnHome.Location = new System.Drawing.Point(263, 223);
            this.chkBoxOwnHome.Name = "chkBoxOwnHome";
            this.chkBoxOwnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBoxOwnHome.Size = new System.Drawing.Size(124, 17);
            this.chkBoxOwnHome.TabIndex = 8;
            this.chkBoxOwnHome.Text = "Possui casa própria?";
            this.chkBoxOwnHome.UseVisualStyleBackColor = true;
            // 
            // chkBoxOwnVehicle
            // 
            this.chkBoxOwnVehicle.AutoSize = true;
            this.chkBoxOwnVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxOwnVehicle.Location = new System.Drawing.Point(263, 255);
            this.chkBoxOwnVehicle.Name = "chkBoxOwnVehicle";
            this.chkBoxOwnVehicle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBoxOwnVehicle.Size = new System.Drawing.Size(137, 17);
            this.chkBoxOwnVehicle.TabIndex = 9;
            this.chkBoxOwnVehicle.Text = "Possui veículo próprio?";
            this.chkBoxOwnVehicle.UseVisualStyleBackColor = true;
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioBtnOther);
            this.groupBoxSex.Controls.Add(this.radioBtnFemale);
            this.groupBoxSex.Controls.Add(this.radioBtnMasculine);
            this.groupBoxSex.Location = new System.Drawing.Point(263, 299);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(313, 115);
            this.groupBoxSex.TabIndex = 10;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Sexo";
            // 
            // radioBtnOther
            // 
            this.radioBtnOther.AutoSize = true;
            this.radioBtnOther.Location = new System.Drawing.Point(6, 85);
            this.radioBtnOther.Name = "radioBtnOther";
            this.radioBtnOther.Size = new System.Drawing.Size(51, 17);
            this.radioBtnOther.TabIndex = 2;
            this.radioBtnOther.TabStop = true;
            this.radioBtnOther.Text = "Outro";
            this.radioBtnOther.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(6, 52);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(67, 17);
            this.radioBtnFemale.TabIndex = 1;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Feminino";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculine
            // 
            this.radioBtnMasculine.AutoSize = true;
            this.radioBtnMasculine.Checked = true;
            this.radioBtnMasculine.Location = new System.Drawing.Point(6, 19);
            this.radioBtnMasculine.Name = "radioBtnMasculine";
            this.radioBtnMasculine.Size = new System.Drawing.Size(73, 17);
            this.radioBtnMasculine.TabIndex = 0;
            this.radioBtnMasculine.TabStop = true;
            this.radioBtnMasculine.Text = "Masculino";
            this.radioBtnMasculine.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(17, 467);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(173, 52);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(436, 467);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(173, 52);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 52);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(17, 537);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(771, 79);
            this.listBox.TabIndex = 14;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.chkBoxOwnVehicle);
            this.Controls.Add(this.chkBoxOwnHome);
            this.Controls.Add(this.mskTxtBoxTelephone);
            this.Controls.Add(this.comboBoxMaritalStatus);
            this.Controls.Add(this.datePickerBirthDate);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelMaritalStatus);
            this.Controls.Add(this.labelBirthData);
            this.Controls.Add(this.labelName);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirthData;
        private System.Windows.Forms.Label labelMaritalStatus;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.DateTimePicker datePickerBirthDate;
        private System.Windows.Forms.ComboBox comboBoxMaritalStatus;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelephone;
        private System.Windows.Forms.CheckBox chkBoxOwnHome;
        private System.Windows.Forms.CheckBox chkBoxOwnVehicle;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton radioBtnMasculine;
        private System.Windows.Forms.RadioButton radioBtnOther;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBox;
    }
}

