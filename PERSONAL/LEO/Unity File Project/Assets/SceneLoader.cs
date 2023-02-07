using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("MAIN MENU");
    }

    public void LoadScene_Settings()
    {
        SceneManager.LoadScene("SETTINGS MENU");
    }
}