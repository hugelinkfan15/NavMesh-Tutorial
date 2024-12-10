using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public SceneReference scene;

    public void switchScene()
    {
        SceneManager.LoadScene(scene);
       
    }
}
