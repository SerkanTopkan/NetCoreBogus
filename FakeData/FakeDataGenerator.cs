
namespace Models;
public static class FakeDataGenerator
{
    public static List<Customer> GenerateCustomer(int count)
    {

        var list = new Bogus.Faker<Customer>(locale: "tr")
                        .RuleFor(customer => customer.CustomerID, x => x.IndexFaker)
                            .RuleFor(customer => customer.Name, x => x.Name.FirstName())
                            .RuleFor(customer => customer.LastName, x => x.Name.LastName())
                            .RuleFor(customer => customer.Title, x => x.Name.JobTitle())
                            .RuleFor(customer => customer.Adress, x => x.Address.FullAddress())
                        .Generate(count);



        return list;
    }
}