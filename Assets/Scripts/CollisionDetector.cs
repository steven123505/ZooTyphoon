using UnityEngine.SceneManagement;
using UnityEngine;

//This script is called when a collider is hit.
// It moves us to the new scene and initializes any values that it needs to
public class CollisionDetector : MonoBehaviour // parent class for all collissions
{
    public void goToPolarBearExhibit()
    {
        SceneManager.LoadScene("PolarBearExhibit");
    }

    public void goToWolfExhibit()
    {
        PlayerPrefs.SetInt("steak", 0);
        PlayerPrefs.SetInt("bridge", 0);
        PlayerPrefs.SetInt("ball", 0);
        SceneManager.LoadScene("WolfExhibit");
    }

    public void goToElephantExhibit()
    {
        PlayerPrefs.SetInt("isMoist", 0);
        SceneManager.LoadScene("ElephantExhibit");
    }

    public void goToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
