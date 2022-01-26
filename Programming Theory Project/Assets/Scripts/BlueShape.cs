using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShape : ColorShape
{
    // Start is called before the first frame update
    void Start()
    {
        colorName = "BLUE";
        colorValue = Color.blue;
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
            RotateText(1);
            Debug.Log("BLUE");
        }
        
    }
}
