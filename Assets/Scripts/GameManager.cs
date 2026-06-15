using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

   
    public TargetSpawner spawner;
    public TargetArrow arrow;
    public Transform target;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;

    
    public float timeRemaining = 60f;
    public int deliveries = 0;
    public bool hasPackage = false;

    public AudioSource sfxSource;
    public AudioClip pickupSound;
    public AudioClip deliverySound;

    bool gameOver = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        gameOverText.SetActive(false);

        // Start by pointing to first package target
        arrow.target = target;
    }

    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }

            return;
        }
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);
            Time.timeScale = 0f;

            return;
        }

        timerText.text = "Time: " + Mathf.CeilToInt(timeRemaining);
        scoreText.text = "Deliveries: " + deliveries;
    }
        
    

    // PICKUP PACKAGE
    public void PickupPackage()
    {
        if (hasPackage) return;

        hasPackage = true;

        // target is already moved by spawner
        arrow.target = target;

        if (sfxSource != null && pickupSound != null)
            sfxSource.PlayOneShot(pickupSound);
    }

    // DELIVERY COMPLETE
    public void DeliverPackage()
    {
        if (!hasPackage) return;

        hasPackage = false;
        deliveries++;

        // continue loop (spawner already moves target)
        arrow.target = target;

        if (sfxSource != null && deliverySound != null)
            sfxSource.PlayOneShot(deliverySound);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}