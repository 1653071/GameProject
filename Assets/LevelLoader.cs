using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(int Sceneindex)
    {
        StartCoroutine(LoadAsynchronously(Sceneindex));

    }
    IEnumerator LoadAsynchronously (int Sceneindex)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(Sceneindex);
        while (!ao.isDone)
        {
            Debug.Log(ao.progress);
            yield return null;
        }
    }

}
