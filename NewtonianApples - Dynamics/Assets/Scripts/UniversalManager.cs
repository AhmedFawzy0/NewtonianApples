using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniversalManager : MonoBehaviour
{
    public Animator transition;
    public float seconds = 1;

    public void LoadNextScene(int index)
    {
        StartCoroutine(LoadLevel(index));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(seconds);

        SceneManager.LoadScene(levelIndex);
    }
}
