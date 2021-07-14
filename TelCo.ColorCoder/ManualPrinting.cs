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
           int majSize = ColorCodeEntity.colorMapMajor.Length;
           int minSize = ColorCodeEntity.colorMapMajor.Length;
            for (int i = 0; i < majSize; i++)
            {
                for (int j = 0; j < minSize; j++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: major{1} - minor{2}\n", pno, ColorCodeEntity.colorMapMajor[i], ColorCodeEntity.colorMapMinor[j]);
                    pno++;
                }
            }

        }

    }
}