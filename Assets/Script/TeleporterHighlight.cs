using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterHighlight : MonoBehaviour
{
    public GameObject TeleporterStandard;
    public GameObject TeleporterHighlighted;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TeleporterHighlighted.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TeleporterHighlighted.SetActive(false);
        }
    }
}
