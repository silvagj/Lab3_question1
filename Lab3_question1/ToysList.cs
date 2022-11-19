using Lab3_question1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_question1
{

internal class ToysList : ObservableCollection<Toys>
{
    public ToysList()
    {
        Add(new Toys("", 0)); 
        Add(new Toys("Lego", 100));
        Add(new Toys("Barbie", 112));
        Add(new Toys("LOL Doll", 57));

    }

}
}