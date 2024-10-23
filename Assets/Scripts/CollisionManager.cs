using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private int score = 0;
    public GameObject goodItem;
    public GameObject badItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Good Item"))
        {
            Debug.Log("hello");
            score += score;
            //Debug.Log("Score: " + score);
        }
        else if (other.CompareTag("Bad Item"))
        {
            Debug.Log("hello");
            score -= score;
            //Debug.Log("Score: " + score);
        }
        Destroy(gameObject);
    }

    private void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    private void DecreaseScore(int amount)
    {
        score -= amount;
        Debug.Log("Score: " + score);
    }
}

