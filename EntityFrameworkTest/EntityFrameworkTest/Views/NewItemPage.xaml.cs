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

        public IList<SubItem> Subitems { get; set; }

        private readonly ItemsRepository repository;
        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };
            var subitem = new SubItem(){Description = "mediocampista", Name = "Enzo Perez"};
            var subitem2 = new SubItem() { Description = "mediocampista", Name = "Leo Ponzio" };
            Subitems.Add(subitem);
            Subitems.Add(subitem2);
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