using RestWithASPNETUdemy.Model;
using System.Security.Cryptography;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplamentation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            // acesso a base e criação do mesmo 
            return person;
        }

        public void Delete(long id)
        {
            //deleta na base de acordo com o ID
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
                return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementalAndGet(),
                FirstName = "Robsson",
                LastName = "Silva",
                Address = "Curitiba - Paraná - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            // Ir até a base, faz o update e retorno a person atualizada
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementalAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastNAme" +i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementalAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
