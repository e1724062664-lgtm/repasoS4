namespace repasoS4.Views;

public partial class vReporte : ContentPage
{
	public vReporte(string nombre, string carrera, string nivel, string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Bienvenido", usuario, "ok");
	}

    private void btnImprimir_Clicked(object sender, EventArgs e)
    {

    }
}