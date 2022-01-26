using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShape : ColorShape
{
    // Start is called before the first frame update
    void Start()
    {
        colorName = "GREEN";
        colorValue = Color.green;
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
            RotateText(5);
            Debug.Log("GREEN");
        }
    }
}
