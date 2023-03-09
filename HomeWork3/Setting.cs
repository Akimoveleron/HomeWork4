using System;

namespace HomeWork4
{
    internal class Setting
    {
        public IEnterable <(int,int)> Range { get; set; }

        public IEnterable<int> NumberOfAttempt { get; set; }


        public Setting(IEnterable<(int, int)> range, IEnterable<int> numberOfAttempt)
        {
            
            Range = range;
            NumberOfAttempt = numberOfAttempt;
        }


    }
}
