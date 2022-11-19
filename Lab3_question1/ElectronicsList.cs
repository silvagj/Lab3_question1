using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Lab3_question1
{
    internal class ElectronicsList : ObservableCollection<Electronics>
    {
        public ElectronicsList()
        {
            Add(new Electronics("", 0));
            Add(new Electronics("Smart Watch", 500));
            Add(new Electronics("Polaroid Go", 119));
            Add(new Electronics("Wireless Earbuds", 55));
            Add(new Electronics("Bluetooth Speaker", 45));
        }
            
    }
}
