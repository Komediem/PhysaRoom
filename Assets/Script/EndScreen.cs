using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
