using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Abstractions;

namespace ObserverPattern
{
    public class User : IObserver
    {
        private readonly string username;
        private readonly ChatRoom chatRoom;
        private readonly List<string> chat;

        public User(string username, ChatRoom chatRoom)
        {
            chat = new List<string>();
            this.username = username;
            this.chatRoom = chatRoom;
            ((IObservable) chatRoom).Register(this);
        }

        public void SendMessage(string message) => chatRoom.AddMessage(this, message);

        public void Update(string line)
        {
            chat.Add(line);
            DisplayChat();
        }

        private void DisplayChat() => Console.WriteLine(chat[^1]);

        public override string ToString() => username;
    }
}
