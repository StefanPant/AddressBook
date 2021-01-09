using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.contactDBDataSet.Table);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.contactDBDataSet1.Table);

        }

        private void tableBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.contactDBDataSet1);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact list");
        }
    }
}
