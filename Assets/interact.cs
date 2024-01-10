using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class interact : MonoBehaviour
{
    public GameObject game;
    private int mushroomAmount;

    void Start()
    {
        mushroomAmount = 0;
    }
    void Update()
    {
        game.GetComponent<TMP_Text>().text = mushroomAmount.ToString();
    }

    public void addMushroom()
    {
        mushroomAmount += 1;
    }

}
