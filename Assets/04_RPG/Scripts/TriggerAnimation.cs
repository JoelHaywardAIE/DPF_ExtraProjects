using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator animator;
    public float interactDelay = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Invoke("PlayAnimation", interactDelay);
        }
    }

    private void PlayAnimation()
    {
        animator.SetTrigger("play");
    }
}
