using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float add;
    public float maxSpeed;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator animator;
    void Awake() {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update() {
        // if(Input.GetButtonUp("Horizontal")) {
        //     rigid.linearVelocity = new Vector2(rigid.linearVelocity.normalized.x*0.5f, rigid.linearVelocityY);
        // }
        if(Input.GetButton("Horizontal")) {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") != -1;
        }
        
        if(rigid.linearVelocity.normalized.x == 0) {
            animator.SetBool("isWalking", false);
        } else {
            animator.SetBool("isWalking", true);
        }
    }
    void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right*h*add, ForceMode2D.Impulse);

        if(rigid.linearVelocityX > maxSpeed) {
            rigid.linearVelocity = new Vector2(maxSpeed, rigid.linearVelocityY);
        } else if(rigid.linearVelocityX < maxSpeed*(-1)) {
            rigid.linearVelocity = new Vector2(maxSpeed*(-1), rigid.linearVelocityY);
        }
    }
}

// The Y component of the linear velocity of the Rigidbody2D in world-units per second.
// The linear velocity of the Rigidbody2D represents the rate of change over time of the Rigidbody2D position in world-units.