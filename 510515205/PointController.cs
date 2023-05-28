using Tkst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkst.Controller
{
    internal class PointController
    {

        ApplicationContext ty = new ApplicationContext();

        public void AddPoint()
        {
            Console.WriteLine();
            Console.WriteLine("Введите название города:");
            Console.WriteLine();

            Point point = new Point();
            {
                string Value = Console.ReadLine();
            };

            ty.Add(point);
            ty.SaveChanges();
        }
    }
}