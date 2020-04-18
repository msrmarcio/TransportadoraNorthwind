using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportadora.ConsumerWebApi.Client
{
    public partial class frmConsumerWebApi : MetroFramework.Forms.MetroForm
    {
        public frmConsumerWebApi()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Obtém uma instância de HttpCliente
        //  já configurado com o formato e a url do servidor
        /// </summary>
        /// <returns></returns>
        private HttpClient ObterHttClient()
        {
            var formato = new MediaTypeWithQualityHeaderValue("application/json");
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:49618/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(formato);

            return client;
        }

        /// <summary>
        /// Analisa se o comando foi bem sucedido
        /// </summary>
        /// <param name="resposta"></param>
        private void verificarResposta(HttpResponseMessage resposta)
        {
            if (!resposta.IsSuccessStatusCode)
            {
                MessageBox.Show("Erro no servidor:" +
                resposta.StatusCode);
            }
        }

        /// <summary>
        /// GET: Obtém todas as transportadoras
        /// </summary>
        private async void CarregarGrid()
        {
            using (var client = ObterHttClient())
            {
                var resposta = await client.GetAsync("http://localhost:49618/api/transportadoras");
                var conteudo = await resposta.Content.ReadAsAsync<Transportadora[]>();

                dgvTransportadoras.DataSource = conteudo;
                dgvTransportadoras.ReadOnly = true;
                dgvTransportadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        // POST: Adiciona uma nota Transportadora
        //
        private async void IncluirTransportadora(Transportadora t)
        {
            using (var client = ObterHttClient())
            {
                var resposta =
                await client.PostAsJsonAsync<Transportadora>("api/Transportadoras", t);
                verificarResposta(resposta);
            }
            CarregarGrid();
        }



        //
        // Obter a transportadora selecionada da Grid
        //
        private Transportadora ObterTransportadoraSelecionada()
        {
            if (dgvTransportadoras.DataSource != null &&
            dgvTransportadoras.CurrentRow != null &&
            dgvTransportadoras.CurrentRow.DataBoundItem is
            Transportadora)
            {
                return (Transportadora)dgvTransportadoras.CurrentRow.DataBoundItem;
            }
            else
            {
                return null;
            }
        }

        //
        // PUT: Alterar
        //
        private async void Alterar(Transportadora t)
        {
            using (var client = ObterHttClient())
            {
                var resposta = await client.PutAsJsonAsync<Transportadora>("api/Transportadoras/" + t.TransportadoraId, t);
            }
            CarregarGrid();
        }

        //
        // Retorna true ou false
        //
        private bool Pergunta(string msg)
        {
            var result = MessageBox.Show(msg, "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result == DialogResult.OK;
        }

        private void frmConsumerWebApi_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            var f = new TransportadoraForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                var t = f.ObterTransportadora();
                IncluirTransportadora(t);
            }
        }

        //
        // DEL: Excluir uma transportadora
        //
        private async void Excluir(int id)
        {
            using (var client = ObterHttClient())
            {
                var resposta = await client.DeleteAsync("api/transportadoras/" + id);
                verificarResposta(resposta);
            }
            CarregarGrid();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            var f = new TransportadoraForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                var t = f.ObterTransportadora();
                IncluirTransportadora(t);
            }

        }

        private void btngAlterar_Click(object sender, EventArgs e)
        {
            var t = ObterTransportadoraSelecionada();
            if (t == null) return;
            var f = new TransportadoraForm();
            f.ExibirTransportadora(t);
            if (f.ShowDialog() == DialogResult.OK)
            {
                t = f.ObterTransportadora();
                Alterar(t);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            var t = ObterTransportadoraSelecionada();
            if (t != null)
            {
                if (Pergunta("Confirma a exclusão"))
                {
                    Excluir(t.TransportadoraId);
                }
            }
        }
    }
}


