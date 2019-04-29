using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Model
{
    public class ViewItemModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }

        public ViewItemModel(long id, string name, bool selected)
        {
            Id = id;
            Name = name;
            Selected = selected;
        }
    }
}
