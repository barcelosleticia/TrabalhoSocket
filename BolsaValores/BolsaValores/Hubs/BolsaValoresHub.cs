using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BolsaValores.Hubs
{
    public class BolsaValoresHub : Hub
    {
        public Task UpdateValue(string action, string value)
        {
            return Clients.All.InvokeAsync("addNewValue", action, value);
        }
    }
}
