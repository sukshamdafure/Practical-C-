using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare("hello", false, false, false);

var body = Encoding.UTF8.GetBytes("Hello RabbitMQ");
channel.BasicPublish("", "hello", null, body);

Console.WriteLine("Message Sent");