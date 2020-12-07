using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


// A scene loader script 
// Source: https://answers.unity.com/questions/1617291/how-i-can-open-a-previous-scene-with-button-back.html
// The back button does not work
public class SceneSwitcher : MonoBehaviour
{
    private Stack<int> loadedLevels;

    [System.NonSerialized]
    private bool initialized;

    private void Init()
    {
        loadedLevels = new Stack<int>();
        initialized = true;
    }

    public UnityEngine.SceneManagement.Scene GetActiveScene()
    {
        return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    }

    private void LoadScene(int buildIndex)
    {
        if (!initialized) Init();
        loadedLevels.Push(GetActiveScene().buildIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(buildIndex);
    }

    public void LoadScene(string sceneName)
    {
        if (!initialized) Init();
        loadedLevels.Push(GetActiveScene().buildIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void WolfLoadScene(string sceneName)
    {
        //if (!initialized) Init();
        //loadedLevels.Push(GetActiveScene().buildIndex);
        LoadScene(sceneName);

        if (EventSystem.current.currentSelectedGameObject.name == "Meat")
        {
            PlayerPrefs.SetInt("steak", 1);
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Bridge")
        {
            PlayerPrefs.SetInt("bridge", 1);
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Ball")
        {
            PlayerPrefs.SetInt("ball", 1);
        }

        
        //UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void LoadPreviousScene()
    {
        if (!initialized)
        {
            Debug.LogError("You haven't used the LoadScene functions of the scriptable object. Use them instead of the LoadScene functions of Unity's SceneManager.");
        }
        if (loadedLevels.Count > 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(loadedLevels.Pop());
            //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else
        {
            Debug.LogError("No previous scene loaded");
            // If you want, you can call `Application.Quit()` instead
        }
    }

}
