using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for AddItemControl.xaml
    /// </summary>
    public partial class AddItemControl : UserControl
    {
        public AddItemControl()
        {
            InitializeComponent();
            AddItemBtn.Click += OnAddItemBtnClick;
        }

        protected void OnAddItemBtnClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is ShoppingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }
}
