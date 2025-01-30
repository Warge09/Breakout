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

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 Pos = new Vector3(0, 0, 1);
            Pos = Speed * Time.deltaTime * Pos.normalized;
            Rigidbody.MovePosition(transform.position - Pos);
            Debug.Log("working");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 Pos = new Vector3(0, 0, 1);
            Pos = Speed * Time.deltaTime * Pos.normalized;
            Rigidbody.MovePosition(transform.position + Pos);
            Debug.Log("working");     
        }
        
    }
}
