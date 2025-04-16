using ListaAtividades.Dominio;
using Org.BouncyCastle.Asn1.Mozilla;

namespace ListaAtividade
{
    public partial class ListaDr : Form
    {
       public ListaDeAtividade()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Atividade atividade = new ();


            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.Id > 0)
            {

                TextBoxAtividadeAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }
            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;
        }
    }
}
