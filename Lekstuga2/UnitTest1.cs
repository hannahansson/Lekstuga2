using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
            string CanDrinkAlcohol4;
            int age = 18;

            if (age >= 18)
            {
                Assert.True(true);

                // din lösning här
            }
            else
                Assert.False(false);
        }

        //Kata1
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

        public void Count()
        {
            for (int i = 0; i < 100000; i++) ;
        }

        //Kata2
        [Fact]
        public void CallMe100_000TimesTest()
        {
            Assert.Equal(0, counterCallMe);

            for (int i = 0; i < 100000; i++)
            {
                CallMe();
            }

            Assert.Equal(100_000, counterCallMe);
        }

        int counterCallMe = 0;

        public void CallMe()
        {
            counterCallMe += 1;
        }

        // Method Kata 3
        [Fact]
        public void MethodChainTest()
        {
            Assert.Equal("", lvlOrder);

            {
                // Koppla ihop metoderna så det blir ordningen som nedan
                MethodLvl1();
                MethodLvl2();
                MethodLvl3();
                MethodLvl4();
                lvlOrder += " ";
                MethodLvl3();
                MethodLvl2();
                MethodLvl1();
            }

            Assert.Equal("lvl1 lvl2 lvl3 lvl4 lvl3 lvl2 lvl1 ", lvlOrder);
        }

        private string lvlOrder = "";

        public void MethodLvl1()
        {
            lvlOrder += "lvl1 ";
        }

        public void MethodLvl2()
        {
            lvlOrder += "lvl2 ";
        }

        public void MethodLvl3()
        {
            lvlOrder += "lvl3 ";
        }

        public void MethodLvl4()
        {
            lvlOrder += "lvl4";
        }

    // Method Kata 4
    [Fact]
    public void OändligaAnrop()
    {
    // sätt A att kalla på B och viseversa
    // och steppa och se vad som händer :D
    }
    public void MethodA()
    {
      MethodB();
    }
    public void MethodB()
    {
      MethodA();
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

            [Fact]
            public bool CanDrinkAlcohol()
            {
                int age = 0;

                if (age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            [Fact]
            public bool CanDrickAlcohol()
            {
                string nationality = "USA, Sverige";
                int drinkingAge;
                int age = 18;

                switch (nationality)
                {
                    case "USA":
                        drinkingAge = 21;
                        break;

                    case "Sverige":
                        drinkingAge = 18;
                        break;

                    default:
                        drinkingAge = 18;
                        break;
                }

                if (age >= drinkingAge)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
