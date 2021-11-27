using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject NPC;
    Animator animator;

    private void Awake()
    {
        animator = NPC.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bargain"))
        {
            animator.SetBool("isTalking", true);
            StartCoroutine("NPCTalking");
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
