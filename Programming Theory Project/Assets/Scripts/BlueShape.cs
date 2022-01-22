using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShape : ColorShape
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
        RotateText(50);
    }
}
