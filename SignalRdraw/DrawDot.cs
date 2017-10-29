using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRdraw
{
    public class DrawDot : Hub
    {
        public void UpdateCanvas(int x, int y)
        {
            Clients.All.updateDot(x, y);
        }

        public void ClearCanvas()
        {
            Clients.All.clearCanvas();
        }

    }
}