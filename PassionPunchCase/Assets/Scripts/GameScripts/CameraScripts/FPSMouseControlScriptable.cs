using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FPSMouseSetting", menuName = "FPSMouseSettings/FPSMouseSettings")]

public class FPSMouseControlScriptable : ScriptableObject
{
    [Range(0, 100)] public float mouseSensivity;
}
