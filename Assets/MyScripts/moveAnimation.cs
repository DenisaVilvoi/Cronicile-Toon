using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class moveAnimation : MonoBehaviour
{
    void Update()
    {
   
        if (Input.GetKey("w"))
        {

            gameObject.GetComponent<Animator>().SetBool("IsWalking", true);
        }
        if (!Input.GetKey("w"))
        {
            gameObject.GetComponent<Animator>().SetBool("IsWalking", false);
        }
        
        if (Input.GetMouseButton((int)MouseButton.Left))
        {

            gameObject.GetComponent<Animator>().SetBool("attackInamic", true);
        }
        if (!Input.GetMouseButton((int)MouseButton.Left))
        {
            gameObject.GetComponent<Animator>().SetBool("attackInamic", false);
        }


    }
}