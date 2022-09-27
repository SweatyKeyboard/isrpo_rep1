public class TestClass
{
    public int SomeMethod(int x)
    {
        return System.DateTime.Now.Millisecond % x;
    }

    public int SomeMethod2(int x)
    {
        TestClass2 testClass2 = new TestClass2();
        return testClass2.SomeMehtod(x);
    }
}

internal class TestClass2
{
    internal int SomeMehtod(int x)
    {
        return - System.DateTime.Now.Millisecond % x;
    } 
}
