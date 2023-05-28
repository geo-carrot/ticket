using Tkst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Tkst.Controller
{
    internal class TicketController
    {
        ApplicationContext ty = new ApplicationContext();

        public void AddTicket()
        {
            Console.WriteLine();
            Console.WriteLine("Напишите имя, город отправления и город прибытия:");
            Console.WriteLine();
            Ticket ticket = new Ticket()
            {
                Passanger = ty.Passangers.FirstOrDefault(x => x.Name == Console.ReadLine()),
                PointDeparture = ty.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
                PointArrival = ty.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
                DateArrive = DateTime.Now.AddHours(6)
            };

            ty.Add(ticket);
            ty.SaveChanges();
        }

        public void DeleteTicketByName()
        {
            Console.WriteLine();
            Console.WriteLine("Введите имя пассажира для удаления билета:");
            Console.WriteLine();
            string NameToRemove = Console.ReadLine();

            foreach (var item1 in ty.Tickets.Include(x => x.Passanger))
            {
                if (item1.Passanger.Name == NameToRemove)
                {
                    ty.Remove(item1);
                }
            }
            ty.SaveChanges();
        }
    }
}

