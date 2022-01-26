using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShape : ColorShape
{
    // Start is called before the first frame update
    void Start()
    {
        colorName = "RED";
        colorValue = Color.red;
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayText(isClicked);
    }

    public override void DisplayText(bool click)
    {
        base.DisplayText(click);
        if (click)
        {
            RotateText(10);
            Debug.Log("RED");
        }
    }
}
