using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class interact : MonoBehaviour
{
    public TMP_Text game;
    

void OnMouseDown(){
     Destroy(gameObject);
       Increment();
}
    void Increment(){
        var uiText=game.text.Split("/");
        if(uiText[0]!=uiText[1]){
            game.SetText((int.Parse(uiText[0])+1).ToString()+"/10");
        }
    }
}
