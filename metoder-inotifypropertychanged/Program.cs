using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace metoder_inotifypropertychanged
{
    class Program
    {
        static void Main(string[] args)
        {
PropertyChangedEventHandler c = (s,e) => Console.WriteLine($"{e.PropertyName} ændret");

// Bemærk... ingen hændelser ved init
Person p1 = new Person() { Alder = 12, Navn = "z" };
p1.PropertyChanged += c;

// måske bedre at fjerne default constructor?
Person p2 = new Person("a", 10, c);
p2.Navn = "a";
        }
    }

    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string navn;
        private int alder;

        public int Alder
        {
            get { return alder; }
            set
            {
                alder = value;
                OnPropertyChanged();
            }
        }


        public string Navn
        {
            get { return navn; }
            set
            {
                navn = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string callerMemberName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerMemberName));
        }

        public Person()
        {

        }

        public Person(string navn, int alder, PropertyChangedEventHandler notify)
        {
            this.PropertyChanged += notify;
            this.Navn = navn;
            this.Alder = alder;
        }
    }
}
