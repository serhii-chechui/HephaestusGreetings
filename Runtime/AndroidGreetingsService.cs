using System;
using UnityEngine;
using Zenject;

namespace WTFGames.Hephaestus.GreetingsService
{
    public class AndroidGreetingsService : IGreetingsService, IInitializable, IDisposable
    {
        public void Initialize()
        {
            Debug.Log("Android Greeting Service Initialized");
        }

        public void Dispose()
        {
            Debug.Log("Android Greeting Service Disposed");
        }
        
        public string GetGreeting()
        {
            return "Hello Android!";
        }
    }
}