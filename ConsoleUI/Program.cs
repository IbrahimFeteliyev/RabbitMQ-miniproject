using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new();
factory.Uri = new Uri("amqps://yulrlmkg:qdEPMO0exfSq7X_8PyjVWM5ltitUVXd2@cow.rmq2.cloudamqp.com/yulrlmkg");

using (IConnection connection = factory.CreateConnection())
using (IModel model = connection.CreateModel())
{
    model.QueueDeclare("email-confitmation-sender", false, false, true);
    byte[] message = Encoding.UTF8.GetBytes("Orxan@compar.az");
    model.BasicPublish(exchange: "", routingKey: "email-confirmation-sender", body: message);
}