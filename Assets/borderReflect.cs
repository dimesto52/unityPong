using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderReflect : MonoBehaviour
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
        ballMove ball = collision.gameObject.GetComponent<ballMove>();

        Vector3 dir = ball.direction;
        Vector3 norm = collision.contacts[0].normal;

        ball.direction = Vector3.Reflect(dir, norm);
        rumbleManager.b_data.Invoke(new bumpData((Vector2)(-norm)*0.5f, 25.0f, 0.5f));
    }

}
