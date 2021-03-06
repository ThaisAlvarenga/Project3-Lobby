using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerScript : MonoBehaviour
{
    public Material right, wrong, defaultMaterial;
    public GameObject container;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Anger"))
        {
            gameObject.GetComponent<MeshRenderer>().material = right;
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
