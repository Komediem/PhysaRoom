using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserInterruptor : MonoBehaviour
{
    public GameObject Laser;

    public GameObject ButtonStandard;
    public GameObject ButtonHighlighted;
    public GameObject ButtonPressed;

    private bool IsActivated = true;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (IsActivated == true)
        {
            ButtonHighlighted.SetActive(true);
        }

        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Bing Chilling");
            Laser.SetActive(false);
            ButtonStandard.SetActive(false);
            ButtonHighlighted.SetActive(false);
            ButtonPressed.SetActive(true);
            IsActivated = false;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        ButtonHighlighted.SetActive(false);
    }
}
