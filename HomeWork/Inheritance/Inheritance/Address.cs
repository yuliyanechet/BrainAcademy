namespace Inheritance
{
    class Address
    {
        string Country;
        string City;
        string Street;
        int House,Flat;

        public Address(string country, string city, string street, int house, int flat)
        {
            Country = country;
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }
    }
}