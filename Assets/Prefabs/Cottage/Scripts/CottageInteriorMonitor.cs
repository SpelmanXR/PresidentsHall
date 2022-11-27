using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CottageInteriorMonitor : MonoBehaviour
{
    //we will use a counter to keep track of entry/exit from the multiple interior colliders
    int EnterCount = 0;

    public bool PlayerInside
    {
        get { return EnterCount != 0; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        EnterCount++;
        Debug.Log("CottageInteriorMonitor:OnTriggerEnter(): " + EnterCount + " " + (EnterCount !=0) );
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        EnterCount--;
        Debug.Log("CottageInteriorMonitor:OnTriggerExit(): " + EnterCount + " " + (EnterCount != 0));
    }
}
