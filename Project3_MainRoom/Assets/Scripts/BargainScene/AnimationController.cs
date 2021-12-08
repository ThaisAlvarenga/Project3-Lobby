using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject NPC;
    Animator animator;
    int count = 0;

    private void Awake()
    {
        animator = NPC.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (count == 0)
        {
            if (other.CompareTag("Bargain"))
            {
                animator.SetBool("isTalking", true);
                StartCoroutine("NPCTalking");
            }
            count++;
        }
        
    }

    IEnumerator NPCTalking()
    {
        // play audio
        yield return new WaitForSeconds(10);
        animator.SetBool("isTalking", false);
        yield return null;
    }
}
