using Models;

public class Program
{
    public static void Main(string[] args)
    {
        List<Customer> customers = FakeDataGenerator.GenerateCustomer(1);

        foreach (Customer item in customers)
        {
            Console.WriteLine($"Müşteri ID:{item.CustomerID} Ad:{item.Name} Soyad:{item.LastName} Adres:{item.Adress} Başlık:{item.Title}");

        }

        var faker = new Bogus.Faker(locale: "tr");
        Console.WriteLine(faker.Phone.PhoneNumber());

    }
}
