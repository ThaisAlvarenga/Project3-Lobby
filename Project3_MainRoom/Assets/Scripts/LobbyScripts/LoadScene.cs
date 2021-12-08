using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class LoadScene : MonoBehaviour
{
    //public TransporterController ctrl;
    public bool loadScene;
    // public GameObject gate;

    public string destination;
    public string tags;
    public string tag2;

    // Start is called before the first frame update
    void Start()
    {
        loadScene = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag(tags) && loadScene)
        {
            if (loadScene)
            {
                SceneManager.LoadScene(destination, LoadSceneMode.Additive);
                loadScene = false;
            }
        }

        else if (other.gameObject.CompareTag(tag2) && !loadScene)
        {
            SceneManager.UnloadSceneAsync(destination);
            loadScene = true;
        }

    }

    public void OnTriggerExit(Collider other)
    {
       // loadScene = !loadScene;
       //if (loadScene)
            //loadScene = false;
        //SceneManager.UnloadSceneAsync(destination);
    }
}
