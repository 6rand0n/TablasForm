namespace Tabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.Num.Text);
            string tabla = "";
            for(int i= 1; i <= 10; i++)
            {
                tabla = tabla + n + " x " + i + " = " + (n * i) + "\n";
            }
            this.Resultados.AppendText(tabla);
        }
    }
}
