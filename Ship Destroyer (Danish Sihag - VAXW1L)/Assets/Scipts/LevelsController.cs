using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelsController : MonoBehaviour
{
    public static bool IsLevel1 = false;
    public static bool IsLevel2 = false;
    public static bool IsLevel3 = false;
    public static bool IsLevel4 = false;
    public static bool IsLevel5 = false;

    public static bool IsGameOver = false;

    public TextMeshProUGUI LevelsText;
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI FinalScoreText;

    PointsCollector pointsCollector;

    public void Start()
    {
        pointsCollector = FindObjectOfType<PointsCollector>();
        GameOverText.gameObject.SetActive(false);        //gameover text must not be shown at the starting.
        FinalScoreText.gameObject.SetActive(false);
    }

    public void Update()
    {
       

        if (IsLevel1 == true) {

            LevelsText.SetText("Level 1");
             
        }
        if (IsLevel2 == true)
        {
            LevelsText.SetText("Level 2");
           
        }
        if (IsLevel3 == true)
        {
            LevelsText.SetText("Level 3");
            
        }
        if (IsLevel4 == true)
        {
            LevelsText.SetText("Level 4");
           
        }
        if (IsLevel5 == true)
        {
            LevelsText.SetText("Level 5");
            
        }

        if(IsGameOver == true)
        {
            GameOverText.gameObject.SetActive(true);
            FinalScoreText.gameObject.SetActive(true);
            FinalScoreText.SetText("Your Final Score is: " + pointsCollector.points + " point(s)" + "\n" + "Press Alt+F4 to exit");
        }
       
    }
}
