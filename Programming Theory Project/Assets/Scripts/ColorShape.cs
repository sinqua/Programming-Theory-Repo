using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class ColorShape : MonoBehaviour
{
    public string colorName;
    public Color colorValue;
    public TextMeshPro colorText;
    public bool isClicked;

    private int speedDefalut = 1;
    public int rotationSpeed
    {
        get { return speedDefalut; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative rotation speed.");
            }
            else
            {
                speedDefalut = value;
            }
        }
    }

    public virtual void DisplayText(bool click)
    {
        if (click)
        {
            colorText.text = colorName + " : " + colorValue;
            colorText.color = colorValue;
        }
    }

    public void RotateText(int speed)
    {
        colorText.transform.Rotate(0, speed, 0);
    }
}
