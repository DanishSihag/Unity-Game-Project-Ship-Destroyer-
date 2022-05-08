using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCollector : MonoBehaviour
{
    public static bool IsPointCollected = false;

    public int points = 0;

    public TextMeshProUGUI ScoreText;

    public void CollectedPoints()
    {
        points++;
        ScoreText.SetText("POINTS: " + points);
        IsPointCollected = false;
    }

    public void Update()
    {
        if(IsPointCollected == true)
        {
            CollectedPoints();
        }
        
    }
}
