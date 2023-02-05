using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoodScript : MonoBehaviour
{
    public GameObject experienceText;
    public GameObject pauseButton;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(NextLevel());
        }
    }

    public IEnumerator NextLevel()
    {
        pauseButton.SetActive(false);
        experienceText.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
