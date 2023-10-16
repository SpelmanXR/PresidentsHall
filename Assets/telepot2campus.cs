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

    // Start is called before the first frame update
    void Start()
    {
        
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
        SceneManager.LoadSceneAsync(campusSceneName,LoadSceneMode.Additive);
        RenderSettings.skybox = sceneBoxName;
    }
}
