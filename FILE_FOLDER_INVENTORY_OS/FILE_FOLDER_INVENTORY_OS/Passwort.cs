using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILE_FOLDER_INVENTORY
{
    public partial class FormPasswort : Form
    {
        private bool pass = false;
        public bool Pass { get => pass; set => pass = value; }
        public void setPassBol(bool passBol)
        {
            pass = passBol;
        }       
        public FormPasswort()
        {
            InitializeComponent();
        }
        private void maskedTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                if (maskedTextBox1.Text == "admin")
                {
                    pass = true;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
