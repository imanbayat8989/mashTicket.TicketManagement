﻿using mashTicket.TicketManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashTicket.TicketManagement.Domain.Entities
{
    public class Order : AuditbleEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
