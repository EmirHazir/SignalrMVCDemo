using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalrDemo.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        //burada önemli olan isimlerin eşleşmesi değil parametrelerin SIRASI
        public void SendMessage(string name, string message)
        {

            Clients.Others.GetMessageOther(name,message);

            Clients.Caller.GetMessageCaller(message);



            //Bütün clientlara tetiklensin
            //Clients.All()
            
            //Diğer clientslara
            //Clients.Others()

            //ben bunu sunucuya gönderim yine kendime gönderim yapıyorum
            //Clients.Caller()

            //sadece belli bir clienta gönder
            //Clients.Users("Emir").doWork()

            //ID ye gönder
            //Clients.User(userId:1).doWork()

        }
    }
}