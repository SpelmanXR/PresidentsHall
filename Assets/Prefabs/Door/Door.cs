using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator DoorAnimator;

    bool bDoorOpen = false;

    public bool DoorOpen
    {
        get { return bDoorOpen; }
    }

    private void OnTriggerEnter(Collider other)
    {
        bDoorOpen = true;
        DoorAnimator.SetBool("open", bDoorOpen);
    }

    private void OnTriggerExit(Collider other)
    {
        bDoorOpen = false;
        DoorAnimator.SetBool("open", bDoorOpen);
    }
}
