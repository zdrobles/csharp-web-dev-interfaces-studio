using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    internal interface IOpticalDisc
    {
        void SpinDisc();
        //bool StoreData();
        void DisplayInfo();
        void Play();
    }
}
