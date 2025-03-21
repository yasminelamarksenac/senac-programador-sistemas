using CadastroDeCliente;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    public partial class FormUsuario : Form
    {

        private readonly List<Cliente> Clientes = new List<Cliente>();
        private readonly BindingSource BindingSource = [];

        public FormUsuario()
        {
            InitializeComponent();

          



            EnderecoCliente enderecoyasmine = new EnderecoCliente() { Bairro = "Av Paulista", Cep = "09876-040", Complemento = "Casa", Estado = "SP", Logradouro = "Rua do Feitiço", Municipio = "São Paulo", Numero = "77" };
            Cliente yasmine = new Cliente() { Id = 1, Nome = "Yasmine Lamark", DataNascimento = "31/08/1991", Etnia = EtniaCliente.PARDO, Tipo = TipoCliente.PJ, EnderecoCliente = enderecoyasmine, Genero = GeneroCliente.FEMININO };
            Clientes.Add(yasmine);

            EnderecoCliente enderecomaria = new EnderecoCliente() { Bairro = "Jardim das Flores", Cep = "07896-050", Complemento = "Apartamento", Estado = "SP", Logradouro = "Rua do Amor", Municipio = "São Paulo", Numero = "854" };
            Cliente maria = new Cliente() { Id = 2, Nome = "Maria Cicera", DataNascimento = "25/10/1970", Etnia = EtniaCliente.NEGRO, Tipo = TipoCliente.PJ, EnderecoCliente = enderecomaria, Genero = GeneroCliente.FEMININO };
            Clientes.Add(maria);

            EnderecoCliente enderecolara = new EnderecoCliente() { Bairro = "Morumbi", Cep = "05323-030", Complemento = "Casa", Estado = "SP", Logradouro = "Rua da Rosa", Municipio = "São Paulo", Numero = "876" };
            Cliente lara = new Cliente() { Id = 3, Nome = "Lara Lamark", DataNascimento = "07/12/2020", Etnia = EtniaCliente.BRANCO, Tipo = TipoCliente.PJ, EnderecoCliente = enderecolara, Genero = GeneroCliente.FEMININO };
            Clientes.Add(lara);

            BindingSource.DataSource = Clientes;
            dataGridView1.DataSource = BindingSource;

            
            comboBoxGenero.Items.Add("Masculino");
            comboBoxGenero.Items.Add("Feminino");
            comboBoxGenero.Items.Add("Outro");

            comboBoxEtnia.Items.Add("Branco");
            comboBoxEtnia.Items.Add("Negro");
            comboBoxEtnia.Items.Add("Asiático");
            comboBoxEtnia.Items.Add("Indígena");
            comboBoxEtnia.Items.Add("Outros");
        }

        private void buttonAdicionarClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxDataNasc.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                comboBoxGenero.SelectedIndex == -1 ||
                comboBoxEtnia.SelectedIndex == -1 ||
                !(radioButtonPF.Checked || radioButtonPJ.Checked))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            foreach (var c in Clientes)
            {
                if (c.Email == textBoxEmail.Text)
                {
                    MessageBox.Show("Este email já foi cadastrado. Por favor, insira um email diferente.");
                    return;
                }
            }
          
            string email = textBoxEmail.Text;
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("O e-mail inserido é inválido. Por favor, insira um e-mail válido.");
                return;
            }

            if (!maskedTextBoxTelefone.MaskFull)
            {
                MessageBox.Show("O telefone inserido é inválido. Por favor, insira um telefone válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNome.Text) || !textBoxNome.Text.All(char.IsLetter))
            {
                MessageBox.Show("O nome inserido é inválido. Por favor, insira um nome válido.");
                return;
            }
            string dataNascimento = maskedTextBoxDataNasc.Text;

            if (dataNascimento.Any(ch => !char.IsDigit(ch) && ch != '/'))
            {
                MessageBox.Show("A data de nascimento não pode conter letras. Por favor, insira uma data válida.");
                return;
            }

            if (!(radioButtonPF.Checked || radioButtonPJ.Checked))
            {
                MessageBox.Show("Por favor, selecione o tipo de cliente (Pessoa Física ou Pessoa Jurídica).");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxBairro.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxCep.Text) ||
                string.IsNullOrWhiteSpace(textBoxComplemento.Text) ||
                string.IsNullOrWhiteSpace(textBoxLogradouro.Text) ||
                string.IsNullOrWhiteSpace(textBoxMunicipio.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumero.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos do endereço.");
                return;
            }


            if (!maskedTextBoxCep.MaskFull)
            {
                MessageBox.Show("O CEP inserido é inválido. Por favor, insira um CEP válido.");
                return;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o estado.");
                return;
            }



            GeneroCliente generoSelecionado = (GeneroCliente)comboBoxGenero.SelectedIndex;
            EtniaCliente etniaSelecionada = (EtniaCliente)comboBoxEtnia.SelectedIndex;


            Cliente cliente = new Cliente()
            {
                Id = Clientes.Count + 1,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEmail.Text,
                DataNascimento = maskedTextBoxDataNasc.Text,
                NomeSocial = textBoxNomeSocial.Text,
                Genero = generoSelecionado,
                Etnia = etniaSelecionada,
                Estrangeiro = checkBoxEstrangeiro.Checked,
                Tipo = radioButtonPF.Checked ? TipoCliente.PF : TipoCliente.PJ


            };


            Clientes.Add(cliente);
            BindingSource.ResetBindings(false);

            LimparCampos();


            ExibirClientes();


            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void ExibirClientes()
        {
            
            

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
        }

        private void buttonMostrarClientes_Click(object sender, EventArgs e)
        {
            ExibirClientes();
            BindingSource.ResetBindings(false);
        }
    }
}
