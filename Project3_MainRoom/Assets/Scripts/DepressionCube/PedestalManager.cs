using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalManager : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 350f;

    public Material passMaterial;
    //public GameObject gem;

    private void Awake()
    {
        if (GameObject.Find("BlueJewel") != null)
        {
            GameObject.Find("BlueJewel").transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.black;


        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Pass"))
        {
            StartCoroutine(ShootTheCube(other.gameObject));

        }
        else
        {
            GetComponent<MeshRenderer>().material = passMaterial;
        }
    }

    IEnumerator ShootTheCube(GameObject other)
    {
        other.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
        yield return null;
    }
}
