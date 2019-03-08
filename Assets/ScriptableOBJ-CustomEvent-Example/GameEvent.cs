using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://youtu.be/raQ3iHhE_Kk?t=1976   
[CreateAssetMenu(fileName = "GameEvent", menuName = "GameEvent", order = 1)] // Enables obj creation from Right click -> Create

// Class for custom Unity events. See GameEventListener.cs
public class GameEvent : ScriptableObject {

    List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise() // Raise event for all listeners
    {
        for (int i = listeners.Count - 1; i >= 0; i--) // Loop through list backwards to avoid out of range exception
        {
            Debug.Log("Event raised for: "+ listeners[i]);
            listeners[i].OnEventRaised();
        }
    }
    public void RegisterListener(GameEventListener listener)
    {
        listeners.Add(listener);
    }
    public void UnregisterListener(GameEventListener listener)
    {
        listeners.Remove(listener);
    }
}
