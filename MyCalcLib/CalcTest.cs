using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Xunit;

namespace MyCalcLib
{
    public class CalcTest
    {
        [Fact]
        public void Sum_10and20_30return()
        {
            //arrenge
            int expsected = 30;

            //act
            int actual = Calc.Sum(10,20);

            //assert
            Assert.Equal(expsected, actual);
        }
    }
}
