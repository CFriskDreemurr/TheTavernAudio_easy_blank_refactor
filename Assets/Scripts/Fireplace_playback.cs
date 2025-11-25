using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace_playback : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter fireplaceEmitter;

    private void OnTriggerStay(Collider other)
    {
        fireplaceEmitter.SetParameter("fire", 0);
        Debug.Log("set fire to 0");
    }

    private void OnTriggerExit(Collider other)
    {
        fireplaceEmitter.SetParameter("fire", 1);
        Debug.Log("set fire to 1");
    }
}
