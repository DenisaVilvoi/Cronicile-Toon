using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaColider : MonoBehaviour
{
        public Transform player;
    public bool isFollowing = false;

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isFollowing = true;
        }
    }
}
