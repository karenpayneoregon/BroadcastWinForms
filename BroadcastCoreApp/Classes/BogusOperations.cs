using Bogus;
using Person = BroadcastCoreApp.Models.Person;
namespace BroadcastCoreApp.Classes;
public class BogusOperations
{
    public static List<Person> People(int count = 1)
    {
        int identifier = 1;

        Faker<Person> fakePerson = new Faker<Person>()
                .CustomInstantiator(f => new Person(identifier++))
                .RuleFor(p => p.FirstName, f => 
                    f.Person.FirstName)
                .RuleFor(p => p.LastName, f => 
                    f.Person.LastName)
                .RuleFor(p => p.BirthDate, f => 
                    f.Date.Past(10))
            ;


        return fakePerson.Generate(count);

    }
}
