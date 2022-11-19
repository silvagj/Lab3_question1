using Lab3_question1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_question1
{

internal class BooksList : ObservableCollection<Books>
{
    public BooksList()
    {
        Add(new Books("", 0));
        Add(new Books("The Duke And I", 10));
        Add(new Books("Twilight Saga", 112));
        Add(new Books("Emma", 12));
        
    }

}
}