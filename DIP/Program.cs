using DIP;
using System;

class Program
{
    static void Main(string[] args)
    {
        IMessageSender emailSender = new EmailSender();
        IMessageSender smsSender = new SMSSender();

        MessageService emailService = new MessageService(emailSender);
        MessageService smsService = new MessageService(smsSender);

        emailService.SendMessage("Olá, este é um e-mail!");
        smsService.SendMessage("Olá, este é uma mensagem SMS!");
    }
}
