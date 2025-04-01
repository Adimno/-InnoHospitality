using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalPoints : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private double points = 0;

    void Update()
    {
        // Update the TextMeshPro text with points value
        textMeshPro.text = "Score: " + points + " pts";
    }

    // Property to get the points value
    public double Points
    {
        get { return points; }
    }


    public void IncrementPoints(double incrementValue)
    {
        points += incrementValue;
    }

}
