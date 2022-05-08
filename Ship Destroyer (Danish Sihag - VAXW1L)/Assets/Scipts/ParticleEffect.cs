using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    public static bool IsPlayerColliding = false;

    public ParticleSystem PlayerColliding;

    public void Update()
    {
        if(IsPlayerColliding == true)
        {
            PlayerCollidingExplosion();
        }

    }
    public void PlayerCollidingExplosion()
    {
        PlayerColliding.Play();
        IsPlayerColliding = false;
    }
}
