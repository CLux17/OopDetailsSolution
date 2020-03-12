using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OopDetails
{
    public class Properties
    {
        [Fact]
        public void OldSkool()
        {
            var bob = new Person();
            bob.Name = "Robert";
            Assert.Equal("Robert", bob.Name);
            Assert.Equal(1000M, bob.CreditLimit);


            bob.IncreaseCreditLimit(500);
            Assert.Equal(1500M, bob.CreditLimit);

        }
    }
}
