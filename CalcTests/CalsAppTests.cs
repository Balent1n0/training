namespace CalcTests
{
    public class CalsAppTests
    {
        [Fact]
        public void Sum_2and5_return7()
        {
            //arrange
            int x = 2;
            int y = 5;
            int expected = 7;

            //act
            CalcApp c = new ();
            int actual = c.Sum(x, y);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}