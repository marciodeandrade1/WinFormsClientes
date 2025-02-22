using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClientes.Modelo
{
    public class Cliente
    {
        // construtor
        public Cliente() { }

        // Propriedades - Private
        private int id;
        private string nome;
        private string email;

        // Propriedades - Public
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
