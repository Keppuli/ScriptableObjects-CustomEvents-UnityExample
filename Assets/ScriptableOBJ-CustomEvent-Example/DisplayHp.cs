using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHp : MonoBehaviour {

    public FloatVariable hpPlayer;
    Text myText;

    private void Start()
    {
        myText = GetComponent<Text>();
        myText.text = hpPlayer.Value.ToString();
    }

    public void UpdateHP()
    {
        Debug.Log("Updated player HP in GUI: " + gameObject);
        myText.text = hpPlayer.Value.ToString();
    }

}
