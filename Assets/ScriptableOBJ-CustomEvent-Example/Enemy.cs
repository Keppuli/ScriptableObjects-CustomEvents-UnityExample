using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // Important  for custom events

public class Enemy : MonoBehaviour {

    public FloatReference hpPlayer;
    public FloatReference damageAmount;
    public GameEvent damagePlayerEvent; // Custom Events

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Trigger event with Player:");
            hpPlayer.DeductFromValue(damageAmount.constantValue);
            damagePlayerEvent.Raise(); // Custom Events

        }
    }
}
