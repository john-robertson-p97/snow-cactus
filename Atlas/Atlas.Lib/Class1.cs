using System;

namespace Atlas.Lib
{
    public class Class1
    {
        public void Succeed() { }

        public void Fail() => throw new Exception("Test Failure");
    }
}