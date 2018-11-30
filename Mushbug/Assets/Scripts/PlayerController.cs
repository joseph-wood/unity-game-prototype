using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D playerRB;
    public float movementSpeed;

    public Animator playerAnim;

    public static PlayerController instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0f) * movementSpeed;

        playerAnim.SetFloat("moveX", playerRB.velocity.x);

        if (Input.GetAxisRaw("Horizontal") >= 1 || Input.GetAxisRaw("Horizontal") <= -1)
        {
            playerAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
        }
    }
}
