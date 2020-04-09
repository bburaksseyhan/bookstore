using BookStore.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Commands
{
    public abstract class Command :  Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
