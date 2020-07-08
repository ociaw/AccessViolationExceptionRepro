class Program
{
    static void Main()
    {
        Class.Generic(new Implementation());
    }
}
public static class Class
{
    public static void Generic<T>(T implementation) where T : IInterface { }
}

public interface IInterface { }

struct Implementation : IInterface { }
