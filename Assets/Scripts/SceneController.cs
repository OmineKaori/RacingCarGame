using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    #region Singleton

    public static SceneController instance;
    
    void Awake()
    {
        instance = this;
    }   

    #endregion

    public Animator carAnimator;

    public void EndGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayGame()
    {
        carAnimator.SetTrigger("Play");
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    
    IEnumerator LoadScene(int sceneIndex)
    {
        yield return new WaitForSeconds(1.2f);
        
        SceneManager.LoadScene(sceneIndex);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }
}