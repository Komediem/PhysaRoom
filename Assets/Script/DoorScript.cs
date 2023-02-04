using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    private bool isTrigger;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Bing Chilling");
            doorAnimator.SetBool("IsOpening", true);
        }
    }
}
