using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appnicole
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValgusFoor2 : ContentPage
	{
		Label Red, Yellow, Green;
		Frame pun, kol, gre;
		Button sisse, off;
		bool sisse_valja;
		public ValgusFoor2()
		{
			//InitializeComponent();
			sisse_valja = false;
			Red = new Label()
			{
				Text = "red",
				TextColor = Color.Black,
				FontSize = 30,
				FontAttributes = FontAttributes.Bold
			};
			pun = new Frame()
			{
				BackgroundColor = Color.Red,
				Content = Red,
				CornerRadius = 110,
				Margin = new Thickness(80, 0, 80, 0)
			};
			Yellow = new Label()
			{
				Text = "yellow",
				TextColor = Color.Black,
				FontSize = 30,
				FontAttributes = FontAttributes.Bold
			};
			kol = new Frame()
			{
				BackgroundColor = Color.Yellow,
				Content = Yellow,
				CornerRadius = 110,
				Margin = new Thickness(80, 0, 80, 0)
			};
			Green = new Label()
			{
				Text = "green",
				TextColor = Color.Black,
				FontSize = 30,
				FontAttributes = FontAttributes.Bold
			};
			gre = new Frame()
			{
				BackgroundColor = Color.Green,
				Content = Green,
				CornerRadius = 110,
				Margin = new Thickness(80, 0, 80, 0)
			};
			
			sisse = new Button()
			{
				Text = "Sisse",
				BackgroundColor = Color.FromRgb(200, 100, 45),
				BorderColor = Color.FromRgb(50, 150, 200)
				
			};

			off = new Button()
			{
				Text = "Off",
				BackgroundColor = Color.FromRgb(200, 100, 45),
				BorderColor = Color.FromRgb(50, 150, 200)
			};
			


			StackLayout stackLayout1 = new StackLayout()
			{
				Children = { sisse, off}
			};
			stackLayout1.Orientation = StackOrientation.Horizontal;
			StackLayout stackLayout = new StackLayout()
			{
				Children = { pun, kol, gre }
			};
			stackLayout.Orientation = StackOrientation.Vertical;
			StackLayout stack = new StackLayout()
			{
				Children = {stackLayout1, stackLayout}
			};
			Content = stack;
				
			
			

			sisse.Clicked += Sisse_Clicked;
			off.Clicked += Off_Clicked;
			
			

			var tap = new TapGestureRecognizer();
			tap.Tapped += Tap_Tapped; ;
			pun.GestureRecognizers.Add(tap);
			kol.GestureRecognizers.Add(tap);
			gre.GestureRecognizers.Add(tap);


			//stackLayout.Orientation = StackOrientation.Vertical;
			//sisse.Clicked += Sisse_Clicked;
			

			

		}
		private async void Sisse_Clicked(object sender, EventArgs e)
		{
			pun.BackgroundColor = Color.Red;
			pun.BorderColor = Color.WhiteSmoke;
			kol.BackgroundColor = Color.Yellow;
			kol.BorderColor = Color.WhiteSmoke;
			gre.BackgroundColor = Color.Green;
			gre.BorderColor = Color.WhiteSmoke;

			/*sisse_valja = false;
			for (int i = 0; i <100; i++)
			{
				Red.FontSize++;
				await Task.Run(() => Thread.Sleep(1000));
			}*/
			
		}

		private void Off_Clicked(object sender, EventArgs e)
		{
			pun.BackgroundColor = Color.Gray;
			kol.BackgroundColor = Color.Gray;
			gre.BackgroundColor = Color.Gray;
			pun.BorderColor = Color.WhiteSmoke;
			kol.BorderColor = Color.WhiteSmoke;
			gre.BorderColor = Color.WhiteSmoke;

			sisse_valja = true;
		
		}

		private void Tap_Tapped(object sender, EventArgs e)
		{
			Frame fr = sender as Frame;
			if (fr == pun)
			{
				Red.Text = "Стой";
			}
			else if (fr == kol)
			{
				Yellow.Text = "включи светофор";
	
			}
			else if (fr == gre)
			{
				Green.Text = "Вперед";
			}
		}
	}
	}
