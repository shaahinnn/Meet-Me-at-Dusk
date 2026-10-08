using UnityEngine;

public class WinState : MonoBehaviour
{
    [SerializeField] GameObject gameWinningPanel;
    MovementControlNew movementControlNew;
    AudioManager audioManager;
    void Start()
    {
        gameWinningPanel.SetActive(false);
        audioManager = FindAnyObjectByType<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            audioManager.VictoryAudio();
            audioManager.StopGameAudio();
            gameWinningPanel.SetActive(true);
            Time.timeScale = 0;
 
        }
    }
}
