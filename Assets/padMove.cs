using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class padMove : MonoBehaviour
{

    public playerSide side = playerSide.Left;

    public float speed = 5.0f;
    public float distance = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Camera.main.transform.position;
        Vector3 d = Vector3.zero;
        if (side == playerSide.Left) d = Vector3.left;
        else d = Vector3.right;

        transform.position = d * Camera.main.aspect * Camera.main.orthographicSize * 0.9f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.transform.position;
        Vector3 d = Vector3.zero;
        if (side == playerSide.Left) d = Vector3.left;
        else d = Vector3.right;

        transform.position = new Vector3(0, transform.position.y) + d * Camera.main.aspect * Camera.main.orthographicSize * 0.9f;

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