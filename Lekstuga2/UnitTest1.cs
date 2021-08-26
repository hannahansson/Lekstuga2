using System;
using System.Reflection.Metadata;
using Xunit;
using Xunit.Sdk;

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
        public void Age()
        {
            string CanDrinkAlcohol;
            int age = 18;

            if (age > 18)
            {
                Assert.True(true);

                // din lösning här
            }
            else
                Assert.False(false);
        }

        [Fact]
        public void TestIntToChar()
        {
            char testCh = IntToChar(siffra: 65);
            Assert.Equal(expected: 'A', actual: testCh);

            testCh = IntToChar(siffra: 122);
            Assert.Equal(expected: 'z', actual: testCh);
        }

        public char IntToChar(int siffra)
        {
            char ch = (char) siffra;

            return ch;
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

     namespace tester 
     {

         public class KataSumOfPositive
         {
             public static int PositiveSum(int[] arr)
             {
                 int sum = 0;
                 foreach (int i in arr)
                 {
                     if (i > 0)
                     {
                         sum += i;
                     }
                 }

                 return sum;
             }

             [Fact]
            public void Katas1()
            {
                int sum = KataSumOfPositive.PositiveSum(arr: new int[] {1, 2, 3, 4, 5});

                Assert.Equal(expected: 15, actual: sum);
            }
        }
    }


