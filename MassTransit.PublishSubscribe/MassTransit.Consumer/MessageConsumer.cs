using System;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using MassTransit.Messages;

namespace MassTransit.Consumer
{
    public class MessageConsumer : IConsumer<Message>
    {
        public async Task Consume(ConsumeContext<Message> context)
        {
            await Console.Out.WriteLineAsync("Consumer A:");
            await Console.Out.WriteLineAsync($"New message: {context.Message.Id} ");
            await Console.Out.WriteLineAsync($"New message: {context.Message.Content} ");
            await Console.Out.WriteLineAsync($"New message: {context.Message.Date.ToString()} ");
      
        }
    }
}