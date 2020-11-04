using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animationController;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Horizontal") > 0)
        //{
        //    animationController.SetBool("RunAnimation", true);

        //    if (Input.GetAxis("Horizontal") < 0)
        //    {
        //        GameObject.Find("Player").transform.eulerAngles
        //        = new Vector3(gameObject.transform.eulerAngles.x, -90, gameObject.transform.eulerAngles.z);
        //    }
        //    else if (Input.GetAxis("Horizontal") > 0)
        //    {
        //        GameObject.Find("Player").transform.eulerAngles
        //        = new Vector3(gameObject.transform.eulerAngles.x, 90, gameObject.transform.eulerAngles.z);
        //    }
        //}
        //else
        //{
        //    animationController.SetBool("RunAnimation", false);
        //}

        //if (Input.GetButtonDown("Jump") && playerController.onGround == true)
        //{
        //    animationController.SetBool("JumpAnimation", true);
        //}
        //else if (!Input.GetButtonDown("Jump") && playerController.onGround == true)
        //{
        //    animationController.SetBool("JumpAnimation", false);
        //}

        if (Input.GetAxis("Horizontal") < 0)
        {
            GameObject.Find("Player").transform.eulerAngles
            = new Vector3(gameObject.transform.eulerAngles.x, -90, gameObject.transform.eulerAngles.z);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            GameObject.Find("Player").transform.eulerAngles
            = new Vector3(gameObject.transform.eulerAngles.x, 90, gameObject.transform.eulerAngles.z);
        }

        if (playerController.onGround == false)
        {
            animationController.SetBool("JumpAnimation", true);
        }
        else if (playerController.onGround == true)
        {
            animationController.SetBool("JumpAnimation", false);
        }
    }
}
