// See https://aka.ms/new-console-template for more information
using ModernClasses.Interfaces;
using ModernClasses.Social;

string address = string.Empty;
var addressInfo = new AddressInfo();
var properties = PropertyAccessor.GetAllPropertyNames(addressInfo);
if (properties != null)
{
    foreach (var property in properties)
    {
        address += $"{property}{addressInfo.TokenDelimiter}";
    }
    PropertyAccessor.AssignValues(addressInfo, address = address.Remove(address.Length - 1));
}