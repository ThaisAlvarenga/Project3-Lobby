using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BargainScript : MonoBehaviour
{
    public Material right, wrong, defaultMaterial;
    public GameObject container;
    public GameObject greenGate;

    private void Start()
    {
        // greenGate = GameObject.Find("gateGreen").transform.GetChild(5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bargain"))
        {
            gameObject.GetComponent<MeshRenderer>().material = right;
            GameObject.Find("gateGreen").transform.GetChild(5).GetComponent<LoadScene>().canUnload = true;
        } else
        {
            gameObject.GetComponent<MeshRenderer>().material = wrong;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        container.GetComponent<MeshRenderer>().material = defaultMaterial;
    }

}
