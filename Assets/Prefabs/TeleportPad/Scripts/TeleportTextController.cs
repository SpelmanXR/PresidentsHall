using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TeleportTextController : MonoBehaviour
{
    public string DefaultTeleportPadText = "X";

    //transform of the GO tagged as "Player"
    Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        //find the "Player" GO and store a reference to its transform
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;

        //set the text for the teleport pad
        TeleportPadText = DefaultTeleportPadText;
    }

    // Update is called once per frame
    void Update()
    {
        //get the coordinates of the player's feet
        Vector3 playerFeet = new Vector3(playerTransform.position.x, 0f, playerTransform.position.z);

        //force the teleportText to point to the player's feet.
        transform.LookAt(playerFeet);
    }

    public string TeleportPadText
    {
        set 
        {
            //set the text for the teleport pad
            TMPro.TextMeshPro txt = GetComponent<TextMeshPro>();
            txt.text = value;
        }
        get 
        {
            //get the text for the teleport pad
            TMPro.TextMeshPro txt = GetComponent<TextMeshPro>();
            return txt.text; 
        }
    }
}
