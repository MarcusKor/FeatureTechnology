// See https://aka.ms/new-console-template for more information
using ModernClasses.Interfaces;
using ModernClasses.Social;

Console.WriteLine("Hello, World!");
var addressInfo = new AddressInfo();
var properties = addressInfo.GetAllPropertyNames<IAddressInfo.Properties>();
string address = string.Empty;
foreach (var property in properties)
{
    address += $"{property}{addressInfo.TokenDelimiter}";
}
addressInfo.AssignValues<IAddressInfo.Properties>(address = address.Remove(address.Length - 1));