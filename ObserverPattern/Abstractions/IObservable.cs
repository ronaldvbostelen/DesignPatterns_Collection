﻿namespace ObserverPattern.Abstractions
{
    public interface IObservable
    {
        void Register(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}