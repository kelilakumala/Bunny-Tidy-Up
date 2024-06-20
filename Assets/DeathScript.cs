using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class DeathScript : MonoBehaviour
{
    public static SceneController instance;
    public GameObject player;
    public GameObject gameOverUI;
    public GameMaster gameMaster;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            player.SetActive(false);
            gameMaster.currentTime = 0;
            gameMaster.timerText.text = "-";
            gameOverUI.SetActive(true);

        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
