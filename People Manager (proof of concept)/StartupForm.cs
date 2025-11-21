using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Windows_Forms_Application {
    public partial class StartupForm : Form {
        private List<ListViewItem> _allItems = new List<ListViewItem>();

        public StartupForm() {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e) {
            lbl_currentDateTime.Text = DateTime.Now.ToString("F");
            dateTimePicker_dateOfBirth.MaxDate = DateTime.Today;
            comboBox_maritalStatus.SelectedIndex = 0;
        }

        private void textBox_Digits_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lbl_currentDateTime.Text = DateTime.Now.ToString("F");
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_id.Text) || !Business_Logic.CheckNationalIDNumber(textBox_id.Text, radioButton_male.Checked)) {
                MessageBox.Show("Invalid national ID number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem i in listView1.Items) {
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

            if (textBox_phoneNumber.Text.Length != 16 || !(new string[] {"010", "011", "012", "015"}).Contains(textBox_phoneNumber.Text.Substring(3, 3))) {
                MessageBox.Show("Invalid phone number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte age = (byte) (DateTime.Today.Year - ((textBox_id.Text[0] - 48 == 1 ? 1900 : 2000) + Convert.ToInt32(textBox_id.Text.Substring(1, 2))));
            if (comboBox_maritalStatus.SelectedIndex > 0 && (radioButton_male.Checked ? age < 15 : age < 12)) {
                MessageBox.Show("Invalid marital status.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(textBox_id.Text);

            item.SubItems.Add(textBox_fullName.Text.Trim());
            
            item.SubItems.Add(radioButton_male.Checked ? "Male" : "Female");
            item.SubItems[2].Tag = radioButton_male.Checked;

            item.SubItems.Add(dateTimePicker_dateOfBirth.Value.ToString("d"));
            item.SubItems[3].Tag = dateTimePicker_dateOfBirth.Value;

            item.SubItems.Add(textBox_phoneNumber.Text);

            item.SubItems.Add(comboBox_maritalStatus.SelectedItem.ToString());
            item.SubItems[5].Tag = comboBox_maritalStatus.SelectedIndex;

            string time_now_formatted = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            item.SubItems.Add(time_now_formatted);
            item.SubItems.Add(time_now_formatted);
            item.ImageIndex = radioButton_male.Checked ? 1 : 0;
            
            if (btn_showAll.Checked || btn_showMalesOnly.Checked == radioButton_male.Checked)
                listView1.Items.Add(item);

            _allItems.Add(item);

            ResetControls();
        }

        private void ResetControls() {
            textBox_id.Clear();
            textBox_fullName.Clear();
            radioButton_male.Checked = true;
            dateTimePicker_dateOfBirth.Value = new DateTime(2006, 1, 1);
            textBox_phoneNumber.Clear();
            comboBox_maritalStatus.SelectedIndex = 0;
        }

        private void radioButton_ListViewStyle_CheckedChanged(object sender, EventArgs e) {
            if (((RadioButton) sender).Checked)
                listView1.View = (View) Convert.ToByte(((RadioButton) sender).Tag);
        }

        private void btn_edit_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count != 1) {
                MessageBox.Show("You must select only one entry to edit.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selected_item = listView1.SelectedItems[0];
            Form _editEntryForm = new EditPersonData(selected_item, listView1.Items);

            if (_editEntryForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Entry successfully modified.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void op1ToolStripMenuItem_Click(object sender, EventArgs e) {
            btn_add_Click(btn_add, e);
        }

        private void op3ToolStripMenuItem_Click(object sender, EventArgs e) {
            btn_edit_Click(btn_edit, e);
        }

        private void btn_delete_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("You must select at least one entry to delete.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string promptMessage = "Are you sure you want to delete the selected ";

            if (listView1.SelectedItems.Count == 1)
                promptMessage += "entry?";
            else
                promptMessage += $"{listView1.SelectedItems.Count} entries?";

            if (MessageBox.Show(promptMessage, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                if (listView1.SelectedItems.Count == 1)
                    promptMessage = "1 entry successfully deleted.";
                else
                    promptMessage = $"{listView1.SelectedItems.Count} entries successfully deleted.";

                foreach (ListViewItem item in listView1.SelectedItems) {
                    listView1.Items.Remove(item);
                    _allItems.Remove(item);
                }

                MessageBox.Show(promptMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void deleteSelectedRowsToolStripMenuItem_Click(object sender, EventArgs e) {
            btn_delete_Click(btn_delete, e);
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e) {
            if (listView1.Items.Count == 0) {
                MessageBox.Show("No entries available.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete all entries?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                string promptMessage;

                if (listView1.Items.Count == 1)
                    promptMessage = "Successfully deleted 1 entry.";
                else
                    promptMessage = $"Successfully deleted {listView1.Items.Count} entries.";

                listView1.Items.Clear();

                MessageBox.Show(promptMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in listView1.Items)
                item.Selected = true;
        }

        private void selectNoneToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in listView1.Items)
                item.Selected = false;
        }

        private void reverseSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in listView1.Items)
                item.Selected = !item.Selected;
        }

        private void btn_showMalesOnly_Click(object sender, EventArgs e) {
            if (!btn_showMalesOnly.Checked) {
                btn_showMalesOnly.Checked = true;
                return;
            }

            btn_showMalesOnly.Checked = true;
            btn_showFemalesOnly.Checked = false;
            btn_showAll.Checked = false;
            lbl_filter.Text = "Shown: Males only";

            if (_allItems.Count == 0)
                return;

            listView1.Items.Clear();

            foreach (ListViewItem item in _allItems)
                if (Convert.ToBoolean(item.SubItems[2].Tag))
                    listView1.Items.Add(item);
        }

        private void btn_showFemalesOnly_Click(object sender, EventArgs e) {
            if (!btn_showFemalesOnly.Checked) {
                btn_showFemalesOnly.Checked = true;
                return;
            }

            btn_showMalesOnly.Checked = false;
            btn_showFemalesOnly.Checked = true;
            btn_showAll.Checked = false;
            lbl_filter.Text = "Shown: Females only";

            if (_allItems.Count == 0)
                return;

            listView1.Items.Clear();

            foreach (ListViewItem item in _allItems)
                if (!Convert.ToBoolean(item.SubItems[2].Tag))
                    listView1.Items.Add(item);
        }

        private void btn_showAll_Click(object sender, EventArgs e) {
            if (!btn_showAll.Checked) {
                btn_showAll.Checked = true;
                return;
            }

            btn_showMalesOnly.Checked = false;
            btn_showFemalesOnly.Checked = false;
            btn_showAll.Checked = true;
            lbl_filter.Text = "Shown: All";

            if (_allItems.Count == 0)
                return;

            if (listView1.Items.Count == 0) {
                foreach (ListViewItem item in _allItems)
                    listView1.Items.Add(item);
            } else {
                bool areMalesShownCurrently = Convert.ToBoolean(listView1.Items[0].SubItems[2].Tag);

                foreach (ListViewItem item in _allItems)
                    if (Convert.ToBoolean(item.SubItems[2].Tag) != areMalesShownCurrently)
                        listView1.Items.Add(item);
            }
        }

        private void btn_selectMalesOnly_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in listView1.Items)
                if (Convert.ToBoolean(item.SubItems[2].Tag))
                    item.Selected = true;
        }

        private void ben_selectFemalesOnly_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in listView1.Items)
                if (!Convert.ToBoolean(item.SubItems[2].Tag))
                    item.Selected = true;
        }

        private void btn_exit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
