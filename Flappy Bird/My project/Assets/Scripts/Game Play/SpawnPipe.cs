using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
public class SpawnPipe : MonoBehaviour
{
    public int score;
    public int add;
    public GameObject[] gameObjects;
    public int numberGameObject;
    public Vector3 spawnPoint;
    private float spawPosX = 6.52f;
    private float spowPosY = -1.5f;
    private float startDelay = 0;
    private float repeatRate = 0;
    private float rabdomY = 3;
    public bool noUpdate = false;
    public TextMeshProUGUI lost;
    public TextMeshProUGUI win;
    public TextMeshProUGUI start;
    public TextMeshProUGUI scoreText;
    private BirdPlayer player;
    private UnityEngine.UI.Button playButton;
    float delay = 1000000f;
    public bool run = false;
    // Start is called before the first frame update loi o start game
    void Start()
    {
        playButton = GameObject.Find("Play Button").GetComponent<UnityEngine.UI.Button>();
        playButton.onClick.AddListener(StartGame);
        player = GameObject.Find("Player").GetComponent<BirdPlayer>();

    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        startDelay = -3;
        repeatRate = 8;
        start.gameObject.SetActive(false);
        lost.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        InvokeRepeating("SpawPipe", startDelay, repeatRate);
    }

    //ko lq up date scorce
    public void updateScource(int addScorce)
    {
        if (noUpdate == false)
            score = score + addScorce;
        scoreText.text = "Score: " + score;
    }
    // Update is called once per frame
    // ko lien quan update
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (playButton.IsActive() == true) run = false; else run = true;
        numberGameObject = gameObjects.Length;
        spawnPoint = new Vector3(spawPosX, Random.Range(spowPosY - rabdomY, spowPosY + rabdomY), 0);
    }
    void SpawPipe()
    {
        if (startDelay == -3 && repeatRate == 8)
        {
            Instantiate(gameObjects[Random.Range(0, numberGameObject - 1)], spawnPoint, gameObjects[Random.Range(0, numberGameObject - 1)].transform.rotation);
            updateScource(add);
        }

    }
    public void GameOver()
    {
        Debug.Log("GAME OVER");
        noUpdate = true;
        startDelay = 0;
        repeatRate = 0;
        TimeDelay();
        Restart(true);

    }
    public void Champion()
    {
        Debug.Log("Bro,you are champion");
        noUpdate = true;
        startDelay = 0;
        repeatRate = 0;
        TimeDelay();
        Restart(false);
    }
    public void Restart(bool gameOver)
    {
        Time.timeScale = 0.033f;
        if (gameOver == false)
        {
            Time.timeScale = 0.033f;

            TimeDelay();
        }
        else
        {
            Time.timeScale = 0.033f;

            lost.gameObject.SetActive(true);
            TimeDelay();
        }
        win.gameObject.SetActive(true);
        lost.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(delay * Time.deltaTime * 100f);
    }
}
