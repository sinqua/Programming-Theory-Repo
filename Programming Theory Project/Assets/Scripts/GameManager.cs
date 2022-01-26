using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera gameCamera;
    ColorShape previousUnit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (previousUnit)
            {
                previousUnit.isClicked = false;
            }
            HandleSelection();
        }
    }

    public void HandleSelection()
    {
        // Manage everything that occurs when the user left clicks on of the Forklifts in the app.
        var ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //the collider could be children of the unit, so we make sure to check in the parent
            var unit = hit.collider.GetComponentInParent<ColorShape>();
            unit.isClicked = true;
            previousUnit = unit;
        }
    }
}
