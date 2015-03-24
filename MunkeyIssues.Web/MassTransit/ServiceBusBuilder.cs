﻿using MassTransit;

namespace MunkeyIssues.Web.MassTransit
{
    public static class ServiceBusBuilder
    {
        public static IServiceBus Build()
        {
            return ServiceBusFactory.New(bus =>
            {
                bus.UseRabbitMq();
                bus.ReceiveFrom("rabbitmq://localhost/MunkeyIssues_Web");
            });
        }
    }
}