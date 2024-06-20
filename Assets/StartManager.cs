using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public void startLevel1()
    {
        PlayerPrefs.SetInt("level1Status", 1);
        SceneManager.LoadScene("Level 1");
    }

    public void startLevel2()
    {
        PlayerPrefs.SetInt("level2Status", 1);
        SceneManager.LoadScene("Level 2");
    }

   public void startLevel1Menu()
    {
        SceneManager.LoadScene("Level 1 Message");
    }

    public void startLevel2Menu()
    {
        SceneManager.LoadScene("Level 2 Message");
    }
}
