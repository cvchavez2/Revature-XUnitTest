using System;
using Xunit;
using XUnitTest.Client;

namespace XUnitTest.Testing.Tests
{
    public class TestClient
    {
        [Fact]
        public void Test1()
        {
          var sut = new TestMe();
          int a = 10;
          int b = 5;

          Assert.Equal(15, sut.Add(a,b));
        }
    }
}