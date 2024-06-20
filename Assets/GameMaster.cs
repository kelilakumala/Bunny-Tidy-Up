using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class GameMaster : MonoBehaviour
{
    public bool runningTimer;
    public float currentTime;
    public float maxTime = 50;
    private bool useTimer = true;
    public int Respawn;
    public Text timerText;
    public SceneController gameManager;
    private bool isDead;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        runningTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (useTimer)
        {
            currentTime -= Time.deltaTime;
            timerText.text = "Time:" + System.Math.Round(currentTime).ToString();

        }

        if (currentTime <= 0 && !isDead)
        {
            isDead = true;
            player.SetActive(false);
            gameManager.gameOver();

            runningTimer = false;
            currentTime = 0;
            timerText.text = "Time's Up!";
            useTimer = false;
            // SceneManager.LoadScene(Respawn);
        }

    }
}
