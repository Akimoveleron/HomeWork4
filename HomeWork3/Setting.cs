using System;

namespace HomeWork4
{
    internal class Setting
    {
        public IEnterableTuple Range { get; set; }

        public IEnterable NumberOfAttempt { get; set; }


        public Setting(IEnterableTuple range, IEnterable numberOfAttempt)
        {
            
            Range = range;
            NumberOfAttempt = numberOfAttempt;
        }


    }
}
