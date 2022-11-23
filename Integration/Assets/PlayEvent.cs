using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEvent : MonoBehaviour
{
    public FMODUnity.EventReference reference;
    private FMOD.Studio.EventInstance instance; 

    // Start is called before the first frame update
    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(reference);
        
        if (instance.isValid())
        {
            instance.start();
        }
        else
        {
            Debug.Log("Failed to instantiate");
            instance.release();
        }
    }
}
