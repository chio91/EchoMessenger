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
            if (string.IsNullOrWhiteSpace(typed_msg) == false)
                ListMsg.Items.Add(typed_msg);
            InputTxt.Clear();
            InputTxt.Focus();
        }

        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string typed_msg;
                typed_msg = InputTxt.Text;
                if (string.IsNullOrWhiteSpace(typed_msg) == false)
                    ListMsg.Items.Add(typed_msg);
                InputTxt.Clear();
                InputTxt.Focus();
            }
        }
    }
}
