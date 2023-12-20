using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace Chiriac_Roxana_Lab7;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    [Obsolete]
    private void OnButtonClicked(object sender, EventArgs e)
    {
        // Change the background color of the button when clicked
        CounterBtn.BackgroundColor = Color.FromHex("#FF00FF"); // Use the color hex code or any other color representation
    }
}


