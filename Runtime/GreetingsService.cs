using System;
using UnityEngine;
using Zenject;

namespace WTFGames.Hephaestus.GreetingsService
{
    public class GreetingsService : IGreetingsService, IInitializable, IDisposable
    {
        public void Initialize()
        {
            Debug.Log("Greeting Service Initialized");
        }

        public void Dispose()
        {
            Debug.Log("Greeting Service Disposed");
        }

        public string GetGreeting()
        {
            return "Hello World!";
        }
    }
}