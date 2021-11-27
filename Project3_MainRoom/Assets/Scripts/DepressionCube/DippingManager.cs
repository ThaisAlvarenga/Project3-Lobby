using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DippingManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Depression"))
        {
            other.tag = "Pass";
        }
    }
}
