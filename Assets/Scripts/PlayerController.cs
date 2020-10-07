using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Renderer playerRend;
    //private Vector3 direction = Vector3.zero;
    public float speed = 10.0f;
    public GameObject spawnPoint;
    //public float jumpForce;

    public bool onGround = true;

    public float forceMultiplier;
    public float gravityMultiplier;

    //public GameObject[] pages;
    //public bool onExitDoor = false;

    private PageManager pageManager;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        spawnPoint = GameObject.FindGameObjectWithTag("Respawn");
        //pages = GameObject.FindGameObjectsWithTag("Page");
        pageManager = GameObject.Find("Page Manager").GetComponent<PageManager>();
        playerRend = GetComponent<Renderer>();

        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        rbPlayer.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed, rbPlayer.velocity.y, rbPlayer.velocity.z);

        if(Input.GetButtonDown("Jump") && onGround)
        {
            //rbPlayer.velocity = new Vector3(rbPlayer.velocity.x, jumpForce, rbPlayer.velocity.z);

            rbPlayer.AddForce(Vector3.up * forceMultiplier, ForceMode.Impulse);
            onGround = false;
        }
    }

    private void Respawn()
    {
        rbPlayer.MovePosition(spawnPoint.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hazard"))
        {
            Respawn();
        }

        else if(other.CompareTag("Exit") && pageManager.finishLevel == true)
        {
            //onExitDoor = true;
            playerRend.material.SetColor("_Color", Color.green);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // set on ground state to true if we hit ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
