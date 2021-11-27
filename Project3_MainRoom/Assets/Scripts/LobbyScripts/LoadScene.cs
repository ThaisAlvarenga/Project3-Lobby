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
    int count;


    // Start is called before the first frame update
    void Start()
    {
        loadScene = false;
        //count = 1;
        //tags = gameObject.tag; 
        //ctrl.canTransport = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        loadScene = !loadScene;
        if (other.gameObject.CompareTag(tags))
        {
            //ctrl.canTransport = true;
            if (loadScene)
            {
                SceneManager.LoadScene(destination, LoadSceneMode.Additive);
                //loadScene = false;
            }

            else if (!loadScene)
            {
               SceneManager.UnloadSceneAsync(destination);
            }
            
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
