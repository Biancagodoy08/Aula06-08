namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        public String USUARIO;
        public int contador;
        public Form1()
        {
            InitializeComponent();
        }

        public void trocar_usuario()
        {
            if (USUARIO == "O")
                USUARIO = "X";
            else
                USUARIO = "O";

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            USUARIO = "X";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {




        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            button12.Visible = false;
            button13.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            USUARIO = "O";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = USUARIO;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
