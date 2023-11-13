using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class telepot2campus : MonoBehaviour
{
    public string campusSceneName;
    public Material sceneBoxName;
    public GameObject XRObject;
    public back2TheFuture BTF;
    public Vector3 PositionInScene = new Vector3(0f, 0f, -5f);
    public Vector3 AngleInScene = new Vector3(0f, -40f, 0f);
    static GameObject rabbitHole = null;
    GameObject Terrain;



    // Start is called before the first frame update
    void Start()
    {
        if (rabbitHole == null)
        {
            rabbitHole = GameObject.FindGameObjectWithTag("rabbitHole");
            if (rabbitHole == null)
            {
                Debug.Log("telepot2campus.cs: I can't find the rabbit hole!!!");

            }
            else
            {
                Debug.Log(campusSceneName + " found the rabbit hole");
            }
            rabbitHole.SetActive(false);
        }

        Terrain = GameObject.FindGameObjectWithTag("Terrain");
            if(Terrain == null)
        {
            Debug.Log(campusSceneName + " can't find the terrain!!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void teleport()
    {
        
        BTF.ogPosition = XRObject.transform.position;
        BTF.ogOrientation = XRObject.transform.localEulerAngles;
        XRObject.transform.position = PositionInScene;
        XRObject.transform.localEulerAngles = AngleInScene;
        Debug.Log("switching to " + campusSceneName);
        SceneManager.LoadSceneAsync(campusSceneName, LoadSceneMode.Additive);
        RenderSettings.skybox = sceneBoxName;
        Debug.Log("switched to " + campusSceneName);
        rabbitHole.SetActive(true);
        Terrain.SetActive(false);
    }
}
