using System;

namespace Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                var name = Faker.Name.FullName();
                var address = Faker.Address.StreetAddress();
                var usPassport = Faker.Identification.UsPassportNumber();
                var ssn = Faker.Identification.SocialSecurityNumber();
                var mbi = Faker.Identification.MedicareBeneficiaryIdentifier();
                Console.WriteLine($"Name: {name}, Address: {address}, Passport: {usPassport}, ssn: {ssn}, mbi: {mbi}");
                if(i == 3)
                {
                    break;
                }
                i++;
            }
        }
    }
}
