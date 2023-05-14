namespace WinFormsApp1


{
    public partial class Form1 : Form
    {
        // Declaração das variáveis booleanas que serão usadas para identificar qual operação será realizada
        bool adicao = false, subtracao = false, divisao = false, multiplicacao = false, potencia = false, igual = false;
        // Instância da classe "Operacoes" que contém os métodos para realizar as operações
        Operacoes operacoes = new Operacoes();//
        double conta1;//Sera o primeiro numero 
        string conta2;//sera o segundo numero, é tipo string pois é mais facil de modelar        

        public Form1()
        {
            InitializeComponent();
        }
        // Metodo que sera executado toda vez que um numero for selecionado, realiza as operaçoes de acordo com os booleanos acima
        private void AtualizarResultado() 
        {
            //Só atualiza o resultado se tiver um segundo numero para realizar a operação
            if (conta2 != null)
            {
                if (potencia)
                {
                    txtresultado.Text = Convert.ToString(operacoes.Potencia(conta1, double.Parse(conta2)));
                }
                else if (divisao)
                {
                    txtresultado.Text = Convert.ToString(operacoes.Divisao(conta1, double.Parse(conta2)));
                }
                else if (multiplicacao)
                {
                    txtresultado.Text = Convert.ToString(operacoes.Multiplicacao(conta1, double.Parse(conta2)));
                }
                else if (adicao)
                {
                    txtresultado.Text = Convert.ToString(operacoes.Adicao(conta1, double.Parse(conta2)));
                }
                else if (subtracao)
                {
                    txtresultado.Text = Convert.ToString(operacoes.Subtracao(conta1, double.Parse(conta2)));
                }
            }
        }
        private void botao0_Click(object sender, EventArgs e)
        {
            // Verifica se o botão "=" foi clicado anteriormente para limpar as variáveis
            if (igual)
            {
                // Configura o tamanho da fonte do texto (pois o botao "=" altera para maior destaque do resultado)e limpa as variáveis
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            // Verifica se há uma operação selecionada para atualizar o segundo operando
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "0";
                conta2 += "0";
                AtualizarResultado();
            }
            //Se não há operação selecionada, apenas digita o número
            else
            {
                txtresultado.Text += "0";
                txtconta.Text += "0";
            }
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "1";
                conta2 += "1";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "1";
                txtconta.Text += "1";
            }
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "2";
                conta2 += "2";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "2";
                txtconta.Text += "2";
            }
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "3";
                conta2 += "3";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "3";
                txtconta.Text += "3";
            }
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "4";
                conta2 += "4";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "4";
                txtconta.Text += "4";
            }
        }
        private void botao5_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "5";
                conta2 += "5";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "5";
                txtconta.Text += "5";
            }

        }
        private void botao6_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "6";
                conta2 += "6";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "6";
                txtconta.Text += "6";
            }
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "7";
                conta2 += "7";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "7";
                txtconta.Text += "7";
            }
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "8";
                conta2 += "8";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "8";
                txtconta.Text += "8";
            }
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
                txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
                txtconta.Text = "";
                txtresultado.Text = "";
                conta1 = 0;
                conta2 = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                potencia = false;
                igual = false;
            }
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += "9";
                conta2 += "9";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += "9";
                txtconta.Text += "9";
            }
        }
        private void botaovirgula_Click(object sender, EventArgs e)
        {
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                txtconta.Text += ",";
                conta2 += ",";
                AtualizarResultado();
            }
            else
            {
                txtresultado.Text += ",";
                txtconta.Text += ",";
            }
        }
        private void botaoadicao_Click(object sender, EventArgs e)
        {
            // Verifica se alguma outra operação já foi selecionada antes
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                //Torna apenas o booleano desejado em true 
                adicao = true;
                multiplicacao = false; potencia = false; divisao = false; subtracao = false;
                conta1 = double.Parse(txtresultado.Text);// Pega o valor que está aparecendo sozinho na tela e coloca na variavel conta1
                txtconta.Text = txtresultado.Text + "+";
                conta2 = "";//Zera a variavel conta2 para evitar erros
            }
            // Se nenhuma outra operação foi selecionada antes, obtém o primeiro número da operação
            else
            {
                conta1 = double.Parse(txtconta.Text);
                txtconta.Text += "+";
                adicao = true;
            }

        }

        private void botaomenos_Click(object sender, EventArgs e)
        {
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                subtracao = true;
                multiplicacao = false; potencia = false; divisao = false; adicao = false;
                conta1 = double.Parse(txtresultado.Text);
                txtconta.Text = txtresultado.Text + "-";
                conta2 = "";

            }
            else
            {
                conta1 = double.Parse(txtconta.Text);
                txtconta.Text += "-";
                subtracao = true;
            }
        }

        private void botaovezes_Click(object sender, EventArgs e)
        {
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                AtualizarResultado();
                multiplicacao = true;
                subtracao = false; potencia = false; divisao = false; adicao = false;
                conta1 = double.Parse(txtresultado.Text);
                txtconta.Text = txtresultado.Text + "x";
                conta2 = "";

            }
            else
            {
                conta1 = double.Parse(txtconta.Text);
                txtconta.Text += "x";
                multiplicacao = true;
            }
        }

        private void botaodivisao_Click(object sender, EventArgs e)
        {
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                AtualizarResultado();
                divisao = true;
                subtracao = false; potencia = false; multiplicacao = false; adicao = false;
                conta1 = double.Parse(txtresultado.Text);
                txtconta.Text = txtresultado.Text + "÷";
                conta2 = "";

            }
            else
            {
                conta1 = double.Parse(txtconta.Text);
                txtconta.Text += "÷";
                divisao = true;
            }
        } 
        private void botaopotencia_Click(object sender, EventArgs e)
        {
            if (adicao || subtracao || divisao || multiplicacao || potencia)
            {
                AtualizarResultado();
                potencia = true;
                subtracao = false; divisao = false; multiplicacao = false; adicao = false;
                conta1 = double.Parse(txtresultado.Text);
                txtconta.Text = txtresultado.Text + "^";
                conta2 = "";

            }
            else
            {
                conta1 = double.Parse(txtconta.Text);
                txtconta.Text += "^";
                potencia = true;
            }
        }

        private void botaoigual_Click(object sender, EventArgs e)
        {
            igual = true;//Torna o Booleano igual em true para reverter as mudancas depois
            //Muda as fontes para haver maior destaque no resultado do que na conta
            txtconta.Font = new Font(txtconta.Font.FontFamily, 10);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 50, FontStyle.Bold);
            txtresultado.Text = "= " + txtresultado.Text;
        }
        //Botao que literalmente reseta tudo
        private void botaoC_Click(object sender, EventArgs e)
        {
            txtconta.Text = "";
            txtresultado.Text = "";
            conta1 = 0;
            conta2 = "";
            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
            potencia = false;
        }
        //Botao que limpa o ultimo caracter
        private void botaobackspace_Click(object sender, EventArgs e)
        {
            //Se o caracter deletado for um operador algebrico torna o booleano correspondente em falso
            if (txtconta.Text.Substring(txtconta.Text.Length - 1) == "+")
            {
                adicao = false;
                
            }
            else if (txtconta.Text.Substring(txtconta.Text.Length - 1) == "-")
            {
                subtracao = false;
                
            }
            else if (txtconta.Text.Substring(txtconta.Text.Length - 1) == "÷")
            {
                divisao = false;
                
            }
            else if (txtconta.Text.Substring(txtconta.Text.Length - 1) == "x")
            {
                multiplicacao = false;
                
            }
            else if (txtconta.Text.Substring(txtconta.Text.Length - 1) == "^")
            {
                potencia = false;
                
            }
            //Comando que deleta o ultimo caracter
            txtconta.Text = txtconta.Text.Remove(txtconta.Text.Length - 1);
            //Caso o caracter deletado esteja dentro de uma operacao, o codigo ira processar a operacao inversa para manter a integridade do resultado,
            //Por exemplo: o codigo digitado é 6+5, se eu deletar o ultimo caracter, preciso garantir que o resultado exibido não seja 11 e sim 11-5 = 6
            //Além disso devo remover o ultimo caracter do segundo numero, para garantir a integridade das contas
            if (adicao)
            {
                txtresultado.Text = Convert.ToString(operacoes.Subtracao(double.Parse(txtresultado.Text), double.Parse(conta2)));
                conta2 = conta2.Remove(conta2.Length - 1);
            }
            else if (subtracao)
            {
                txtresultado.Text = Convert.ToString(operacoes.Adicao(double.Parse(txtresultado.Text), double.Parse(conta2)));
                conta2 = conta2.Remove(conta2.Length - 1);
            }
            else if (divisao)
            {
                txtresultado.Text = Convert.ToString(operacoes.Multiplicacao(double.Parse(txtresultado.Text), double.Parse(conta2)));
                conta2 = conta2.Remove(conta2.Length - 1);
            }
            else if (multiplicacao)
            {
                txtresultado.Text = Convert.ToString(operacoes.Divisao(double.Parse(txtresultado.Text), double.Parse(conta2)));
                conta2 = conta2.Remove(conta2.Length - 1);
            }
            else if (potencia)
            {
                txtresultado.Text = Convert.ToString(operacoes.Potencia(double.Parse(txtresultado.Text), 1 / double.Parse(conta2)));
                conta2 = conta2.Remove(conta2.Length - 1);
            }

        }

       
    }
}