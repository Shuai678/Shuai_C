namespace Shuai_C
{
    public partial class Form1 : Form
    {
        private cassaforte cassaforte1;
        public Form1()
        {
            InitializeComponent();
            cassaforte1 = new cassaforte("1234567", "huawei", "mate70pro", "0", "zxcvbnmafghjk", "0");
            AggiornaForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AggiornaForm()
        {
            if (cassaforte1.Aperta == true)
            {
                cassafortebtn.BackColor = Color.Green;
            }
            else
                cassafortebtn.BackColor = Color.Red;
        }

        private void invia_codice_btn_Click(object sender, EventArgs e)
        {
            cassaforte1.Apri(Convert.ToString(password_inserita.Text));

            cassaforte1.Sblocca(Convert.ToString(password_inserita.Text));
            AggiornaForm();

        }

        private void invia_data_btn_Click(object sender, EventArgs e)
        {

            cassaforte1.AperturaProgrammata(Convert.ToString(password_inserita.Text), Convert.ToString(data_inserita.Text));
            AggiornaForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (codice_utente.Text.Length != 5)
            {
                Console.WriteLine("non va bene");
            }else
            cassaforte1.ImpostaCodiceUtente(Convert.ToString(codice_utente.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cassaforte1.ImpostaDataProgrammata(Convert.ToString(codice_sblocco.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cassaforte1.Chiudi();
            AggiornaForm();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
