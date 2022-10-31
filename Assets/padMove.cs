using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padMove : MonoBehaviour
{

    public playerSide side = playerSide.Left;

    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (
            (side == playerSide.Left && Input.GetKey(KeyCode.A)) ||
            (side == playerSide.Right && Input.GetKey(KeyCode.P))
            )
        {
            if(transform.position.y < 4.5f)
            transform.position += Vector3.up * Time.deltaTime* speed;
        }
        if (
            (side == playerSide.Left && Input.GetKey(KeyCode.Q)) ||
            (side == playerSide.Right && Input.GetKey(KeyCode.M))
            )
        {
            if (transform.position.y > -4.5f)
                transform.position += Vector3.down * Time.deltaTime*speed;
        }

    }
}
public enum playerSide
{
    Left,Right
}