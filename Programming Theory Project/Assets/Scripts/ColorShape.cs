using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class ColorShape : MonoBehaviour
{
    [SerializeField] private string colorName;
    [SerializeField] private Color colorValue;
    public TextMeshPro colorText;

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

    public virtual void DisplayText()
    {
        colorText.text = "Color: " + colorName + "Value: " + colorValue;
    }

    public void RotateText(int speed)
    {
        colorText.transform.Rotate(0, speed, 0);
    }
}
