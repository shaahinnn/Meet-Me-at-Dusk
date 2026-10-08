using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class UIManager : MonoBehaviour
{


    AudioManager audioManager;
    [SerializeField] GameObject settingsPanel;
   
    private void Start()
    {
      
        audioManager = FindAnyObjectByType<AudioManager>();
    }
    public void LoadingGameScene()
   {
    
        SceneManager.LoadScene("Game Scene");
        audioManager.PlayGameAudio();
        Time.timeScale = 1.0f;

    }
    public void Quit()
    {
    
        Application.Quit();
    }
    public void LoadingHomeScene()
    {
    
        SceneManager.LoadScene("Home Scene");
        audioManager.PlayHomeAudio();
        Time.timeScale = 1.0f;
    }

    public void OpenSettings()
    {
 
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
 
        settingsPanel.SetActive(false);
    }
}
