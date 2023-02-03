using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoodScript : MonoBehaviour
{
    public GameObject experienceText;
    public IEnumerator NextLevel()
    {
        experienceText.SetActive(true);

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(+1);
    }
}
