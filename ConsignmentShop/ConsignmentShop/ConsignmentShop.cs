using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShop
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();

        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinging = new BindingSource();
        BindingSource vendorBinding = new BindingSource();

        private decimal storeProfit = 0;


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupDate();

            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";


            cartBinging.DataSource = shoppingCartData;
            shoppingListBox.DataSource = cartBinging;

            shoppingListBox.DisplayMember = "Display";
            shoppingListBox.ValueMember = "Display";


            vendorBinding.DataSource = store.Vendors;
            vendorsListBox.DataSource = vendorBinding;

            vendorsListBox.DisplayMember = "Display";
            vendorsListBox.ValueMember = "Display";
        }

        private void SetupDate()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });
            store.Vendors.Add(new Vendor { FirstName = "Barbara", LastName = "Rose" });
            store.Vendors.Add(new Vendor { FirstName = "Margarette", LastName = "James" });
            store.Vendors.Add(new Vendor { FirstName = "Eve", LastName = "Haldy" });
            store.Vendors.Add(new Vendor { FirstName = "Bett", LastName = "Silvermoon" });
            store.Vendors.Add(new Vendor { FirstName = "Anthony", LastName = "Parker" });
            store.Vendors.Add(new Vendor { FirstName = "Gilbert", LastName = "Galway" });

            store.Items.Add(new Item
            {
                Title = "Greetings",
                Description = "A magazine about teen-stories",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "What Happens Around The World",
                Description = "A magazine about the international news",
                Price = 2.88M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 5.20M,
                Owner = store.Vendors[2]
            });

            store.Items.Add(new Item
            {
                Title = "Fire and Fury",
                Description = "A book about the inside story of the White House",
                Price = 18.00M,
                Owner = store.Vendors[3]
            });

            store.Items.Add(new Item
            {
                Title = "Little Fires Everywhere",
                Description = "A book about the Richardson Family",
                Price = 9.01M,
                Owner = store.Vendors[4]
            });

            store.Items.Add(new Item
            {
                Title = "Engine World",
                Description = "A magazine about cars",
                Price = 8.57M,
                Owner = store.Vendors[5]
            });

            store.Items.Add(new Item
            {
                Title = "Raw",
                Description = "A magazine about healthy lifestyle",
                Price = 4.33M,
                Owner = store.Vendors[6]
            });

            store.Items.Add(new Item
            {
                Title = "The Story Of My Vegan Life",
                Description = "A book about a person who chose to stop eating animal products",
                Price = 6.47M,
                Owner = store.Vendors[7]
            });

            store.Items.Add(new Item
            {
                Title = "Breathe In, Breathe Out",
                Description = "A book about practicing meditation",
                Price = 7.96M,
                Owner = store.Vendors[7]
            });
        }

        private void addToCard_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            shoppingCartData.Add(selectedItem);

            cartBinging.ResetBindings(false);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            foreach (var item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();

            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            storeProfitValue.Text = string.Format($"${storeProfit:f2}");

            cartBinging.ResetBindings(false);
            itemBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
        }
    }
}
