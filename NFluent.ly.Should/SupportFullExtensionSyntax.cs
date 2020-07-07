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
            "Nfluent".Verifies().IsEqualIgnoringCase("NFluent");
        }

        [Test]
        public void WhenUsedWithStructs()
        {
            var sut = Season.Spring;
        }
        
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
    }
}
