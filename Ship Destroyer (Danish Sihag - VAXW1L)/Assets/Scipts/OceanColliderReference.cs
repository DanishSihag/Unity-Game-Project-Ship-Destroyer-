using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanColliderReference : MonoBehaviour
{
    InfiniteOcean infinite;

    public void Start()
    {
        infinite = FindObjectOfType<InfiniteOcean>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")              // if ship collides with ocean floor box collider
        {
            infinite.OceanFloorSpawn();
        }
    }
}
