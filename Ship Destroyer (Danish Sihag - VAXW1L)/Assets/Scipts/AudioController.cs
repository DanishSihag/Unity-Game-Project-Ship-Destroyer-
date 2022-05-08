using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static bool IsCannonColliding = false;
    public static bool IsPlayerColliding = false;
    public static bool IsCannonFired = false;  

    AudioSource audioSource;
    public AudioClip cannonImpact;
    public AudioClip PlayerShipImpact;
    public AudioClip CannonFired;
    public AudioClip ThemeMusic;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>(); 

        audioSource.PlayOneShot(ThemeMusic);   // if used in update, sounds not working and overlapping audios suppressing each other; so its used in start.

    }

    public void CannonCollidingAudio()
    {
        audioSource.PlayOneShot(cannonImpact);
        IsCannonColliding = false;           //for non-multiple audios, it happens only one time.
    }

    public void PlayerColliderAudio()
    {
        audioSource.PlayOneShot(PlayerShipImpact);
        IsPlayerColliding = false;          
    }

    public void CannonFiredAudio()
    {
        audioSource.PlayOneShot(CannonFired);
        IsCannonFired = false;
    }

    public void Update()
    {
       
        if (IsCannonColliding == true)
        {
            CannonCollidingAudio();
        }

        if(IsPlayerColliding == true)
        {
            PlayerColliderAudio();
        }

        if(IsCannonFired == true)
        {
            CannonFiredAudio();
        }

        if (LevelsController.IsGameOver == true)     //called from LevelsController script.
        {
            Destroy(audioSource,3);
        }
    }
}
