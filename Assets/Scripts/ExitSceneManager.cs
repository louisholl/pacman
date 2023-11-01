using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitSceneManagerScript : MonoBehaviour
{
    public void LoadStartScene(string StartScene)
    {
        SceneManager.LoadScene(StartScene);
    }
}
