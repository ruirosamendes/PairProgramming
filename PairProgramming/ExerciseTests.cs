using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
    [TestFixture]
    public class ExerciseTests
    {


        [Test]
        public void Test1()
        {
            Exercise exercise = new Exercise(1);
            Assert.AreEqual(1, exercise.Prop);
        }
    }

    

}
