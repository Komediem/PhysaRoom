using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartIntro : MonoBehaviour
{

    public GameObject Intro_One;
    public GameObject Intro_Two;

    public int count = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            count += 1;
        }

        if (count == 1)
        {
            Intro_One.SetActive(false);
            Intro_Two.SetActive(true);
        }

        if (count == 2)
        {
            SceneManager.LoadScene("LDTestBry 01");
        }
    }
}
