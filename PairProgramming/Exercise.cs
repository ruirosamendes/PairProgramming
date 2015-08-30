using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
    public class Exercise
    {
        private int _prop;

        public int Prop
        {
            get { return _prop; }
            set { _prop = value; }
        }

        public Exercise(int prop)
        {
            this._prop = prop;
        }
    }
}
