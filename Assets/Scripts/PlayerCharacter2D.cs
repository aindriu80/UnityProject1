using UnityEngine;

public class PlayerCharacter2D : MonoBehaviour
{
    public Animator anim;
    private bool isGrounded;
    public float jumpForce;
    public Rigidbody2D rig;
    public int speed;
    public SpriteRenderer sr;

    // Use this for initialization
    private void Start()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            if (isGrounded)
            {
                rig.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", true);
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isWalking", true);
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            sr.flipX = false;
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
            isGrounded = true;
    }
}