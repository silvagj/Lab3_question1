using Lab3_question1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_question1
{

internal class JewelryList : ObservableCollection<Jewelry>
{
    public JewelryList()
    {
        Add(new Jewelry("", 0));
        Add(new Jewelry("Watch", 250));
        Add(new Jewelry("Earrings", 154));
        Add(new Jewelry("Neckless", 100));
        Add(new Jewelry("Bracelet", 140));
    }

}
}

