using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDetect : MonoBehaviour
{
    int layerIndex = 0;
    [SerializeField] GameObject gameOverPage;
    AudioManager audioManager;
 
    private void Start()
    {
        layerIndex = LayerMask.NameToLayer("Traps");
        gameOverPage.SetActive(false);
        audioManager = FindAnyObjectByType<AudioManager>();
 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == layerIndex)
        {
            audioManager.StopGameAudio();
            audioManager.PlayGameOverAudio();
            Destroy(gameObject,1f);
            gameOverPage.SetActive(true);
            Time.timeScale = 0;
        }
    }

   
}


