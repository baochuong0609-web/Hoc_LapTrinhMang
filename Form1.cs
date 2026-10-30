using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo_kết_nối_service
{
    public partial class Form1 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4AR8hoxB9cLeXEn9DLS7GfekgLRPO3YOX1vdT6zY",
            BasePath = "https://fir-6a4f7-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        public Form1()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Kết nối Firebase Service thành công!");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnWrite_Click_Click(object sender, EventArgs e)
        {
            var msg = new ChatMessage
            {
                Sender = "Bảo Chương",
                Content = txtInput.Text,
                Timestamp = DateTime.Now.ToString("HH:mm:ss")
            };

            PushResponse response = await client.PushAsync("Messages/", msg);
            MessageBox.Show("Đã ghi dữ liệu thành công!");
        }

        private async void btnRead_Click_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Messages/");

            if (response.Body != "null")
            {
                var data = JsonConvert.DeserializeObject<Dictionary<string, ChatMessage>>(response.Body);

                listBoxData.Items.Clear(); // Xóa sạch dữ liệu cũ trong listBox1 của bà
                foreach (var item in data)
                {
                    // Đổ dữ liệu mới vào listBox1
                    listBoxData.Items.Add($"[{item.Value.Timestamp}] {item.Value.Sender}: {item.Value.Content}");
                }
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }


    public class ChatMessage
    {
        public string Sender { get; set; }
        public string Content { get; set; }
        public string Timestamp { get; set; }
    }
}