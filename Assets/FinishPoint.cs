using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    public int levelStatus;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("level1Status", 0);
            Debug.Log(PlayerPrefs.GetInt("level1Status"));
            SceneManager.LoadScene("Win");
        }
    }
}
