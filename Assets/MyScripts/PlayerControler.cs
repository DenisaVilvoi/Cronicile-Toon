using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;


public class PlayerControler : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
  
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        var moveInput = (new Vector3(h, 0, v)).normalized;

        var moveDir = moveInput;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }


}
