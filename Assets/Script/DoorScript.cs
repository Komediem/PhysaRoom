using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;

    public GameObject InterruptorStandard;
    public GameObject InterruptorHighlighted;
    public GameObject InterruptorPressed;

    public void OnTriggerStay2D(Collider2D collision)
    {
        InterruptorHighlighted.SetActive(true);

        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Bing Chilling");
            doorAnimator.SetBool("IsOpening", true);
            InterruptorStandard.SetActive(false);
            InterruptorHighlighted.SetActive(false);
            InterruptorPressed.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        InterruptorHighlighted.SetActive(false);
    }
}
