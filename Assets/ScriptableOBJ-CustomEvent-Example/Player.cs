using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // Important  for custom events

public class Player : MonoBehaviour {

    // Scriptable objects
    public FloatReference hp;
    public FloatReference hpMax;
    public FloatReference moveSpeed;
    public GameEvent damageEvent; // Custom Events

    Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();
        hp.SetValue(hpMax.GetValue()); // Reset hp 
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * moveSpeed.GetValue()); // FloatReference 
    }

    
}
