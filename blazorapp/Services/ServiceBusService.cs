namespace BlazorApp.Services;
using Azure.Messaging.ServiceBus;
using BlazorApp.Models;

public class ServiceBusService
{
  private readonly IConfiguration configuration;
  private string connStringServiceBus = "";
  private string queueName = "";
  ServiceBusClient client;
  ServiceBusSender sender;

  public ServiceBusService(IConfiguration configuration)
  {
    this.configuration = configuration;
    connStringServiceBus = configuration.GetConnectionString("connStringServiceBus");
  }

  public async Task SendMissionToBus(String serializedJson)
  {
    var clientOptions = new ServiceBusClientOptions()
    {
      TransportType = ServiceBusTransportType.AmqpWebSockets
    };

    client = new ServiceBusClient(connStringServiceBus, clientOptions);
    sender = client.CreateSender("missionqueues");

    var message = new ServiceBusMessage(serializedJson);

    try
    {
      await sender.SendMessageAsync(message);
    }
    finally
    {
      await sender.DisposeAsync();
      await client.DisposeAsync();
    }
  }
}
