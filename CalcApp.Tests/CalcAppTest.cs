namespace CalcApp.Tests
{
    public class CalcAppTest
    {

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        [InlineData(0, 4, 4)]
        public void Add_TwoIntegerParams_returnValue(int x, int y, int exp)
        {
            var decision = new Calc();
            var act = decision.Add(x, y);


            Assert.Equal(exp, act); // сравнение 
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(5, 0, 5)]

        public void Dec_TwoIntegerParams_returnValue(int x, int y, int exp)
        {
            var decision = new Calc();
            var act = decision.Dec(x, y);

            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(2, 0, 0)]

        public void Mul_TwoIntegerParams_returnValue(int x, int y, int exp)
        {
            var decision = new Calc();
            var act = decision.Mul(x, y);

            Assert.Equal(exp, act);
        }

    }
}