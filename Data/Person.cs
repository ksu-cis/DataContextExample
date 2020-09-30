using System;
using System.ComponentModel;

namespace Data
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string first = "";
        public string First
        {
            get => first;
            set
            {
                first = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("First"));
            }
        }

        private string last = "";
        public string Last
        {
            get => last;
            set
            {
                last = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Last"));
            }
        }

        private bool fictional;
        public bool Fictional
        {
            get => fictional;
            set
            {
                fictional = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fictional"));
            }
        }

        private Fruits favoriteFruit;
        public Fruits FavoriteFruit
        {
            get => favoriteFruit;
            set
            {
                favoriteFruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FavoriteFruit"));
            }
        }
    }
}
