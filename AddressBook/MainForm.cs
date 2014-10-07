using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            foreach (AddressEntry entry in AddressEntryDAO.LoadAll())
            {
                listView.Items.Add(new ListViewItem(new string[] { entry.getName(), entry.getAddr() }));
            }
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
