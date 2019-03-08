using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // Important for custom events

public class VariableAudioTrigger : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip playerHurtSFX;
    public FloatVariable hpPlayer;
    public FloatReference triggerThreshold; // Set value in editor


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        Debug.Log("PlaySound() activated in: "+gameObject);
        audioSource.PlayOneShot(playerHurtSFX);
    }

    public void CheckForWarningSound()
    {
        Debug.Log("CheckForWarningSound() activated in: " + gameObject);
        if ((hpPlayer.Value < triggerThreshold.constantValue) && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

}
