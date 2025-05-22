using System.Text;
using System.Text.Json;
using RabbitMQ.Client;

namespace DropshippingAdmin.Infrastructure.Messaging.RabbitMQ
{
    public class RabbitMqPublisher
    {
        private readonly string _hostname;
        private readonly string _queueName;
        private IConnection? _connection;
        public RabbitMqPublisher(string hostname, string queueName)
        {
            _hostname = hostname;
            _queueName = queueName;
            CreateConnection();
        }
        private void CreateConnection()
        {
            var factory = new ConnectionFactory { HostName = _hostname };
            _connection = factory.CreateConnection();
        }
        public void Publish<T>(T message)
        {
            if (_connection == null) CreateConnection();
            using var channel = _connection!.CreateModel();
            channel.QueueDeclare(_queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
            channel.BasicPublish(exchange: "", routingKey: _queueName, basicProperties: null, body: body);
        }
    }
}
