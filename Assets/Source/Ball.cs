using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody Rigidbody;
    float Speed;
    float StartVelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
