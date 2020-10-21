using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageCollect : MonoBehaviour
{
    private ScoreUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI = GameObject.Find("Score Text").GetComponent<ScoreUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            ScoreUI.scoreValue += 1;
        }
    }
}
