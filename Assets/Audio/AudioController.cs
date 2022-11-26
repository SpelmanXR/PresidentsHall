using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    Transform Player;
    public AudioSource NightAudioSource;
    public float IndoorNightVolume = 0.3f;     //the volume inside the cottage
    public float OutdoorNightVolume = 0.5f;    //the volume outside the cottage
    public float NightVolumeDoorAttenuation = 0.2f;    //the amount by which the closed door decreases the indoor volume

    public AudioSource WaveAudioSource;
    public float IndoorWaveVolume = 0.3f;     //the volume inside the cottage
    public float WaveVolumeDoorAttenuation = 0.2f;    //the amount by which the closed door decreases the indoor volume
    //we need to invert the distance calculation: the waves get louder the *farther* we are from the center of the island.
    public float OutdoorMaxDistance = 25f; //the radius of the island
    public float OutdoorMaxDistanceVolume = 0f; //the vaolume at the max distance
    public float OutdoorDistance0Volume = 1f;  //the volume at the shore

    public Cottage cottage;
    public Door door;

    float NightVolume;
    float WaveVolume;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate the wave volume
        if (cottage.PlayerInside)
        {
            WaveVolume = IndoorWaveVolume - (door.DoorOpen ? 0f : WaveVolumeDoorAttenuation);
        }
        else
        {
            float distance = Mathf.Sqrt(Mathf.Pow(transform.position.x - Player.transform.position.x, 2f)
                + Mathf.Pow(transform.position.z - Player.transform.position.z, 2f));

            WaveVolume = OutdoorDistance0Volume + (distance - 0) * (OutdoorMaxDistanceVolume - OutdoorDistance0Volume) / (OutdoorMaxDistance - 0);
        }
        WaveAudioSource.volume = WaveVolume;

        //calculate the night volume
        if (cottage.PlayerInside)
        {
            NightVolume = IndoorNightVolume - (door.DoorOpen ? 0f : NightVolumeDoorAttenuation);
        }
        else
        {
            NightVolume = OutdoorNightVolume;
        }
        NightAudioSource.volume = NightVolume;
    }
}
