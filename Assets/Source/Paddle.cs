using UnityEngine;
using System.Collections.Generic;

public class Paddle : MonoBehaviour
{
    private Rigidbody Rigidbody;
    public float Speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        { 
            Vector3 Pos = new Vector3(0, 0, 1);
            Pos = Speed * Time.deltaTime * Pos.normalized;
            Rigidbody.MovePosition(transform.position - Pos);   
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 Pos = new Vector3(0, 0, 1);
            Pos = Speed * Time.deltaTime * Pos.normalized;
            Rigidbody.MovePosition(transform.position + Pos);
        }
        
    }
}
