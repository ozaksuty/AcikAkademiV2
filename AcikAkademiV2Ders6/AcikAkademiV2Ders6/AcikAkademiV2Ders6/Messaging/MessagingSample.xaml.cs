using AcikAkademiV2Ders6.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AcikAkademiV2Ders6.Messaging
{
    public partial class MessagingSample : ContentPage
    {
        IList<Person> model = new ObservableCollection<Person>();
        ListView lstPerson;
        public MessagingSample()
        {
            InitializeComponent();
            this.Padding = new Thickness(0, 
                Device.OnPlatform(20, 0, 0), 0, 0);

            #region ListView
            lstPerson = new ListView();
            lstPerson.ItemTemplate =
                new DataTemplate(typeof(PersonViewCell));
            lstPerson.ItemsSource = model;
            #endregion

            #region Form
            EntryCell txtName = new EntryCell
            {
                Label = "Name"
            };
            EntryCell txtSurname = new EntryCell
            {
                Label = "Surname"
            };
            Button btnSend = new Button
            {
                Text = "Send"
            };
            TableView tView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Form") {
                    new TableSection () {
                        txtName, txtSurname
                    }
                }
            };
            #endregion

            #region Buttons
            Button btnSubscribe = new Button
            {
                Text = "Subscribe"
            };

            Button btnUnSubscribe = new Button
            {
                Text = "UnSubscribe"
            };
            #endregion

            #region Events
            btnSend.Clicked += (s, e) =>
            {
                //MessagingCenter.Send<MessagingSample>(this, "xamarin");
                MessagingCenter.Send<MessagingSample, Person>(this,
                    "person", new Person
                    {
                        Id = 0,
                        Name = txtName.Text,
                        Surname = txtSurname.Text
                    });
            };
            btnSubscribe.Clicked += (s, e) =>
            {
                //MessagingCenter.Subscribe<MessagingSample>(
                //    this, "xamarin", (o) =>
                //    {
                //        DisplayAlert("MessagingCenter", "Xamarin", "Ok");
                //    });

                MessagingCenter.Subscribe<MessagingSample, Person>(
                    this, "person", (page, person) =>
                    {
                        model.Add(person);
                    });
            };
            btnUnSubscribe.Clicked += (s, e) =>
            {
                //MessagingCenter.Unsubscribe<MessagingSample>(this, "xamarin");
                MessagingCenter.Unsubscribe<MessagingSample, Person>(this, "person");
            };
            #endregion

            StackLayout layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Children = {
                            btnSubscribe,
                            btnUnSubscribe,
                            btnSend
                        }
                    },
                    tView,
                    lstPerson
                }
            };

            Content = layout;
        }
    }
}