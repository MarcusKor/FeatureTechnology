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
            string address = string.Empty;
            var addressInfo = new AddressInfo();
            var propertyInfos = PropertyAccessor.GetProperties(addressInfo);
            if (propertyInfos != null)
            {
                foreach (var property in propertyInfos)
                {
                    address += $"{property.Name}{addressInfo.TokenDelimiter}";
                }
                PropertyAccessor.AssignValues(addressInfo, address = address.Remove(address.Length - 1));
                Assert.AreEqual("ResidenceType/SiteUrl/GeographicLocation/Street1/Street2/City/State/Country", address);
            }
        }
    }
}