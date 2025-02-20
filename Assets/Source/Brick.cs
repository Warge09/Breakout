using System;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject gameobjectBrick;
    private int Rows = 4;
    private int Columns = 5;
    private float Space = 20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ObjectDuplicate();
    }

    private void ObjectDuplicate()
    {


        for (int i = 0; i < Rows; i++)
        {
            for(int j = 0; j < Columns; j++)
            {
                Vector3 Pos = new Vector3(i * Space, 10, j * Space);
                Instantiate(gameobjectBrick, Pos, Quaternion.identity);
            }

        }

    }
        // Update is called once per frame
        void Update()
        {

        }
    
}
