using System;
using Xunit;

namespace Lekstuga2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(expected: 5, actual: 2 + 3);

        }

        [Fact]
        public void Test2()
        {
            Assert.True("Jag har fyllt " + 29 == "Jag har fyllt 29");
        }

        [Fact]
        public void Test3()
        {
            int bigNumber = 2147483647;
            int biggerNumber = bigNumber + 1;
            Assert.True(biggerNumber > bigNumber);
        }

        [Fact]
        public void Test4()
        {
            string purchasedDrink;
            int age = 28;

            if (age > 18)
            {
                purchasedDrink = "Beer";
            }
            else
            {
                purchasedDrink = "Coca-cola";
            }
            Assert.Equal(expected: "Beer", actual: purchasedDrink);
        }

           [Fact]
            public void AnotherTest()
            {
                Assert.True(true);
                Assert.Equal(expected: 5, 5);
                Assert.False(false);
            }

            [Fact]
            public void VariableTest()
            {
                string name = "Hanna";

                Assert.Equal(expected: "Hanna", actual: name);
            }


    }
    }

