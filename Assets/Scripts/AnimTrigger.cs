using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    [SerializeField] private Animator animationController;
    private PageManager pageManager;
    // Start is called before the first frame update
    void Start()
    {
        pageManager = GameObject.Find("Page Manager").GetComponent<PageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (pageManager.finishLevel == true && gameObject.CompareTag("Exit"))
        //{
        //    animationController.SetBool("OpenDoor", true);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && pageManager.finishLevel == true)
        {
            animationController.SetBool("PlayAnimation", true);
            animationController.SetBool("OpenDoor", true);
        }
        else if (other.CompareTag("Player") && pageManager.finishLevel == false)
        {
            animationController.SetBool("PlayAnimation", true);
        }
    }
}
