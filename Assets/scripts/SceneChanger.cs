using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadMyScene(string sceneName)
    {
        StartCoroutine(LoadSceneAfterDelay(sceneName));
    }
    public void LoadMyScene(int sceneNumber)
    {
        StartCoroutine(LoadSceneAfterDelay(sceneNumber));
    }


    private IEnumerator LoadSceneAfterDelay(string sceneName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);
    }

    private IEnumerator LoadSceneAfterDelay(int sceneNumber)
    {
        yield return new WaitForSeconds(0.5f); 
        SceneManager.LoadScene(sceneNumber);
    }
}
