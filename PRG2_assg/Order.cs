using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    class Order
    {
        //Last updated: 21/1/2022

        //attr
        public int OrderNo { get; set; }
        public DateTime OrderDateTime { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public List<Ticket> TicketList = new List<Ticket>();

        //construct
        public Order()
        {
            Status = "Error";
        }
        public Order(int num,DateTime ODT)
        {
            OrderNo = num;
            OrderDateTime = ODT;
        }
        public void AddTicket(Ticket GuoJun)
        {
            TicketList.Add(GuoJun);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
