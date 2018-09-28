using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAndroidApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		void OnButtonClickedSomma(object sender, EventArgs args)
		{
			
			int a = Convert.ToInt32(txtNum1.Text);
			int b = Convert.ToInt32(txtNum2.Text);
			int Risultato = a + b;
			lblRisultato.Text = Risultato.ToString();
		}
		void OnButtonClickedSottrazione(object sender, EventArgs args)
		{
			
			int a = Convert.ToInt32(txtNum1.Text);
			int b = Convert.ToInt32(txtNum2.Text);
			int Risultato = a - b;
			lblRisultato.Text = Risultato.ToString();
		}
		void OnButtonClickedMoltiplicazione(object sender, EventArgs args)
		{
			
			int a = Convert.ToInt32(txtNum1.Text);
			int b = Convert.ToInt32(txtNum2.Text);
			int Risultato = a * b;
			lblRisultato.Text = Risultato.ToString();
		}
		void OnButtonClickedDivisione(object sender, EventArgs args)
		{
			
			int a = Convert.ToInt32(txtNum1.Text);
			int b = Convert.ToInt32(txtNum2.Text);
			try
			{
				double Risultato = a / b;
				lblRisultato.Text = Risultato.ToString();
			}
			catch(Exception e)
			{
				lblRisultato.Text = "Errore";
			}	
		}
		void OnButtonClickedQuadra(object sender, EventArgs args)
		{

			int a = Convert.ToInt32(txtElv.Text);
			double Risultato=Math.Sqrt(a);
			lblPotenza.Text = Risultato.ToString(); 
		}
		void OnButtonClickedPotenza(object sender, EventArgs args)
		{

			int a = Convert.ToInt32(txtElv.Text);
			double Risultato = Math.Pow(a, 2);
			lblPotenza.Text = Risultato.ToString();
		}
	}
}
