using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("bing Chilling");

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                doorAnimator.SetBool("IsOpening", true);
            }
        }
    }
}
