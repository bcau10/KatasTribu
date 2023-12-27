using ApplicationTestPourCommandesDeRelais.Model;
using ApplicationTestPourCommandesDeRelais.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTestPourCommandesDeRelais.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem()); // look like lambda expression
        //public RelayCommand DeleteCommand => new RelayCommand(execute => , canExecute => { return true; });
        public RelayCommand SaveCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "Product1",
                SerialNumber = "0001",
                Quantity = 5
            });
            Items.Add(new Item
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 5
            });
        }
        //we need a property change
        private Item selectedItem;

        public Item SelectedItem
        {
            get { return (selectedItem); }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }
        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "Product1",
                SerialNumber = "0001",
                Quantity = 5
            });
        }
        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }
        private void Save()
        {
            //save to file/db
        }
        private bool CanSave()
        {
            return (true);
        }
    }
}
