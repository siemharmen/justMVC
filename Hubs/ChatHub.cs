using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ReversiMVC.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task Sendfiche(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task UpdateGame(string user) 
        {
            //,string chart
            //docuemnt get
            string add = "Add";
            await Clients.All.SendAsync("Game", user,add);
        }
        public async Task test(string user,string chart)
        {
            //,string chart
            //docuemnt get

            // als het fout gaat others
            await Clients.Others.SendAsync("Game", user, chart);
        }
        public async Task Afgelopen(string user, string chart)
        {
            //,string chart
            //docuemnt get

            // als het fout gaat others
            await Clients.Others.SendAsync("Afgelopen", user, chart);
        }
        public async Task UpdateGameOthers(string user)
        {
            await Clients.Others.SendAsync("Game", user);
        }
        public async Task Restart()
        {   
            await Clients.All.SendAsync("Restart","fsdf");
        }
    }
}
