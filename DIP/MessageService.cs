using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public class MessageService
{
    private IMessageSender messageSender;

    public MessageService(IMessageSender sender)
    {
        messageSender = sender;
    }

    public void SendMessage(string message)
    {
        messageSender.SendMessage(message);
    }
}