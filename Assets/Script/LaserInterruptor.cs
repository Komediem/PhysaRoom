using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserInterruptor : MonoBehaviour
{
    public GameObject Laser;

    public GameObject ButtonHighlighted;
    public GameObject ButtonPressed;

    public void OnTriggerStay2D(Collider2D collision)
    {
        ButtonHighlighted.SetActive(true);

        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Bing Chilling");
            Laser.SetActive(false);
            ButtonPressed.SetActive(true);
        }
    }
}
