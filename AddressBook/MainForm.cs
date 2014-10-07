﻿using System;
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
            listView.Items.Clear();
            foreach (AddressEntry entry in AddressEntryDAO.LoadAll())
            {
                listView.Items.Add(new ListViewItem(new string[] { entry.getName(), entry.getAddr() }));
            }
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditWindow dialog = new EditWindow();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string text = listView.SelectedItems[0].Text;
                AddressEntryDAO.UpdateRecord(new AddressEntry(text, dialog.email));
                LoadTable();
            }
        }
    }
}
