using System.Collections.Generic;
using ObserverPattern.Abstractions;

namespace ObserverPattern
{
    public class ChatRoom : IObservable
    {
        private readonly List<string> chat;
        private readonly List<IObserver> observers;

        public ChatRoom()
        {
            chat = new List<string>();
            observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            AddMessage(observer, "joined the chat");
            observers.Add(observer);
        } 

        public void Remove(IObserver observer) => observers.Remove(observer);

        public void AddMessage(IObserver from, string message)
        {
            chat.Add($"[{from}]\t: {message}");
            Notify();
        }

        public void Notify() => observers.ForEach(x => x.Update(chat[^1]));
    }
}