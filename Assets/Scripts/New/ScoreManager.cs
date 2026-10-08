using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
public class ScoreManager : MonoBehaviour
{
  
    [SerializeField] TextMeshProUGUI coinCollect;
    AudioManager audioManager;
    int collectedScore = 0;
    [SerializeField] TextMeshProUGUI chestText;
    int score = 0;

    private void Start()
    {
        chestText.text = "" + score;
        coinCollect.text = ""+collectedScore;
        audioManager = FindAnyObjectByType<AudioManager>();
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            audioManager.PlayCoinAudio();
            Destroy(collision.gameObject);
            collectedScore++;
            coinCollect.text = "" + collectedScore;
        }
    }
    public void AddChest()
    {
        score++;
        chestText.text = "" + score;
    }

}
