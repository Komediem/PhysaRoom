using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator doorAnimator;

    public GameObject InterruptorStandard;
    public GameObject InterruptorHighlighted;
    public GameObject InterruptorPressed;

    private bool IsActivated = true;
    private GameObject currentButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (currentButton != null)
            {
                Debug.Log("Bing Chilling");
                doorAnimator.SetBool("IsOpening", true);
                InterruptorStandard.SetActive(false);
                InterruptorHighlighted.SetActive(false);
                InterruptorPressed.SetActive(true);
                IsActivated = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            currentButton = collision.gameObject;
            if(IsActivated == true)
            {
                InterruptorHighlighted.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            InterruptorHighlighted.SetActive(false);

            if (collision.gameObject == currentButton)
            {
                currentButton = null;
                InterruptorHighlighted.SetActive(false);
            }
        }
    }
}
