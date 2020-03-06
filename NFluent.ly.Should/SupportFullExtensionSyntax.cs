using NUnit.Framework;
namespace NFluent.ly.Should
{
    [TestFixture]
    public class SupportFullExtensionSyntax
    {
        [Test]
        public void WhenUsedWithInts()
        {
            var sut = 2;
            sut.Verifies().IsEqualTo(2);
        }
    }
}
