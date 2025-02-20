using System;
using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float speed = 5.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {

            Destroy(gameObject);

        }
        else {
            Console.WriteLine("NOT THE PADDLE");
        }
    }
}

