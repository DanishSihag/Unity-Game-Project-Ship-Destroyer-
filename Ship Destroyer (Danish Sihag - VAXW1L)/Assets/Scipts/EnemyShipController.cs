using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyShipController : MonoBehaviour
{

    public float speed = 10.0f;

    public TextMeshProUGUI LevelsText;
       
    public void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Levels();     
    }

    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            LevelsController.IsGameOver = true;           //method called from LevelsController script.
            AudioController.IsPlayerColliding = true;    //method called from AudioController script.
        }

        Destroy(gameObject, 18);                        //automatic enemy ship destruction after 18 seconds.       

    }
    public void Levels()                   
    {
        if (Time.realtimeSinceStartup > 0 && Time.realtimeSinceStartup < 35)       //Level 1
        {
            speed = 15f;
            LevelsController.IsLevel1 = true;               //referenced from LevelsControllerScript
        }
        if (Time.realtimeSinceStartup > 35 && Time.realtimeSinceStartup < 75)      //Level 2
        {
            speed = 35f;
            LevelsController.IsLevel2 = true;               //referenced from LevelsControllerScript
        }
        if (Time.realtimeSinceStartup > 75 && Time.realtimeSinceStartup < 110)     //Level 3
        {
            speed = 60f; 
            LevelsController.IsLevel3 = true;               //referenced from LevelsControllerScript
        }
        if (Time.realtimeSinceStartup > 110 && Time.realtimeSinceStartup < 160)    //Level 4
        {
            speed = 78f;
            LevelsController.IsLevel4 = true;              //referenced from LevelsControllerScript
        }
        if (Time.realtimeSinceStartup > 160 && Time.realtimeSinceStartup < 190)    //Level 5
        {
            speed = 110f;
            LevelsController.IsLevel5 = true;              //referenced from LevelsControllerScript
        }

        if (Time.realtimeSinceStartup > 190)
        {
            LevelsController.IsGameOver = true;           
            Destroy(gameObject);
        }
    }
}
