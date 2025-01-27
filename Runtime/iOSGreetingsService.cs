using System;
using UnityEngine;
using Zenject;

namespace WTFGames.Hephaestus.GreetingsService
{
    public class iOSGreetingsService  : IGreetingsService, IInitializable, IDisposable
    {
        public void Initialize()
        {
            Debug.Log("iOS Greeting Service Initialized");
        }

        public void Dispose()
        {
            Debug.Log("iOS Greeting Service Disposed");
        }
        
        public string GetGreeting()
        {
            return "Hello iOS!";
        }
    }
}