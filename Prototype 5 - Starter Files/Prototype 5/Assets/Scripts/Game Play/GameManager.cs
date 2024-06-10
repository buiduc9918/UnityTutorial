using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public int score;
    public TextMeshProUGUI scoreText;
    public List<GameObject> targets;
    private float spawnRate = 1f;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public GameObject tittleScreen;
    public int objectCount = 0;
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            objectCount++;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //isGameActive = true;
        //score = 0;
        //StartCoroutine(SpawnTarget());
        //UpDateScore(0);

    }
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;
        spawnRate = spawnRate / difficulty;
        StartCoroutine(SpawnTarget());
        UpDateScore(0);
        tittleScreen.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
    }

    public void UpDateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {

        Debug.Log("gameover run");
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        Debug.Log("restart run");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}