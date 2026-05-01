using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class RegisterForm : Form
    {
        List<Person> personList;

        private static readonly string[] MaritalStatusArray = { "Solteiro(a)", "Casado(a)", "Separado(a)", "Viuvo(a)" };

        private int selectedPersonIndex;
        private bool isUpdatingPersonRegister;

        public RegisterForm()
        {
            InitializeComponent();

            personList = new List<Person>();

            foreach(string status in MaritalStatusArray)
            {
                comboBoxMaritalStatus.Items.Add(status);
            }

            comboBoxMaritalStatus.SelectedIndex = 0;

            SetFormToDefault();
        }

        private void SetFormToDefault()
        {
            btnRegister.Text = "Registrar";
            listBox.Enabled = true;
            isUpdatingPersonRegister = false;
            selectedPersonIndex = -1;

            DisableDeleteButton();
        }

        private void EnableDeleteButton()
        {
            btnDelete.Enabled = true;
        }

        private void DisableDeleteButton()
        {
            btnDelete.Enabled = false;
        }

        private void ListItems()
        {
            listBox.Items.Clear();

            foreach (Person person in personList)
            {
                listBox.Items.Add(person.Name);
            }
        }

        private void FillFormWithPersonSelectedData()
        {
            Person person = personList[listBox.SelectedIndex];

            txtBoxName.Text = person.Name;
            datePickerBirthDate.Text = person.BirthDate;
            comboBoxMaritalStatus.SelectedItem = person.MaritalStatus;
            mskTxtBoxTelephone.Text = person.Telephone;
            chkBoxOwnHome.Checked = person.IsOwnHome;
            chkBoxOwnVehicle.Checked = person.IsOwnVehicle;

            switch (person.Sex)
            {
                case 'M':
                    radioBtnMasculine.Checked = true;
                    break;
                case 'F':
                    radioBtnFemale.Checked = true;
                    break;
                case 'O':
                    radioBtnOther.Checked = true;
                    break;
            }
        }

        private Person GetPersonRegister()
        {
            char sexo;

            // Determine the gender based on the selected radio button
            if (radioBtnMasculine.Checked)
            {
                sexo = 'M';
            }
            else if (radioBtnFemale.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Person person = new Person();

            person.Name = txtBoxName.Text;
            person.BirthDate = datePickerBirthDate.Text;
            person.MaritalStatus = comboBoxMaritalStatus.SelectedItem.ToString();
            person.Telephone = mskTxtBoxTelephone.Text;
            person.IsOwnHome = chkBoxOwnHome.Checked;
            person.IsOwnVehicle = chkBoxOwnVehicle.Checked;
            person.Sex = sexo;

            return person;
        }

        #region Event Handlers
        private void btnRegister_Click(object sender, EventArgs e)
        {    
            if (txtBoxName.Text == "")
            {
                MessageBox.Show("O campo nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Person person = GetPersonRegister();

            // Verify if the user is updating an existing person or creating a new one
            if (isUpdatingPersonRegister)
            {
                personList[selectedPersonIndex] = person;
            }else
            {
                personList.Add(person);
            }

            ListItems();
            SetFormToDefault();

            btnClean_Click(btnClean, EventArgs.Empty);            
        }

        // Clean the form fields
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            mskTxtBoxTelephone.Text = "";
            datePickerBirthDate.Value = DateTime.Now;
            comboBoxMaritalStatus.SelectedItem = MaritalStatusArray[0];

            // Set the chekboxes to false
            chkBoxOwnHome.Checked = false;
            chkBoxOwnVehicle.Checked = false;

            // Set the default gender
            radioBtnMasculine.Checked = true;
            radioBtnFemale.Checked = false;
            radioBtnOther.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if(index >= 0 && index < personList.Count)
            {
                personList.RemoveAt(index);
                ListItems();
                SetFormToDefault();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDeleteButton();
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnRegister.Text = "Atualizar";
            listBox.Enabled = false;

            selectedPersonIndex = listBox.SelectedIndex;
            isUpdatingPersonRegister = true;

            FillFormWithPersonSelectedData();
        }
        #endregion
    }
}
