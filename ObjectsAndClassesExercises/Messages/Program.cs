using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    public string Username { get; set; }
    public List<Message> ReceivedMessages { get; set; }
}
class Message
{
    public string Content { get; set; }
    public User Sender { get; set; }
}
namespace _06_Messages
{


    class Program
    {
        static void Main(string[] args)
        {

            var users = new List<User>();

            var inputStr = Console.ReadLine();
            while (inputStr != "exit")
            {
                var input = inputStr.Split(' ').ToArray();

                if (input[0] == "register")
                {
                    var newUser = new User()
                    {
                        Username = input[1],
                        ReceivedMessages = new List<Message>()
                    };

                    if (!users.Contains(newUser))
                    {
                        users.Add(newUser);
                    }
                }
                else
                {

                    var senderName = input[0];
                    var recipientUsername = input[2];

                    var newMessage = new Message();
                    newMessage.Content = input[3];
                    newMessage.Sender = new User() { Username = senderName, ReceivedMessages = new List<Message>() };

                    var ifContainsSender = users.Where(x => x.Username == senderName).ToArray();
                    var ifContainsRecipient = users.Where(x => x.Username == recipientUsername).ToArray();

                    if (ifContainsSender.Count() > 0 && ifContainsRecipient.Count() > 0)
                    {
                        var recipientMessages = users.FirstOrDefault(x => x.Username == recipientUsername);
                        if (recipientMessages != null)
                        {
                            recipientMessages.ReceivedMessages.Add(newMessage);
                        }
                    }
                }
                inputStr = Console.ReadLine();
            }
            var finalInput = Console.ReadLine().Split(' ').ToArray();
            var first = finalInput[0];
            var second = finalInput[1];

            var messagesFromFirstToSecond = users
                .Where(x => x.Username == second)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == first)
                .Count();
            var messagesFromSecondToFirst = users
                .Where(x => x.Username == first)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == second)
                .Count();

            if (messagesFromFirstToSecond == 0 && messagesFromSecondToFirst == 0)
            {
                Console.WriteLine("No messages");

            }
            else
            {
                for (int i = 0; i < Math.Max(messagesFromFirstToSecond, messagesFromSecondToFirst); i++)
                {


                    if (i < messagesFromFirstToSecond)
                    {
                        Console.WriteLine($"{first}: {users.Where(x => x.Username == second).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == first).Select(x => x.Content).ToList()[i]}");
                    }
                    if (i < messagesFromSecondToFirst)
                    {
                        Console.WriteLine($"{users.Where(x => x.Username == first).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == second).Select(x => x.Content).ToList()[i]} :{second}");
                    }

                }
            }
        }
    }
}
