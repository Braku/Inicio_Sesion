using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_de_Sesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = usutb;
            usutb.Focus();
        }

        private void Usutb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contrabt.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                contrabt.Focus();
            }
        }

        private void Contrabt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = "juancho";
            password = "123tamarindo";
            if (usutb.Text == username & contrabt.Text == password)
            {
                MessageBox.Show("Bienvenido " + username);
            }
            else
            {
                MessageBox.Show("El usuario o contraseña estan incorrectos");
            }
        }

    }
}
