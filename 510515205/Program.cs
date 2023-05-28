using Tkst.Controller;
using Tkst.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using System.Threading.Channels;
using Tkst;

internal class Program
{
    static void Main(string[] args)
    {
        string start = "y";

        while (start == "y")
        {
            Console.WriteLine();
            Console.WriteLine("Введите цифру для выбора действия:" +
                "\n1) Добавить пассажира" +
                "\n2) Изменить имя пассажира" +
                "\n3) Добавить билет" +
                "\n4) Удалить билет" +
                "\n5) Добавить город" +
                "\n6) Показать список пассажиров");
            Console.WriteLine();
            int i = Convert.ToInt32(Console.ReadLine());

            PassangerController pascontrol = new PassangerController();
            TicketController ticketcontrol = new TicketController();
            PointController pointcontrol = new PointController();

            switch (i)
            {
                case 1:
                    pascontrol.AddPassanger();
                    break;
                case 2:
                    pascontrol.EditPassangerName();
                    break;
                case 3:
                    ticketcontrol.AddTicket();
                    break;
                case 4:
                    ticketcontrol.DeleteTicketByName();
                    break;
                case 5:
                    pointcontrol.AddPoint();
                    break;
                case 6:
                    pascontrol.ShowPassangers();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Продолжить? y/n");

            start = Console.ReadLine();
        }
    }
}