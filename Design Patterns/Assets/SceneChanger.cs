using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    [SerializeField] string[] sceneNames;
    [SerializeField] int sceneIndex;

    public void ChangeSceneSequentially()
    {
        if (sceneIndex < sceneNames.Length)
        {
            SceneManager.LoadScene(sceneNames[sceneIndex]);
            sceneIndex++;
        }
        else
        {
            sceneIndex = 0;
        }
    }
    void ChangeSceneAndIncrementIndex()
    {
        SceneManager.LoadScene(sceneNames[sceneIndex]);
        sceneIndex++;
    }
}
