using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestFramework;

namespace Tests
{
    public class BaseTest
    {
        [SetUp]
        public void BaseSetUp() {
            Console.WriteLine("dsfsf");
                Console.ReadKey();

        } // Exception thrown!

        [TearDown]
        public void BaseTearDown() {  }
    }

}
