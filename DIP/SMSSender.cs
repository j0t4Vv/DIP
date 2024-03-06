using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public class SMSSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Enviando SMS: " + message);
    }
}