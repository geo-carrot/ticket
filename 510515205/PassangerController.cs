using Tkst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Tkst.Controller
{
    internal class PassangerController
    {
        ApplicationContext ty = new ApplicationContext();
        public void AddPassanger()
        {
            Console.WriteLine();
            Console.WriteLine("Введите имя и номер пассажира с новой строки");
            Console.WriteLine();
            Passanger passanger = new Passanger()
            {
                Name = Console.ReadLine(),
                Phone = Console.ReadLine(),
            };

            ty.Add(passanger);
            ty.SaveChanges();
        }

        public void EditPassangerName()
        {
            Console.WriteLine();
            Console.WriteLine("Введите старое имя:");
            Console.WriteLine();
            var OldName = ty.Passangers.FirstOrDefault(x => x.Name == Console.ReadLine());

            if (OldName != null)
            {
                Console.WriteLine();
                Console.WriteLine("Введите новое имя:");
                Console.WriteLine();
                OldName.Name = Console.ReadLine();
            }


            ty.SaveChanges();
        }
        public void ShowPassangers()
        {
            foreach (var item in ty.Tickets.Include(x => x.Passanger).Include(x => x.PointArrival).Include(x => x.PointDeparture).ToList())
            {
                Console.WriteLine($"{item?.IdTicket}, {item.Passanger?.Name}, {item.PointDeparture?.Value}-{item.PointArrival?.Value}, время отправления - {item.DateArrive}");
            }
        }
    }
}
