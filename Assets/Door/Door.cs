using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator DoorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        DoorAnimator.SetBool("open", true);
    }

    private void OnTriggerExit(Collider other)
    {
        DoorAnimator.SetBool("open", false);
    }
}
