﻿using System;

namespace Reflection
{
    public class TestClass : IComparable
    {
        public TestClass() { }
        public TestClass(int i) { }
        public TestClass(string str, int i) { }

        public int Multiply(int x, int y) { return x * y; }
        public int Divide(int x, int y) { return x / y; }

        [TestAttribute("Описание для property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;

        public int property2 { get; set; }

        [TestAttribute(Description = "Описание для property3")]
        public double property3 { get; private set; }

        public int field1;
        public string field2;

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
