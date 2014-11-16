using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Inicio : Form
    {


        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuClientes mc = new MenuClientes();
            mc.Show();
            this.Hide();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuClientes mc = new MenuClientes();
            mc.Show();
            this.Hide();
        }

        private void Bcuentas_Click(object sender, EventArgs e)
        {
            MenuClientes mc = new MenuClientes();
            mc.Show();
            this.Hide();
        }

       
    }
}
