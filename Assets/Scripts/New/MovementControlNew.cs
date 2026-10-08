using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MovementControlNew : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;

 
    Animator animator;
    bool hasControl = true;
    BoxCollider2D feetCollider;
    void Start()
    {
     
        feetCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("Idle", true);
        animator.SetBool("Walk", false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if(hasControl)
        {
            Run();
            FlipSprite();
        }        
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();  
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x*moveSpeed, rb.linearVelocity.y);
        rb.linearVelocity = playerVelocity;
        bool hasHorizontalSpeed = Mathf.Abs(rb.linearVelocity.x) > Mathf.Epsilon;
        if (hasHorizontalSpeed)
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Idle", false);
           
        }
        else
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Walk", false);
                  
        }
    }
    void FlipSprite()
    {
        bool hasHorizontalSpeed = Mathf.Abs(rb.linearVelocity.x) > Mathf.Epsilon;
        if(hasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb.linearVelocity.x), 1f);
        }
        
    }

    void OnJump(InputValue value)
    {
        if (!feetCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }
        if (value.isPressed)
        {
            rb.linearVelocity += new Vector2(0f, jumpSpeed);
        }
    }

    public void DisableControls()
    {
        hasControl = false;
    }

 
}
