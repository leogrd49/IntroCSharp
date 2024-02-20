namespace IntroCSharp.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormListChips form = new FormListChips();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.LawnGreen)
            {
                this.BackColor = System.Drawing.Color.Aqua;
            }
            else if (this.BackColor == System.Drawing.Color.Aqua) ;
            {
                this.BackColor = System.Drawing.Color.LawnGreen;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormListChips form = new FormListChips();
            form.ShowDialog();
        }
    }
}
