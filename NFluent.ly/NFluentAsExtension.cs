
namespace NFluent.ly
{
    public static class NFluentAsExtension
    {
        public static ICheck<T> Verifies<T>(this T sut)
        {
            return Check.That(sut);
        }
    }
}
