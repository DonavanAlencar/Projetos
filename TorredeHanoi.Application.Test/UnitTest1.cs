using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorredeHanoi.Application.Services;

namespace TorredeHanoi.Application.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = MoveCalculatorAppService.GetMoves(5, 0);
        }
    }
}
