using System;
using System.Linq;
using System.Windows.Forms;
using Windows_Forms_Application.Properties;

namespace Windows_Forms_Application {
    public partial class EditPersonData : Form {
        private ListView.ListViewItemCollection _allItems;
        private ListViewItem _recievedItem;
        
        public EditPersonData(ListViewItem selected_item, ListView.ListViewItemCollection allEntries) {
            InitializeComponent();

            pictureBox1.Image = Convert.ToBoolean(selected_item.SubItems[2].Tag) ? Resources.male : Resources.female;
            textBox_id.Text = selected_item.Text;
            textBox_fullName.Text = selected_item.SubItems[1].Text;
            if (Convert.ToBoolean(selected_item.SubItems[2].Tag)) radioButton_male.Checked = true;
            else radioButton_female.Checked = true;
            dateTimePicker_dateOfBirth.Value = (DateTime) selected_item.SubItems[3].Tag;
            textBox_phoneNumber.Text = selected_item.SubItems[4].Text;
            comboBox_maritalStatus.SelectedIndex = Convert.ToInt32(selected_item.SubItems[5].Tag);

            _recievedItem = selected_item;
            _allItems = allEntries;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_id.Text) || !Business_Logic.CheckNationalIDNumber(textBox_id.Text, radioButton_male.Checked)) {
                MessageBox.Show("Invalid national ID number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem i in _allItems) {
                if (i.Text == textBox_id.Text) {
                    MessageBox.Show("National ID number already exists.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(textBox_fullName.Text)) {
                MessageBox.Show("Invalid name.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if ((textBox_id.Text[12] - 48) % 2 == 0 ? radioButton_male.Checked : radioButton_female.Checked) {
                MessageBox.Show("The gender is not compatible with the national ID number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Business_Logic.CheckDateOfBirthWithID(dateTimePicker_dateOfBirth.Value, textBox_id.Text)) {
                MessageBox.Show("The date of birth is not compatible with the national ID number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox_phoneNumber.Text.Length != 16 || !(new string[] { "010", "011", "012", "015" }).Contains(textBox_phoneNumber.Text.Substring(3, 3))) {
                MessageBox.Show("Invalid phone number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte age = (byte) (DateTime.Today.Year - ((textBox_id.Text[0] - 48 == 1 ? 1900 : 2000) + Convert.ToInt32(textBox_id.Text.Substring(1, 2))));
            if (comboBox_maritalStatus.SelectedIndex > 0 && (radioButton_male.Checked ? age < 15 : age < 12)) {
                MessageBox.Show("Invalid marital status.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _recievedItem.Text = textBox_id.Text;
            _recievedItem.SubItems[1].Text = textBox_fullName.Text.Trim();

            _recievedItem.SubItems[2].Text = radioButton_male.Checked ? "Male" : "Female";
            _recievedItem.SubItems[2].Tag = radioButton_male.Checked;

            _recievedItem.SubItems[3].Text = dateTimePicker_dateOfBirth.Value.ToString("d");
            _recievedItem.SubItems[3].Tag = dateTimePicker_dateOfBirth.Value;

            _recievedItem.SubItems[4].Text = textBox_phoneNumber.Text;

            _recievedItem.SubItems[5].Text = comboBox_maritalStatus.SelectedItem.ToString();
            _recievedItem.SubItems[5].Tag = comboBox_maritalStatus.SelectedIndex;

            _recievedItem.SubItems[7].Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            _recievedItem.ImageIndex = radioButton_male.Checked ? 1 : 0;
            
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
