using MassTransit.Messages;
using System;
using System.Threading.Tasks;

namespace MassTransit.Consumer.B
{
    public class MessageConsumer : IConsumer<Message>
    {
        public async Task Consume(ConsumeContext<Message> context)
        {
            await Console.Out.WriteLineAsync("Consumer B:");
            await Console.Out.WriteLineAsync($"New message: {context.Message.Id} ");
            await Console.Out.WriteLineAsync($"New message: {context.Message.Content} ");
            await Console.Out.WriteLineAsync($"New message: {context.Message.Date.ToString()} ");
        }
    }
}