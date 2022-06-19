using System;
using System.ComponentModel;

namespace CommandSample
{
    public class Counter
    {
        public int Value { get; set; } = 100;
    }

    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Counter Counter { get; set; }

        public CountDownCommand CountDownCommand { get; private set; }

        public CounterViewModel()
        {
            CountDownCommand = new CountDownCommand(this);
            Counter = new Counter();
        }

        public int Value
        {
            get
            {
                return Counter.Value;
            }
            set
            {
                Counter.Value = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
            }
        }
    }
}
