using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator DoorAnimator;
    bool bDoorOpen = false;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public bool DoorOpen
    {
        get { return bDoorOpen; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        bDoorOpen = true;
        DoorAnimator.SetBool("open", bDoorOpen);
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        bDoorOpen = false;
        DoorAnimator.SetBool("open", bDoorOpen);
        audioSource.Play();
    }
}
