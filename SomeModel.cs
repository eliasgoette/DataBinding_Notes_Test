using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_Notes_Test
{
    public class SomeModel
    {
        public string SomeTextProperty {  get; set; }

        public void ClearText()
        {
            SomeTextProperty = String.Empty;
        }
    }
}
