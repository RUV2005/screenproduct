using static System.Net.WebRequestMethods;
using System.Net;
using System.Text.Json;
namespace screenproduct
{
    public partial class Form1 : Form
    {
        private static HttpClient httpClient = new HttpClient();
        readonly string uri = "https://v1.hitokoto.cn/?abcdefghijklf&encode=text";
        private static HttpClient background = new HttpClient();
        readonly string backurl = "https://v1.hitokoto.cn/?abcdefghijklf&encode=text";
        public Form1()
        {
            InitializeComponent();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor= Color.Transparent;
            string res = await httpClient.GetStringAsync(uri);
            label1.Text = res;
        }

        private async void label1_Click(object sender, EventArgs e)
        {
            string res = await httpClient.GetStringAsync(uri);
            label1.Text = res;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}