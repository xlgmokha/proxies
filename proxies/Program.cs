using System;

namespace proxies
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var marshal_mathers = new Person("marshall mathers");
            var some_celebrity = ProxyFactory.Create<IPerson>(marshal_mathers, new MyNameIsSlimShadyInterceptor());

            try
            {
                var name = some_celebrity.what_is_your_name();
                name.should_be_equal_to("slim shady");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e);
            }
            Console.Out.WriteLine("will the real slim shady please stand up...");
            Console.In.ReadLine();
        }
    }
}