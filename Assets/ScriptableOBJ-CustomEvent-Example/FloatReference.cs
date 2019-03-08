using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://youtu.be/raQ3iHhE_Kk?t=1176
[System.Serializable] // The Serializable attribute lets you embed a class with sub properties in the inspector.
public class FloatReference // Not inheriting from anything
{
    /* Designer configures obj to use either constant or variable value,
     * making it powerful and easy to manage and debug game values
     * https://youtu.be/raQ3iHhE_Kk?t=1222
     */
    public bool useConstant = true; 
    public float constantValue;
    public FloatVariable variable; // Reference to FloatVariable

    public float GetValue()
    {
        return useConstant ? constantValue : variable.Value;
    }
    // Methods to modify Value
    public void AddToValue(float value)
    {
        variable.Value += value;
    }
    public void DeductFromValue(float value)
    {
        variable.Value -= value;
    }
    public void SetValue(float value)
    {
        variable.Value = value;
    }
}
