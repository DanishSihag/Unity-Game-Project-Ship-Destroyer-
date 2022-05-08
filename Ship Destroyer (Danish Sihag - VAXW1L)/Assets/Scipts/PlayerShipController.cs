using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipController : MonoBehaviour
{

    public float speed = 0;

    Rigidbody rb;

    public float verticalInput = 0;
    public float horizontalInput = 0;

    public float rotationSpeed = 30;

    public GameObject CannonBall;
    public GameObject ship;

    public float latestTime = 0f;
    public float RealTime = 0f;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");         //only horizontal input required for 'A' & 'D' movement

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            /*
            if (Input.GetKey(KeyCode.S))                                     
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            */
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
            }

        if(transform.position.z < 9.5)                  //If player tries to go out of bounds.
        {
            Destroy(gameObject);
            LevelsController.IsGameOver = true;         //method called from LevelsController script.
            AudioController.IsPlayerColliding = true;  //method called from AudioController script.
        }

        latestTime = Time.realtimeSinceStartup;

        if (Input.GetKeyDown(KeyCode.Space) && RealTime <= latestTime)
        {
            InstantiateCannonBall();
            AudioController.IsCannonFired = true;  //method called from AudioController script.
            RealTime = latestTime + 1.5f;         //1.5-second delay between successive cannon balls fired.
        }
    }
    public void InstantiateCannonBall()
    {
        Instantiate(CannonBall, ship.transform.position, ship.transform.rotation);
    }

    public void OnTriggerEnter(Collider other)        // method for collision with boundary rocks.
    {
        if (other.gameObject.CompareTag("RocksLeft") || other.gameObject.CompareTag("RocksRight"))
        {

            Destroy(gameObject);
            LevelsController.IsGameOver = true;         //method called from LevelsController script.
            AudioController.IsPlayerColliding = true;  //method called from AudioController script.
            ParticleEffect.IsPlayerColliding = true;   //method called from ParticleEffect script.
        }
    }

}
