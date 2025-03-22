using CadastroDeCliente;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    public partial class FormUsuario : Form
    {
        private readonly List<Cliente> Clientes = new List<Cliente>();
        private readonly BindingSource BindingSource = new();

        public FormUsuario()
        {
            InitializeComponent();

            // Dados iniciais
            EnderecoCliente enderecoyasmine = new EnderecoCliente() { Bairro = "Av Paulista", Cep = "09876-040", Complemento = "Casa", Estado = "SP", Logradouro = "Rua do Feitiço", Municipio = "São Paulo", Numero = "77" };
            Cliente yasmine = new Cliente() { Id = 1, Nome = "Yasmine Lamark", DataNascimento = "31/08/1991", Etnia = EtniaCliente.PARDO, Telefone = "19860-8900", Email = "yasmine@email.com", Tipo = TipoCliente.PJ, EnderecoCliente = enderecoyasmine, Genero = GeneroCliente.FEMININO };
            Clientes.Add(yasmine);

            EnderecoCliente enderecomaria = new EnderecoCliente() { Bairro = "Jardim das Flores", Cep = "07896-050", Complemento = "Apartamento", Estado = "SP", Logradouro = "Rua do Amor", Municipio = "São Paulo", Numero = "854" };
            Cliente maria = new Cliente() { Id = 2, Nome = "Maria Cicera", DataNascimento = "25/10/1970", Etnia = EtniaCliente.NEGRO, Telefone = "19234-9000", Email = "maria@email.com", Tipo = TipoCliente.PJ, EnderecoCliente = enderecomaria, Genero = GeneroCliente.FEMININO, Estrangeiro = true };
            Clientes.Add(maria);

            EnderecoCliente enderecolara = new EnderecoCliente() { Bairro = "Morumbi", Cep = "05323-030", Complemento = "Casa", Estado = "SP", Logradouro = "Rua da Rosa", Municipio = "São Paulo", Numero = "876" };
            Cliente lara = new Cliente() { Id = 3, Nome = "Lara Lamark", NomeSocial = "Larah", DataNascimento = "07/12/2020", Etnia = EtniaCliente.BRANCO, Telefone = "19234-9000", Email = "lara@email.com", Tipo = TipoCliente.PJ, EnderecoCliente = enderecolara, Genero = GeneroCliente.FEMININO };
            Clientes.Add(lara);

            BindingSource.DataSource = Clientes;
            dataGridView1.DataSource = BindingSource;

            comboBoxGenero.Items.AddRange(new string[] { "Masculino", "Feminino", "Outro", "Homem Trans", "Mulher Trans", "Homem Cisgênero", "Mulher Cisgênero" });
            comboBoxEtnia.Items.AddRange(new string[] { "Branco", "Negro", "Asiático", "Indígena", "Mulato", "Mestiço ", "Outros" });
        }

        private bool ValidarDataNascimento(string dataNascimento)
        {
            DateTime data;
            return DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data);
        }

        private void MostrarMensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxDataNasc.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                comboBoxGenero.SelectedIndex == -1 ||
                comboBoxEtnia.SelectedIndex == -1 ||
                !(radioButtonPF.Checked || radioButtonPJ.Checked) ||
                string.IsNullOrWhiteSpace(textBoxBairro.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxCep.Text) ||
                string.IsNullOrWhiteSpace(textBoxComplemento.Text) ||
                string.IsNullOrWhiteSpace(textBoxLogradouro.Text) ||
                string.IsNullOrWhiteSpace(textBoxMunicipio.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumero.Text) ||
                comboBoxEstado.SelectedIndex == -1)
            {
                MostrarMensagemErro("Por favor, preencha todos os campos.");
                return false;
            }

            return true;
        }

        private bool ValidarEmail()
        {
            if (Clientes.Any(c => c.Email == textBoxEmail.Text))
            {
                MostrarMensagemErro("Este email já foi cadastrado. Por favor, insira um email diferente.");
                return false;
            }

            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!emailRegex.IsMatch(textBoxEmail.Text))
            {
                MostrarMensagemErro("O e-mail inserido é inválido. Por favor, insira um e-mail válido.");
                return false;
            }

            return true;
        }

        private bool ValidarTelefoneCep()
        {
            if (!maskedTextBoxTelefone.MaskFull || !maskedTextBoxCep.MaskFull)
            {
                MostrarMensagemErro("O telefone ou CEP inserido é inválido. Por favor, insira valores válidos.");
                return false;
            }
            return true;
        }

        private Cliente CriarCliente()
        {
            EnderecoCliente endereco = new EnderecoCliente()
            {
                Bairro = textBoxBairro.Text,
                Cep = maskedTextBoxCep.Text,
                Complemento = textBoxComplemento.Text,
                Estado = comboBoxEstado.SelectedItem.ToString(),
                Logradouro = textBoxLogradouro.Text,
                Municipio = textBoxMunicipio.Text,
                Numero = textBoxNumero.Text
            };

            GeneroCliente generoSelecionado = (GeneroCliente)comboBoxGenero.SelectedIndex;
            EtniaCliente etniaSelecionada = (EtniaCliente)comboBoxEtnia.SelectedIndex;

            return new Cliente()
            {
                Nome = textBoxNome.Text,
                Id = Clientes.Count + 1,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEmail.Text,
                DataNascimento = maskedTextBoxDataNasc.Text,
                NomeSocial = textBoxNomeSocial.Text,
                Genero = generoSelecionado,
                Etnia = etniaSelecionada,
                Estrangeiro = checkBoxEstrangeiro.Checked,
                Tipo = radioButtonPF.Checked ? TipoCliente.PF : TipoCliente.PJ,
                EnderecoCliente = endereco
            };
        }

        private void buttonAdicionarClientes_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios()) return;
            if (!ValidarEmail()) return;
            if (!ValidarTelefoneCep()) return;

            Cliente cliente = CriarCliente();
            Clientes.Add(cliente);
            BindingSource.ResetBindings(false);

            LimparCampos();
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            maskedTextBoxDataNasc.Clear();
            maskedTextBoxTelefone.Clear();
            textBoxEmail.Clear();
            textBoxNomeSocial.Clear();
            comboBoxGenero.SelectedIndex = -1;
            comboBoxEtnia.SelectedIndex = -1;
            checkBoxEstrangeiro.Checked = false;
            radioButtonPF.Checked = false;
            radioButtonPJ.Checked = false;
            textBoxBairro.Clear();
            maskedTextBoxCep.Clear();
            textBoxComplemento.Clear();
            textBoxLogradouro.Clear();
            textBoxMunicipio.Clear();
            textBoxNumero.Clear();
            comboBoxEstado.SelectedIndex = -1;
        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }
    }
}
