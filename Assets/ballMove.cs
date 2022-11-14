using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{

    public Vector2 direction = Vector2.zero;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        reset();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)direction * Time.deltaTime * speed;  
    }
    public void reset()
    {
        transform.position = Vector3.zero;

        direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
    }
}
