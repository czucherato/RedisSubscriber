using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RedisSubscriber.Modelos.MensagemMds;
using RedisSubscriber.Interfaces.Aplicacao;

namespace RedisSubscriber
{
    public partial class Resposta : Form
    {
        public Resposta() => InitializeComponent();

        private delegate void MensagemDeRetorno(string mensagem);

        private void CkInscrever_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CkInscrever.Checked)
            {
                Thread th = new Thread(new ThreadStart(this.Inscrever));
                th.Start();
            }
        }

        private void Inscrever()
        {
            ReceberMd comando = new ReceberMd(".NET14");

            if (this.TxtResposta.InvokeRequired)
            {
                using (InjecaoDeDependencia injecao = new InjecaoDeDependencia())
                {
                    IOuvinteApp ouvinteApp = injecao.Invocar<IOuvinteApp>();
                    ouvinteApp.Inscrever().Subscribe(comando.Canal, (canal, mensagem) =>
                    {
                        if (!string.IsNullOrEmpty(mensagem))
                            this.Invoke(new MensagemDeRetorno(Aplicar), new object[] { mensagem.ToString() });
                    });
                }
            }
        }

        private void Aplicar(string texto)
        {
            StringBuilder sb = new StringBuilder();
            TxtPergunta.Text = sb.Append(TxtPergunta.Text)
                .Append($"\r\n Pergunta: { texto }").ToString();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
