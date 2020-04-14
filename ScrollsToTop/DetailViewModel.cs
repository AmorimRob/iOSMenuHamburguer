using System.Collections.ObjectModel;
using MvvmHelpers;

namespace ScrollsToTop
{
    public class DetailViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Itens { get; set; }

        public DetailViewModel()
        {
            Itens = new ObservableCollection<Item>();

            for (int i = 0; i < 200; i++)
            {
                Itens.Add(new Item { Nome = $"Item - {i}" });
            }
        }
    }

    public class Item
    {
        public string Nome { get; set; }
    }
}
