using ModernClasses.Interfaces;
using ModernClasses.Social;

namespace ModernClassesTest
{
    [TestClass]
    public class PropertyAccessorTest
    {
        [TestMethod]
        public void TestAssignValues()
        {
            var addressInfo = new AddressInfo();
            var properties = addressInfo.GetAllPropertyNames<IAddressInfo.Properties>();
            string address = string.Empty;
            foreach (var property in properties)
            {
                address += $"{property}{addressInfo.TokenDelimiter}";
            }
            addressInfo.AssignValues<IAddressInfo.Properties>(address = address.Remove(address.Length - 1));
            Assert.AreEqual("ResidenceType/SiteUrl/GeographicLocation/Street1/Street2/City/State/Country", address);
        }
    }
}