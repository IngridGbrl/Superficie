namespace Superficie;
/// <summary>
/// <Createdate>28/06/2023</Createdate>
/// <Company>SANDBOX</Company>
/// <Lastmodificationdate>28/06/2023</Lastmodificationdate>
/// <lastmodificationsdescription>se implemento la formula correcta para calcular la superfifice
/// </lastmodificationsdescription>
/// <Lastmodificationautor>Ingrid Gabriel</Lastmodificationautor>
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// en el boton se calculará la superficie del triangulo conociendo su base y altura
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(h.Text) || (!string.IsNullOrEmpty(b.Text))) 
		{
            double altura, bas, superfic;

			altura= Convert.ToDouble(h.Text);
			bas = Convert.ToDouble(b.Text);

			superfic = (bas * altura)/2;

			superficie.Text = superfic.ToString();
        }
		else
		{
			DisplayAlert("ERROR", "Ocurrio un error al introducir datos", "OK");
		}
		

    }
}

