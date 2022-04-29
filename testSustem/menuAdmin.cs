using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSustem
{
    public partial class menuAdmin : Form
    {
        public menuAdmin(Model.User user)
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDataTestForm menu = new EditDataTestForm();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
