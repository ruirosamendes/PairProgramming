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
            set { value = _prop; }
        }

        public Exercise(int prop)
        {
            this.Prop = prop;
        }
    }
}
