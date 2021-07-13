using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class ManualPrinting
    {
        
        public static void manual()
        {

           int pno = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: major{1} - minor{2}\n", pno, Entity.colorMapMajor[i], Entity.colorMapMinor[j]);
                    pno++;
                }
            }

        }

    }
}