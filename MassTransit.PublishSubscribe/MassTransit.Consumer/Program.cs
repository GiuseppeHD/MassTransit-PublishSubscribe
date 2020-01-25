using System;
using MassTransit;

namespace MassTransit.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string rabbitUrl = "rabbitmq://localhost";
            const string username = "guest";
            const string password = "guest";
            const string queueName = "information-queue-A";
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc=>
            {
                var host = sbc.Host(new Uri(rabbitUrl), h =>
                {
                    h.Username(username);
                    h.Password(password);
                });
               
                sbc.ReceiveEndpoint( queueName, ep =>
                 {
                     ep.Consumer<MessageConsumer>();
                 });

            });

            bus.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
