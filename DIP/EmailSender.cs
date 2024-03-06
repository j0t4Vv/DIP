using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Enviando e-mail: " + message);
    }
}