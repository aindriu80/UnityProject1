using UnityEngine;

public class PlayerCharacter2D : MonoBehaviour
{
    public Animator anim;
    private bool isGrounded;
    public float jumpForce;
    public Rigidbody2D rig;
    private float shootTimer = .2f;
    private bool shotTimer;
    public int speed;
    public SpriteRenderer sr;

    // Use this for initialization
    private void Start()
    {
        isGrounded = true;
        shotTimer = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (shotTimer)
            shootTimer -= Time.deltaTime;
        if (shootTimer <= 0)
        {
            shotTimer = false;
            anim.SetBool("isShooting", false);
            shootTimer = .2f;
        }

        Movement();
        if (isGrounded) anim.SetBool("isGrounded", true);
        else anim.SetBool("isGrounded", false);
        if (rig.velocity.y < 0)
            rig.velocity += Vector2.up * Physics2D.gravity.y * 2 * Time.deltaTime;
    }

    private void Movement()
    {
        if (Input.GetMouseButton(0))
            if (!shotTimer)
            {
                anim.SetBool("isShooting", true);
                shotTimer = true;
            }
        if (Input.GetKeyDown(KeyCode.Space))
            if (isGrounded)
            {
                rig.AddForce(Vector2.up * jumpForce);
                anim.SetBool("isShooting", false);
                isGrounded = false;
            }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isShooting", false);
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isShooting", false);
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
        {
            isGrounded = true;
            anim.SetBool("isGrounded", true);
        }
    }
}