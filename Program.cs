namespace Repro
{
    class Program
    {
        static void Main()
        {
            new Generic<Implementation>(new Implementation());
        }
    }

    public interface IInterface { }

    struct Implementation : IInterface { }

    public sealed class Generic<T> where T : IInterface
    {
        private readonly T _implementation;

        public Generic(T implementation)
        {
            _implementation = implementation;
        }
    }
}
