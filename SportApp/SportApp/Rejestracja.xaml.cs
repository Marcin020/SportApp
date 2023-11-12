using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SportApp.Tables;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rejestracja : ContentPage
    {
        public Rejestracja()
        {
            InitializeComponent();
        }
        void Button_Clicked_Sign_Up(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserMobile.Text,
                Age = EntryUserAge.Text,
                Height = EntryUserHeight.Text,
                Weight = EntryUserWeight.Text

            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations", "Your account has been created", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new LoginUI());
            }
            );
        }
    }
}