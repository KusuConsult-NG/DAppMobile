using Algorand;
using MobileAlgorandApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileAlgorandApp.Views
{
    public class AccountAddressPage : ContentPage
    {
        public AccountAddressPage()
        {
            this.Title = "Account Address Page";
            StackLayout stackLayout = new StackLayout();
            Button button = new Button();
            button.Text = "Generate Account Address";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);
            Content = stackLayout;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Account account = new Account();
            AccountClass accountClass = new AccountClass()
            {
                Address = account.Address.ToString()
            };
            await DisplayAlert("Account Address", accountClass.Address, "OK");
        }
    }
}