using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject ship;
    Vector3 offset;

    public void Start()
    {
        offset = transform.position - ship.transform.position;
    }

    public void LateUpdate()
    {
        transform.position = ship.transform.position + offset;
    }


}
