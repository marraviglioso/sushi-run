using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Obstacle : MonoBehaviour
{
    public float speed;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        if (transform.position.z <= 15)
        {
            FindObjectOfType<Score>().IncreaseScore(); // Find the Score script and tell it to increase the score
            Destroy(gameObject);
        }

    }

 
}
