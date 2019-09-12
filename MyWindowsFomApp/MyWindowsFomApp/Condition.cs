using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFomApp
{
    public partial class Condition : Form
    {
        public Condition()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.Text== "")
            {
                MessageBox.Show("Please select one");
            }
            else
            {
                MessageBox.Show(ItemComboBox.Text+"is selected");
            }
        }
    }
}
