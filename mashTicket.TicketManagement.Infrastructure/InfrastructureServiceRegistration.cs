﻿using mashTicket.TicketManagement.Application.Contracts.Infrastructure;
using mashTicket.TicketManagement.Application.Models.Mail;
using mashTicket.TicketManagement.Infrastructure.FileExport;
using mashTicket.TicketManagement.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashTicket.TicketManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<ICsvExporter, CsvExporter>();

            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
