using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void backgroundWorkerClient_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!backgroundWorkerClient.CancellationPending)
            {
                try
                {
                    TcpClient client = null;
                    NetworkStream stream = null;
                    client = new TcpClient();
                    Log($"Попытка подключения");
                    client.Connect("127.0.0.1", 8081);
                    Log($"Получаю поток для записи");
                    stream = client.GetStream();

                    if (stream != null)
                    {
                        stream.Close();
                        stream = null;
                    }
                    if (client != null && client.Connected != false)
                    {
                        client.Close();
                    }
                    Log($"Соединение закрыто");
                }
                catch (Exception ex)
                {
                    Log($"Ошибка подключения: {ex.Message}");
                }
                Thread.Sleep(new TimeSpan(0, 0, 5));
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            backgroundWorkerClient.RunWorkerAsync();
        }

        public void Log(string Message)
        {
            Action action = () => textBoxClient.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} >> {Message}{Environment.NewLine}");
            textBoxClient.Invoke(action);
        }
    }
}
