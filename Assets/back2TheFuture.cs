using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back2TheFuture : MonoBehaviour
{
    public Vector3 ogPosition;
    public Vector3 ogOrientation;
    public string SampleSceneobj;
    // Start is called before the first frame update
    void Start()
    {
        SampleSceneobj = "SampleScene";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void back2Museum()
    { //in case this dont work check out asynch unload in browser
        SceneManager.LoadScene(SampleSceneobj);
    }
}
