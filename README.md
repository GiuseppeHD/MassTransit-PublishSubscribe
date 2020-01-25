# Simple MassTransit project using Publish/Subscribe approach.
## Requirements:
1) RabbitMQ (download link: https://www.rabbitmq.com/download.html) installed on local machine.
2) .NetCore (V3.1)
3) Visual Studio 2019.

## Instructions
1) Be sure to have rabbitmq running.
1) Open MassTransit.PublishSubscribe.sln with Visual Studio
2) Right click on "MassTransit.Consumer.A" project > Debug > "Start new instance"
3) Right click on "MassTransit.Consumer.B" project > Debug > "Start new instance"
4) Right click on "MassTransit.Producer" project > Debug > "Start new instance"

At this point you should be able to see the Message created from the Producer in the console application of Consumer.A and Consumer.B.

This is a simple example of how publish and subscribe approach works with MassTransit. :)
