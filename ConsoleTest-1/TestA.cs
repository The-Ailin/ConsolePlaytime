namespace ConsoleTest_1
{
    public class TestA
    {
        public TestA()
        {
        }

        public int A { get; set; }

        public static int B { get; set; }

        public void AddTenRef(ref int value)
        {
            value = value + 10;
        }

        public int AddTenValue(int value)
        {
            value = value + 10;
            return value;
        }
    }
}
