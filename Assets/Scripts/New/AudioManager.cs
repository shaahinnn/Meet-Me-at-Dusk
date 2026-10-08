using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource coinAudio;
    [SerializeField] AudioSource homeAudio;

    [SerializeField] AudioSource gameOverAudio;
    [SerializeField] AudioSource chestOpen;
    [SerializeField] AudioSource gamePlayAudio;
  
    [SerializeField] AudioSource victoryAudio;
    [SerializeField] AudioSource liftAudio;
    [SerializeField] GameObject musicOff;
 

   
 

    private void Start()
    {
    
        musicOff.SetActive(false);
    
    }
    public void PlayCoinAudio()
    {
        coinAudio.Play();
    }
    public void PlayHomeAudio()
    {
        homeAudio.Play();
    }
    public void PlayGameAudio()
    {
        gamePlayAudio.Play();
    }
    public void StopGameAudio()
    {
        gamePlayAudio.Stop();
    }
    public void PlayGameOverAudio()
    {
        gameOverAudio.Play();
    }
 
    public void VictoryAudio()
    {
        victoryAudio.Play();
    }
    public void ChestOpenAudio()
    {
        chestOpen.Play();
    }
    public void PlayLiftAudio()
    {
        liftAudio.Play();
    }
    public void StopLiftAudio()
    {
        liftAudio.Stop();
    }
    public void PlayGameMusic()
    {
        gamePlayAudio.Play();
        musicOff.SetActive(false);
    }
    public void PlayHomeMusic()
    {
        homeAudio.Play();
        musicOff.SetActive(false);
    }
    public void StopMusic()
    {

        homeAudio.Stop();
        gamePlayAudio.Stop();
        musicOff.SetActive(true);
    }
     
}
