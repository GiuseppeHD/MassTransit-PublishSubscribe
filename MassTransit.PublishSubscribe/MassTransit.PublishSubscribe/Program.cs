
using MassTransit.Messages;
using System;
using System.Threading.Tasks;

namespace MassTransit.Producer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string rabbitUrl = "rabbitmq://localhost";
            const string username = "guest";
            const string password = "guest";

            //const string queueName = "/information-queue";

            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri(rabbitUrl), h =>
                {
                    h.Username(username);
                    h.Password(password);
                });

            });

            bus.Start();
            
            const int messageId = 1;
            const string messageContent = "This is a message from Producer";
            DateTime date = DateTime.Today;
            
            var message = new Message(messageId, messageContent, date);


            await bus.Publish(new Message(messageId, messageContent, date));
     
            Console.WriteLine("Press any key for exit");
            Console.ReadLine();

            bus.Stop();

        }
    }
}
