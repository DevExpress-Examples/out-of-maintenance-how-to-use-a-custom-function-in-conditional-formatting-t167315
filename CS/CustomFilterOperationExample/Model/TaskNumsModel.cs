using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterOperationExample
{
    class TaskNums
    {
        private ObservableCollection<Task> _List;

        public ObservableCollection<Task> List
        {
            get
            {
                if (_List == null)
                {
                    _List = new ObservableCollection<Task>();
                    for (int i = 1; i < 20; i++)
                    {
                        if (i == 5)
                        {
                            _List.Add(new Task() { FirstNum = 10, SecondNum = 5, TherdNum = 2 });
                        }
                        else
                        {
                            _List.Add(new Task() { FirstNum = i * 1, SecondNum = i * 2, TherdNum = i * 3 });
                        }
                    }
                }
                return _List;
            }
        }

        public class Task
        {
            public int FirstNum { get; set; }
            public int SecondNum { get; set; }
            public int TherdNum { get; set; }
        }
    }
}
