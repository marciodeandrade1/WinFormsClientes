using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsClientes.Modelo;


namespace WinFormsClientes
{
    public partial class Form1 : Form
    {
        Cliente cliente = new Cliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cliente.Id = int.Parse(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;

            lstBoxClientes.Items.Add(cliente.Id.ToString());
            lstBoxClientes.Items.Add(cliente.Nome);
            lstBoxClientes.Items.Add(cliente.Email);
        }
    }
}
