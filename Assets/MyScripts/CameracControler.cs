using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameracControler : MonoBehaviour
{
    [SerializeField] Transform followTarget;
    public float rotationSpeed = 2;
    [SerializeField] float distance = 5;
    [SerializeField] float minVerticalAngle = -3;
    [SerializeField] float maxVerticalAngle = 45;
    [SerializeField] Vector2 ViewOffset;
    [SerializeField] bool invertX;
    [SerializeField] bool invertY;
    float rotationX;
    float rotationY;
    float invertXval;
    float invertYval;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        invertXval = (invertX) ? -1 : 1;
        invertYval = (invertY) ? -1 : 1;

        //axele de la muse sunt pe dos fata de cele din unity  
        rotationX += Input.GetAxis("Mouse Y") * invertYval * rotationSpeed;
        rotationX = Mathf.Clamp(rotationX, minVerticalAngle, maxVerticalAngle);
        rotationY += Input.GetAxis("Mouse X") * invertXval * rotationSpeed;

        var targetRotation = Quaternion.Euler(rotationX, rotationY, 0);

        var focusPosition = followTarget.position + new Vector3(ViewOffset.x, ViewOffset.y);

        transform.position = focusPosition - targetRotation * new Vector3(0, 0, distance);
        transform.rotation = targetRotation;
    }
    public Quaternion PlanarRotation => Quaternion.Euler(0, rotationY, 0);
}
