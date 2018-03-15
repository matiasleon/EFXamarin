using System;
using System.Collections.Generic;
using EntityFrameworkTest.DataAccess;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EntityFrameworkTest.Models;

namespace EntityFrameworkTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        private readonly ItemsRepository repository;
        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };
            repository = new ItemsRepository();
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            await repository.Create(Item);
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }
    }
}