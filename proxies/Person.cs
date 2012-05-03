namespace proxies
{
    public interface IPerson
    {
        string what_is_your_name();
    }

    public class Person : IPerson
    {
        private readonly string my_name;

        public Person(string my_name)
        {
            this.my_name = my_name;
        }

        public string what_is_your_name()
        {
            return my_name;
        }
    }
}