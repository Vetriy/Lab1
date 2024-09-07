using System;
using Xunit;
using Lab1;



namespace Lab1.Tests{
    public class UnitTest1
    {
        [Fact]
        public void Plus_7d9_and_8d4_result_25d9()
        {   
            //arrange
            NumFraction chislo1 = new NumFraction(7, 9);
            NumFraction chislo2 = new NumFraction(8, 4);
            NumFraction resu = new NumFraction(25, 9);
            //act
            NumFraction result = chislo1 + chislo2;
            //assert
            Assert.Equal(resu, result);
        }
        [Fact]
        public void Minus_15d155_and_78d23_result_m2349d713(){
            //arrange
            NumFraction chislo1 = new NumFraction(15, 155);
            NumFraction chislo2 = new NumFraction(78, 23);
            NumFraction resu = new NumFraction(2349, -713);
            //act
            NumFraction result = chislo1 - chislo2;
            //assert
            Assert.Equal(resu, result);
        }
        [Fact]
        public void Umn_8d9_and_4d4_result_8d9(){
            //arrange
            NumFraction chislo1 = new NumFraction(8, 9);
            NumFraction chislo2 = new NumFraction(4, 4);
            NumFraction resu = new NumFraction(8, 9);
            //act
            NumFraction result = chislo1 * chislo2;
            //assert
            Assert.Equal(resu, result);
        }
        [Fact]
        public void Del_63d7_and_8d15_result_135d8(){
            //arrange
            NumFraction chislo1 = new NumFraction(63, 7);
            NumFraction chislo2 = new NumFraction(8, 15);
            NumFraction resu = new NumFraction(135, 8);
            //act
            NumFraction result = chislo1 / chislo2;
            //assert
            Assert.Equal(resu, result);
        }
        [Fact]
        public void MinusUnarn_4d5_and_m_result_m4d5(){
            //arrange
            NumFraction chislo1 = new NumFraction(4, 5);
            NumFraction resu = new NumFraction(-4, 5);
            //act
            NumFraction result = -chislo1;
            //assert
            Assert.Equal(resu, result);
        }
        [Fact]
        public void Ravn_7d9_and_7d9_result_true(){
            //arrange
            NumFraction chislo1 = new NumFraction(7, 9);
            NumFraction chislo2 = new NumFraction(7, 9);
            NumFraction chislo3 = new NumFraction(7, 90);
            bool resu = true;
            bool resu2 = false;
            //act
            bool result = chislo1 == chislo2;
            bool result2 = chislo1 == chislo3;
            //assert
            Assert.Equal(resu, result);
            Assert.Equal(resu2, result2);
        }
        [Fact]
        public void NRavn_7d9_and_m7d9_result_true(){
            //arrange
            NumFraction chislo1 = new NumFraction(7, 9);
            NumFraction chislo2 = new NumFraction(-7, 9);
            NumFraction chislo3 = new NumFraction(7, 9);
            bool resu = true;
            bool resu2 = false;
            //act
            bool result = chislo1 != chislo2;
            bool result2 = chislo1 != chislo3;
            //assert
            Assert.Equal(resu, result);
            Assert.Equal(resu2, result2);
        }
        [Fact]
        public void Menishe_m7d9_and_9d9_result_true(){
            //arrange
            NumFraction chislo1 = new NumFraction(7, -9);
            NumFraction chislo2 = new NumFraction(9, 9);
            NumFraction chislo3 = new NumFraction(9, 9);
            bool resu = true;
            bool resu2 = false;
            //act
            bool result = chislo1 < chislo2;
            bool result2 = chislo2 < chislo1;
            bool result3 = chislo3 < chislo2;
            //assert
            Assert.Equal(resu, result);
            Assert.Equal(resu2, result2);
            Assert.Equal(resu2, result3);
        }
        [Fact]
        public void MenRavn_7d9_and_7d9_result_true(){
            //arrange
            NumFraction chislo1 = new NumFraction(8, 9);
            NumFraction chislo2 = new NumFraction(7, 9);
            NumFraction chislo3 = new NumFraction(7,9);
            bool resu = true;
            bool resu2 = false;
            //act
            bool result = chislo1 <= chislo2;
            bool result2 = chislo2 <= chislo1;
            bool result3 = chislo2 <= chislo3;
            //assert
            Assert.Equal(resu2, result);
            Assert.Equal(resu, result2);
            Assert.Equal(resu, result3);
        }
        [Fact]
        public void Bolshe_8d9_and_7d9_result_true(){
            //arrange
            NumFraction chislo1 = new NumFraction(8, 9);
            NumFraction chislo2 = new NumFraction(7, 9);
            NumFraction chislo3 = new NumFraction(7,9);
            bool resu = true;
            bool resu2 = false;
            //act
            bool result = chislo1 > chislo2;
            bool result2 = chislo2 > chislo1;
            bool result3 = chislo2 > chislo3;
            //assert
            Assert.Equal(resu, result);
            Assert.Equal(resu2, result2);
            Assert.Equal(resu2, result3);
        }
        [Fact]
        public void BolRavn_10d9_and_7d9_result_true(){
            //arrange
            NumFraction chislo1 = new NumFraction(10, 9);
            NumFraction chislo2 = new NumFraction(7, 9);
            NumFraction chislo3 = new NumFraction(7, 9);
            bool resu = true;
            bool resu2 = false;
            //act
            bool result = chislo1 >= chislo2;
            bool result2 = chislo2 >= chislo3;
            bool result3 = chislo2 >= chislo1;
            //assert
            Assert.Equal(resu, result);
            Assert.Equal(resu, result2);
            Assert.Equal(resu2, result3);
        }
    }
}