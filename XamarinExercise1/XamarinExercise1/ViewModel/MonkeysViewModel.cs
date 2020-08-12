using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using Xamarin.Forms;
using XamarinExercise1.Model;

namespace XamarinExercise1.ViewModel
{
    public class MonkeysViewModel : INotifyPropertyChanged
    {
        readonly IList<Monkey> source;
        Monkey selectedMonkey;
        int selectionCount = 1;

        public ObservableCollection<Monkey> Monkeys { get; private set; }
        public IList<Monkey> EmptyMonkeys { get; private set; }

        public Monkey SelectedMonkey
        {
            get
            {
                return selectedMonkey;
            }
            set
            {
                if (selectedMonkey != value)
                {
                    selectedMonkey = value;
                }
            }
        }

        ObservableCollection<object> selectedMonkeys;
        public ObservableCollection<object> SelectedMonkeys
        {
            get
            {
                return selectedMonkeys;
            }
            set
            {
                if (selectedMonkeys != value)
                {
                    selectedMonkeys = value;
                }
            }
        }

        public string SelectedMonkeyMessage { get; private set; }

        public ICommand DeleteCommand => new Command<Monkey>(RemoveMonkey);
      
        public ICommand FilterCommand => new Command<string>(FilterItems);
        public ICommand MonkeySelectionChangedCommand => new Command(MonkeySelectionChanged);

        public MonkeysViewModel()
        {
            source = new List<Monkey>();
            CreateMonkeyCollection();

            selectedMonkey = Monkeys.Skip(3).FirstOrDefault();
            MonkeySelectionChanged();

            SelectedMonkeys = new ObservableCollection<object>()
            {
                Monkeys[1], Monkeys[3], Monkeys[4]
            };
        }

        void CreateMonkeyCollection()
        {
            source.Add(new Monkey
            {
                Name = "Black",
                ImageUrl = "black.png"
            });

            source.Add(new Monkey
            {
                Name = "Blue",           
                ImageUrl = "blue.png"
            });

            source.Add(new Monkey
            {
                Name = "Brown",             
                ImageUrl = "brown.png"
            });

            source.Add(new Monkey
            {
                Name = "Green",           
                ImageUrl = "green.png"
            });

            source.Add(new Monkey
            {
                Name = "Orange",            
                ImageUrl = "orange.png"
            });

            source.Add(new Monkey
            {
                Name = "Pink",           
                ImageUrl = "pink.png"
            });

            source.Add(new Monkey
            {
                Name = "Red",             
                ImageUrl = "red.png"
            });

            source.Add(new Monkey
            {
                Name = "Violet",            
                ImageUrl = "violet.png"
            });

            source.Add(new Monkey
            {
                Name = "White",            
                ImageUrl = "white.png"
            });

            source.Add(new Monkey
            {
                Name = "Yellow",            
                ImageUrl = "yellow.png"
            });

            source.Add(new Monkey
            {
                Name = "Cyan",        
                ImageUrl = "cyan.png"
            });

            source.Add(new Monkey
            {
                Name = "Grey",           
                ImageUrl = "grey.png"
            });

          

            source.Add(new Monkey
            {
                Name = "Peach",            
                ImageUrl = "peach.png"
            });

            source.Add(new Monkey
            {
                Name = "Purple",             
                ImageUrl = "purple.png"
            });

            source.Add(new Monkey
            {
                Name = "Skyblue",              
                ImageUrl = "skyblue.png"
            });

            source.Add(new Monkey
            {
                Name = "Yellow Green",             
                ImageUrl = "yellowgreenpng.png"
            });

            Monkeys = new ObservableCollection<Monkey>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(monkey => monkey.Name.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var monkey in source)
            {
                if (!filteredItems.Contains(monkey))
                {
                    Monkeys.Remove(monkey);
                }
                else
                {
                    if (!Monkeys.Contains(monkey))
                    {
                        Monkeys.Add(monkey);
                    }
                }
            }
        }

        void MonkeySelectionChanged()
        {
            SelectedMonkeyMessage = $"Selection {selectionCount}: {SelectedMonkey.Name}";
            OnPropertyChanged("SelectedMonkeyMessage");
            selectionCount++;
        }

        void RemoveMonkey(Monkey monkey)
        {
            if (Monkeys.Contains(monkey))
            {
                Monkeys.Remove(monkey);
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
