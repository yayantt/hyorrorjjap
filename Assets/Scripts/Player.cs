using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int nowScene;
    public float add;
    public float maxSpeed;
    public string nextScene;
    public string upStair;
    public string downStair;
    public string detailScene;
    public string specialScene;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator animator;
    Transform trans;
    void Awake() {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        trans = GetComponent<Transform>();
        int prev = GameManager.instance.previousScene;
        if(prev == 0) {
            trans.Translate(new Vector3((float)-24.89, (float)-0.95));
            spriteRenderer.flipX = true;
        } else if(prev == 3) {
            trans.Translate(new Vector3((float)-28.7, (float)-0.95));
            spriteRenderer.flipX = true;
        } else if(prev == 4 || prev == 6) {
            trans.Translate(new Vector3((float)28.7, (float)-0.95));
            spriteRenderer.flipX = false;
        } else if(prev == 5) {
            trans.Translate(new Vector3(-31, (float)-0.95));
            spriteRenderer.flipX = true;
        } else if(prev == 8) {
            trans.Translate(new Vector3((float)-15.14, (float)-0.95));
            spriteRenderer.flipX = false;
        } else if(prev == 9) {
            trans.Translate(new Vector3((float)-22.24, (float)-0.95));
            spriteRenderer.flipX = true;
        } else {
            trans.Translate(new Vector3(0, (float)-0.95));
            spriteRenderer.flipX = true;
        }
        print(GameManager.instance.isLockedChecked);
        if(GameManager.instance.isAlbum && GameManager.instance.isLighter && GameManager.instance.isMaka) SceneManager.LoadScene("EndingPathScene");
    }
    void Update() {
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
    void OnTriggerStay2D(Collider2D obj) {
        if (obj.gameObject.tag == "Say_Interaction") {
            if (Input.GetKeyDown(KeyCode.E)) {
                if(nowScene == 3) {
                    GameManager.instance.previousScene = 8;
                    GameManager.instance.isLockedChecked = true;
                } else if(nowScene == 1) {
                    GameManager.instance.previousScene = 9;
                    GameManager.instance.isTalkedWithDarae = true;
                }
                SceneManager.LoadScene(nextScene);
            }
        } else if (obj.gameObject.tag == "Up_Interaction") {
            if (Input.GetKeyDown(KeyCode.E)) {
                GameManager.instance.previousScene = nowScene*2;
                SceneManager.LoadScene(upStair);
            }
        } else if (obj.gameObject.tag == "Down_Interaction") {
            if (Input.GetKeyDown(KeyCode.E)) {
                GameManager.instance.previousScene = nowScene*2+1;
                if(GameManager.instance.isTalkedWithDarae) {
                    if(nowScene != 3) SceneManager.LoadScene(specialScene);
                    else {
                        GameManager.instance.isLighter = true;
                        SceneManager.LoadScene(downStair);
                    }
                } else SceneManager.LoadScene(downStair);
            }
        } else if (obj.gameObject.tag == "Ghost_Interaction") {
            if (Input.GetKeyDown(KeyCode.E)) {
                SceneManager.LoadScene(detailScene);
                if(nowScene == 1) GameManager.instance.isMaka = true;
                else if(nowScene == 3) GameManager.instance.isAlbum = true;
            }
        }
    }
}