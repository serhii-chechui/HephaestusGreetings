using UnityEngine;

namespace DefaultNamespace
{
    public class GreetingsService : MonoBehaviour
    {
        public static GreetingsService instance {get; private set;}

        public void Awake()
        {
            instance = this;
        }
        
        public void Start()
		{
            Debug.Log("Greeting Service Started");
		}
    }
}