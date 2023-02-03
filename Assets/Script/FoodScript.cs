using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoodScript : MonoBehaviour
{
    public GameObject experienceText;
    public IEnumerator NextLevel()
    {
        Debug.Log("Mes burnes");
        experienceText.SetActive(true);

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(+1);
    }
}
