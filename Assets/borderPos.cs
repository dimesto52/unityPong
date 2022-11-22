using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class borderPos : MonoBehaviour
{
    public borderpos pos = borderpos.top;

    private float curAspect = 0.0f;

    void refreshPos()
    {
        Vector3 camPos = Camera.main.transform.position;
        float camH = Camera.main.orthographicSize;
        float camW = Camera.main.orthographicSize * Camera.main.aspect;
        curAspect = Camera.main.aspect;

        transform.position = camPos;


        BoxCollider2D box = GetComponent<BoxCollider2D>();

        switch (pos)
        {
            case borderpos.top:
                transform.position += Vector3.up * (camH + 0.5f);
                box.size = new Vector2(2 * camW, 1.0f);
                break;

            case borderpos.bottom:
                transform.position -= Vector3.up * (camH + 0.5f);
                box.size = new Vector2(2 * camW, 1.0f);
                break;

            case borderpos.right:
                transform.position += Vector3.right * (camW + 0.5f);
                box.size = new Vector2(1.0f, 2 * camH);
                break;

            case borderpos.left:
                transform.position -= Vector3.right * (camW + 0.5f);
                box.size = new Vector2(1.0f, 2 * camH);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        refreshPos();

        

    }

    // Update is called once per frame
    void Update()
    {
        if(curAspect != Camera.main.aspect)
        {
            refreshPos();
        }

    }
}
public enum borderpos
{
    left,right, top , bottom
}
