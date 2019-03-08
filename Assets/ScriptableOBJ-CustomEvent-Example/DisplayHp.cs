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
    }
    void Update () {
        myText.text = hpPlayer.Value.ToString();
    }
}
