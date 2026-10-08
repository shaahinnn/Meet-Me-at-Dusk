using UnityEngine;
using TMPro;
public class ChestCollect : MonoBehaviour
{
    Animator chestAnimator;
   
    AudioManager audioManager;
    ScoreManager scoreManager;

    int layerIndex;
    void Start()
    {
        chestAnimator = GetComponent<Animator>();
        layerIndex = LayerMask.NameToLayer("Player");
        scoreManager = FindAnyObjectByType<ScoreManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == layerIndex)
        {
            scoreManager.AddChest();
            chestAnimator.SetTrigger("Open");
            audioManager.ChestOpenAudio();
            Destroy(gameObject, 2f);
            
        }
    }
    
}
