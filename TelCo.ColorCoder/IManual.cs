using System;
using System.Collections.Generic;
using System.Text;
namespace TelCo.ColorCoder
{
    
    public interface IManual
    {
        public void Printmanual();
    }

    class Manual
    {
        public Manual(IManual Manual)
        {
            Manual.Printmanual();
        }

    }
}

