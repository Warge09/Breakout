using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody Rigidbody;
    float Speed;
    Vector3 Pos;
    float x, y, z;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        x = transform.position.x;   
        y = transform.position.y;
        z = transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
