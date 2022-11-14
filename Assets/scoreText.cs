using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreText : MonoBehaviour
{
    public sideScore side = sideScore.left;

    TMP_Text txt;

    // Start is called before the first frame update
    void OnEnable()
    {
        txt = GetComponent<TMP_Text>(); 

        if (side == sideScore.left)
            Score.instance.leftChange += change;
        else
            if(side == sideScore.right)
            Score.instance.rightChange += change;
    }
    void OnDisable()
    {
        txt = GetComponent<TMP_Text>(); 

        if (side == sideScore.left)
            Score.instance.leftChange -= change;
        else
            if(side == sideScore.right)
            Score.instance.rightChange -= change;
    }

    void change(int i)
    {
        txt.text = i.ToString(); 
    }
}
