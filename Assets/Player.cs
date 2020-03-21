using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    private Vector2 pos;
    //private float speed = 0.5f;
    private float restartDelay = 1f;
    public static bool dead;
    private Vector3 jump;
    public float jumpForce = 20.0f;
    public bool isGrounded;
    public bool isCar;

    public GameObject deathEffect;
    public GameObject collisonEffect;
    void Start()
    {
        //jump = new Vector3(0.0f, 2.0f, 0.0f);
        dead = false;
    }

    void FixedUpdate()
    {
        //transform.position = Vector2.MoveTowards(transform.position, targetPos, 100 * Time.deltaTime);
        pos = transform.position;
        if (transform.position.y <= 0.6f)
        {
            isGrounded = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(Vector3.up * 400);
            isGrounded = false;
        }

        if (Input.GetKey("d") && !dead)
        {
            // targetPos = new Vector2(transform.position.x + speed, transform.position.y);
            pos.x += 0.5f;
            transform.position = pos;
        }

        if (Input.GetKey("a") && !dead)
        {
            //targetPos = new Vector2(transform.position.x - speed, transform.position.y);
            pos.x -= 0.5f;
            transform.position = pos;
        }
        if (rb.position.x < -10f || rb.position.x > 10f)
        {
            dead = true;
        }

        if (dead == true)
        {
            if(!isCar)
            {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            }
            Invoke("Restart", restartDelay);
        }
    }
    // void OnCollisionStay()
    // {
    //     isGrounded = true;
    // }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            dead = true;
            isCar = true;
            Instantiate(collisonEffect, transform.position, Quaternion.identity);
        }
    }
}