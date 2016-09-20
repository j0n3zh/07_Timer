using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace _07_Timer
{
    internal class Timer
    {
        private int time;
       public int Seconds { get { return time; } internal set { time = setvalue(value); } }
       
        public override string ToString()
        {
            return Padded(time / 3600) + ":" + Padded((time - (3600 * (time / 3600)))/60) + ":" + Padded(time % 60);
        }
        private int setvalue(int value)
        {

            return value;
        }

        internal string Padded(int v)
        {
            if (v < 10) return "0"+v;
            return v.ToString();
        }
    }
}