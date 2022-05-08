using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CannonBallController : MonoBehaviour
{

    public float speed = 10.0f;

    public void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyShip1") || other.gameObject.CompareTag("EnemyShip2"))
        {

            Destroy(other.gameObject);                      //Ships destroyed
            Destroy(gameObject);                           //Cannon destroyed on impact

            PointsCollector.IsPointCollected = true;      // method called from PointsCollector script.
            AudioController.IsCannonColliding = true;    //method called from AudioController script.

        }
    }
}
