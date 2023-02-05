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
    private GameObject currentButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (currentButton != null)
            {
                Laser.SetActive(false);
                ButtonStandard.SetActive(false);
                ButtonHighlighted.SetActive(false);
                ButtonPressed.SetActive(true);
                IsActivated = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            currentButton = collision.gameObject;
            if (IsActivated == true)
            {
                ButtonHighlighted.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ButtonHighlighted.SetActive(false);

            if (collision.gameObject == currentButton)
            {
                currentButton = null;
                ButtonHighlighted.SetActive(false);
            }
        }
    }
}
