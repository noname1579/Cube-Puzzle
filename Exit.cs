using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void Ex()
    {
        Application.Quit();
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
