using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Production;

namespace CpS_420_Inception_Project
{
    public partial class Store_Form : Form
    {
        public enum ActionMode { Create, Edit }

        private ActionMode mode;

        private ActionMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
                if (value == ActionMode.Edit)
                {
                    Text = "Edit Store";
                    acceptButton1.Visible = true;
                    acceptButton1.Text = "Save";
                    acceptButton2.Text = "Delete";
                    AcceptButton = acceptButton1;
                }
            }
        }

        private Store Store { get; set; }

        public Store_Form(ActionMode mode)
        {
            InitializeComponent();
            Mode = mode;
            if (Mode == ActionMode.Create)
            {
                storeNumComboBox.DropDownStyle = ComboBoxStyle.Simple;
            }
        }

        public Store_Form(ActionMode mode, string storeNum) : this(mode)
        {
            storeNumComboBox.Text = storeNum;
            if (Mode == ActionMode.Create)
            {
                storeNumComboBox.Enabled = false;
            }
        }

        private void Check_Form_Load(object sender, EventArgs e)
        {
            PopulateStoreNumDropdown();
        }

        private void acceptButton1_Click(object sender, EventArgs e)
        {
            UpdateStore();
        }

        private void acceptButton2_Click(object sender, EventArgs e)
        {
            if (mode == ActionMode.Create)
            {
                AddStore();
            }
            else
            {
                DeleteStore();
            }
        }


        private void fieldsChanged(object sender, EventArgs e)
        {
            bool noneEmptyFields = (storeNumComboBox.Text.Length > 0 &&
                                    nameTextBox.Text.Length > 0 &&
                                    streetTextBox.Text.Length > 0 &&
                                    cityTextBox.Text.Length > 0 &&
                                    stateComboBox.Text.Length > 0 &&
                                    zipTextBox.Text.Length > 0);

            bool validStore = DatabaseAgent.DefaultAgent.StoreExists(storeNumComboBox.Text);

            if (mode == ActionMode.Create)
            {
                acceptButton2.Enabled = noneEmptyFields && !validStore;
            }
            else
            {
                bool keyFieldsChanged = sender == storeNumComboBox;
                acceptButton1.Enabled = noneEmptyFields && validStore;
                if ((acceptButton2.Enabled = validStore) && keyFieldsChanged)
                {
                    UpdateFields();
                }
            }
        }

        private void UpdateFields()
        {
            Store = DatabaseAgent.DefaultAgent.GetStore(storeNumComboBox.Text);
            nameTextBox.Text = Store.Name;
            streetTextBox.Text = Store.Street;
            cityTextBox.Text = Store.City;
            stateComboBox.Text = Store.State;
            zipTextBox.Text = Store.Zipcode;
        }

        private void AddStore()
        {
            ComposeStore();
            DatabaseAgent.DefaultAgent.AddStore(Store);
            
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateStore()
        {
            ComposeStore();
            DatabaseAgent.DefaultAgent.UpdateStore(Store);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void DeleteStore()
        {
            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            string storeNum = storeNumComboBox.Text;
            if (db.StoreIsReferenced(storeNum))
            {
                MessageBox.Show("This store is referenced by one or more checks and cannot be deleted.", "Can't Delete Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DatabaseAgent.DefaultAgent.DeleteStore(storeNum);

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ComposeStore()
        {
            Store = new Store();

            Store.ID = storeNumComboBox.Text;
            Store.Name = nameTextBox.Text;
            Store.Street = streetTextBox.Text;
            Store.City = cityTextBox.Text;
            Store.State = stateComboBox.Text;
            Store.Zipcode = zipTextBox.Text;
        }

        private void PopulateStoreNumDropdown()
        {
            storeNumComboBox.Items.Clear();

            DatabaseAgent db = DatabaseAgent.DefaultAgent;
            string[] storeNums = db.StoreKeys.ToArray();

            storeNumComboBox.Items.AddRange(storeNums);
        }
    }
}
