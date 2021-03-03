using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace appDataGrid
{
    public class ViewModel : Observable
    {

        private string textBlockStatus;
        public string TextBlockStatus
        {
            get => textBlockStatus;
            set => Set(ref textBlockStatus, value);
        }

        private object _selectedItem;
        public object SelectedItem
        {
            get => _selectedItem;
            set => Set(ref _selectedItem, value);
        }

        private int dataTableSelectedIndex;
        public int DataTableSelectedIndex
        {
            get => dataTableSelectedIndex;
            set => Set(ref dataTableSelectedIndex, value);
        }

        public class ItemData : Observable
        {
            public int Data1 { get; set; }
            public int Data2 { get; set; }
            public int Data3 { get; set; }
            public int Data4 { get; set; }
            public int Data5 { get; set; }

            public string status;
            public string Status
            {
                get => status;
                set => Set(ref status, value);
            }
        }

        public static IEnumerable<ItemData> Allmsg()
        {
            return new List<ItemData>()
                {
                    new ItemData()
                    {
                        Data1 = 11,
                        Data2 = 12,
                        Data3 = 13,
                        Data4 = 14,
                        Data5 = 15,
                        Status = "I"
                    },
                    new ItemData()
                    {
                        Data1 = 21,
                        Data2 = 22,
                        Data3 = 23,
                        Data4 = 24,
                        Data5 = 25,
                        Status = "S"
                    },
                    new ItemData()
                    {
                        Data1 = 31,
                        Data2 = 32,
                        Data3 = 33,
                        Data4 = 34,
                        Data5 = 35,
                        Status = "R"
                    },
                    new ItemData()
                    {
                        Data1 = 41,
                        Data2 = 42,
                        Data3 = 43,
                        Data4 = 44,
                        Data5 = 45,
                        Status = "N"
                    },
                    new ItemData()
                    {
                        Data1 = 51,
                        Data2 = 52,
                        Data3 = 53,
                        Data4 = 54,
                        Data5 = 55,
                        Status = "I"
                    }
                  };
        }

        public ObservableCollection<ItemData> Source { get; set; } = new ObservableCollection<ItemData>();

        public static async Task<IEnumerable<ItemData>> GetGridDataAsync()
        {
            await Task.CompletedTask;
            return Allmsg();
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();
            var data = await GetGridDataAsync();
            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
