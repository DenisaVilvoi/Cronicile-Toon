using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute_Unmute_Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            gameObject.GetComponent<AudioListener>().enabled = !gameObject.GetComponent<AudioListener>().enabled;
        }
    }
}
