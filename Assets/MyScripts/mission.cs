using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission: MonoBehaviour
{
    public GameObject canvasMisiune;
    void OnMouseDown()
    {
        canvasMisiune.SetActive(true);
    }
}