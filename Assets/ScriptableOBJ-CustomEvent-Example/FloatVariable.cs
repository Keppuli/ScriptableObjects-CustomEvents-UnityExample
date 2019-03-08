using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://youtu.be/raQ3iHhE_Kk?t=1062
[CreateAssetMenu(fileName = "FloatVariable", menuName = "FloatVariable", order = 1)] // Enables obj creation from Right click -> Create
public class FloatVariable : ScriptableObject
{
    public string description; // Dev description about functionality to be displayed in Editor

    /* Class holds some value that will be named after obj creation.  
     * Meaning of the value is defined by designers. eg. HP, Movespeed, Score..
     * Value changes dynamically during runtime and everything referencing it gets an easy update.
     */
    public float Value;

 
}
