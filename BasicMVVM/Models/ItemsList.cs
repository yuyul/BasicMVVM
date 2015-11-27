using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVVM.Models
{
    public class ItemsList: ObservableCollection<Model>
    {
        public ItemsList()
        {
        }
    }
}
