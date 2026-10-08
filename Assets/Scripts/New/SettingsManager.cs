using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] GameObject settingsPanel;
    UIManager manager;

    private void Start()
    {
        settingsPanel.SetActive(false);
        manager = FindAnyObjectByType<UIManager>();
        manager.OpenSettings();
        manager.CloseSettings();
    }
}
