using UnityEngine;

public class FenceDestoyer : MonoBehaviour
{
    int layerIndex;
    [SerializeField] Rigidbody2D rb;
    float timeDelay = 0.5f;
    void Start()
    {
        layerIndex = LayerMask.NameToLayer("Player");
       
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == layerIndex)
        {
            Invoke(nameof(Timer), timeDelay);
        }
    }
    void Update()
    {
        
    }
    void Timer()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
