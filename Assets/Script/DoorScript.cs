using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;
    public bool Opened = false;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Debug.Log("Bing Chilling");

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (Opened == false)
                {
                    doorAnimator.SetBool("IsOpening", true);
                    Opened = true;
                }

                else if (Opened == true)
                {
                    doorAnimator.SetBool("IsOpening", false);
                    Opened = false;
                }
            }
        }
    }
}
