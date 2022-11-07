using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padReflect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        ballMove ball = collision.gameObject.gameObject.GetComponent<ballMove>();

        ball.direction = (collision.gameObject.transform.position - transform.position).normalized;

    }

}
