using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportadora.ConsumerWebApi.Client
{
    public partial class TransportadoraForm : MetroFramework.Forms.MetroForm
    {
        private int transportadoraId = 0;

        public TransportadoraForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public void ExibirTransportadora(Transportadora t)
        {
            txtNome.Text = t.Nome;
            txtTelefone.Text = t.Telefone;
            transportadoraId = t.TransportadoraId;
        }

        /// <summary>
        /// Retorna objeto transportadora
        /// </summary>
        /// <returns>Objeto classe Transportadora</returns>
        public Transportadora ObterTransportadora()
        {
            var t = new Transportadora();
            t.TransportadoraId = transportadoraId;
            t.Nome = txtNome.Text;
            t.Telefone = txtTelefone.Text;

            return t;
        }
    }
}
