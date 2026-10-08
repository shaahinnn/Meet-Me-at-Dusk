
using UnityEngine;
public class LiftManager : MonoBehaviour
{
    [SerializeField] Animator liftAnimator;
    [SerializeField] BoxCollider2D chainCollider;
    AudioManager audioManager;
    int layerIndex;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == layerIndex)
        {
            audioManager.PlayLiftAudio();
            liftAnimator.SetTrigger("LiftMove");
            chainCollider.enabled = true;
        }
        else
        {
            audioManager.StopLiftAudio();
        }
    }
    void Start()
    {
        layerIndex = LayerMask.NameToLayer("Player");
        chainCollider.enabled = false;
        audioManager = FindAnyObjectByType<AudioManager>();
    }   
}
