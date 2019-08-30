using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialScript : MonoBehaviour
{
    public Text text2;
    void Start()
    {

    }


    void Update()
    {
        if (MoveObject.levelEnd)
        {
            text2.text = "----------------------->";
        }
    }
}
