using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioClip clip;
    public float interactDelay = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Invoke("PlaySound", interactDelay);
        }
    }

    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
