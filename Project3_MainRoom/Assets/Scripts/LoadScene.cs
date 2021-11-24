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


    // Start is called before the first frame update
    void Start()
    {
        loadScene = false;
        //ctrl.canTransport = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Depression"))
        {
            //ctrl.canTransport = true;
                SceneManager.LoadScene(destination, LoadSceneMode.Additive);
        }
        
    }
}
