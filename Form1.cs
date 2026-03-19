namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendBut_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = InputTxt.Text;
            ListMsg.Items.Add(typed_msg);
            InputTxt.Clear();
        }

    }
}
