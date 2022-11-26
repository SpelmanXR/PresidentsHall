using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPadController : MonoBehaviour
{
    public string TeleportPadText;

    TeleportTextController teleportTextController;

    // Start is called before the first frame update
    void Start()
    {
        teleportTextController = GetComponentInChildren<TeleportTextController>();
        teleportTextController.TeleportPadText = TeleportPadText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
