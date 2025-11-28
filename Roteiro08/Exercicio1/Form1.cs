namespace Exercicio1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnMaximizar_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
        btnRestaurar.Visible = true;
    }

    private void btnRestaurar_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Normal;
        btnRestaurar.Visible = false;
        btnMaximizar.Visible = true;
    }

    private void btnForm2_Click(object sender, EventArgs e)
    {

        Form2 formProdutos = new Form2();

        formProdutos.Show();

        this.Hide();
    }

    private void btnForm3_Click(object sender, EventArgs e)
    {

        Form3 formProdutos = new Form3();

        formProdutos.Show();

        this.Hide();
    }

    private void btnForm4_Click(object sender, EventArgs e)
    {

        Form4 formProdutos = new Form4();

        formProdutos.Show();

        this.Hide();
    }
  
}
