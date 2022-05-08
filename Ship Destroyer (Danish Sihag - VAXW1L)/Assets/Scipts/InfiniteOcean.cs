using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteOcean : MonoBehaviour
{
    public GameObject oceanFloor;
    public GameObject ship;

    Vector3 newPosition;

    public void OceanFloorSpawn()        //method for spawning ocean floor.
    {

        //newPostion has been made to reference the empty vector object we made for "OceanFloorEmpty" prefab, as a child. 

       GameObject InstantiateOceanSpawn = Instantiate(oceanFloor, newPosition , Quaternion.identity);   //using (new vector 3 with z-axis) giving issues of multiple spawns at wrong place.
       newPosition = InstantiateOceanSpawn.transform.GetChild(0).transform.position;    // child referenced as 0 because it is the 1st child of the prefab and count is starting from 0 in heirarchy.
    }

    /* private void Update()
     {
         if (ship.transform.position.z > 250)
         {
             OceanFloorSpawn();

         }
      }
    */

}
