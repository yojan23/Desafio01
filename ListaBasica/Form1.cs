namespace ListaBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] razasDePerrosArray = new string[5];

            this.lblSaludo.Text += " Yojan";

            razasDePerrosArray[0] = "Dalmata";
            razasDePerrosArray[1] = "Aleman";
            razasDePerrosArray[2] = "Pudel";
            razasDePerrosArray[3] = "Pequines";
            razasDePerrosArray[4] = "Pitbul";
            
            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                this.LstRazas.Item.Add(razasDePerrosArray[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}