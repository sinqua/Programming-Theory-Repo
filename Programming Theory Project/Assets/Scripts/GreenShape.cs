using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShape : ColorShape
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayText();
    }

    public override void DisplayText()
    {
        base.DisplayText();
        RotateText(20);
    }
}
