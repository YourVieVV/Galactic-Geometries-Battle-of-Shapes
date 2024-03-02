using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingCanvas : MonoBehaviour
{
    public GameObject LoadingScreen;

    // Use this for initialization
    void Start()
    {
        LoadingScene();
    }

    public void LoadingScene()
    {
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation loadAsync = SceneManager.LoadSceneAsync(1);
        loadAsync.allowSceneActivation = false;

        while (!loadAsync.isDone)
        {
            if (loadAsync.progress >= 0.9f && !loadAsync.allowSceneActivation)
            {
                yield return new WaitForSeconds(1f);
                loadAsync.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
