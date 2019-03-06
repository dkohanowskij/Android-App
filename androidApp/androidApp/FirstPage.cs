using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using TestLib;

namespace androidApp
{
	public class FirstPage : ContentPage
	{
	  private readonly Entry _entry;
	  private readonly Label _label;

    public FirstPage ()
		{
		  _entry = new Entry();
		  _entry.Placeholder = "Enter your name";
		  _entry.TextColor = Color.Chartreuse;

		  Button btn = new Button();
		  ;
		  btn.Text = "Submit";
		  btn.FontAttributes = FontAttributes.Bold;

		  btn.Clicked += Btn_Clicked;

		  _label = new Label();
		  _label.FontSize = 27;

		  StackLayout st = new StackLayout();
		  st.Children.Add(_entry);
		  st.Children.Add(btn);
		  st.Children.Add(_label);

      Content = st;

		}

	  private void Btn_Clicked(object sender, EventArgs e)
	  {
      UserManager manager = new UserManager(_entry.Text);

	    _label.Text = manager.GetGreeting();
	  }
  }
}