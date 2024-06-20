using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint2 : MonoBehaviour
{
    public int levelStatus;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("level2Status", 0);
            Debug.Log(PlayerPrefs.GetInt("level2Status"));
            SceneManager.LoadScene("Win");
        }
    }
}
