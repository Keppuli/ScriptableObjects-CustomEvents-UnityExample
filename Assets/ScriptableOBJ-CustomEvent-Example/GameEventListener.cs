using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // Important  for custom events

//https://youtu.be/raQ3iHhE_Kk?t=2043

public class GameEventListener : MonoBehaviour {

    public GameEvent Event;
    public UnityEvent Response;

    // Have event automatically register / unregister itself
    private void OnEnable()
    {
        Event.RegisterListener(this);
    }
    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    // Invoke event as response to Raise()
    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
