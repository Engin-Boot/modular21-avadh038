using System;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    public class Test:IManual
    {
        public void Printmanual()
        {
            int pair_no = 1;
            for (int i = 0; i < ColorCodeEntity.colorMapMajor.Length; ++i)
            {
                for (int j = 0; j < ColorCodeEntity.colorMapMajor.Length; ++j)
                {
                    ColorCodeEntity.ColorPair testPair = ColorFromPairNumber.GetColorFromPairNumber(pair_no);
                    Debug.Assert(testPair.majorColor == ColorCodeEntity.colorMapMajor[i]);
                    Debug.Assert(testPair.minorColor == ColorCodeEntity.colorMapMinor[j]);

                    testPair = new ColorCodeEntity.ColorPair()
                    {
                        majorColor = ColorCodeEntity.colorMapMajor[i],
                        minorColor = ColorCodeEntity.colorMapMinor[j]
                    };
                    int pairNumberReceived = PairNumberFromColor.GetPairNumberFromColor(testPair);
                    Debug.Assert(pair_no == pairNumberReceived);

                    pair_no++;
                }
            }
        }
    }
    
}
