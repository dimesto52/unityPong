using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rumbleManager : MonoBehaviour
{

    static public System.Action<rumbleData>  r_data = null;
    static public System.Action<bumpData>  b_data = null;

    rumbleData lr_data = null;
    bumpData lb_data = null;

    // Start is called before the first frame update
    void Start()
    {
        r_data += updateRData;
        b_data += updateBData;
    }

    // Update is called once per frame
    void updateRData(rumbleData d)
    {
        lr_data = d; 
    }
    void updateBData(bumpData d)
    {
        lb_data?.kill(transform);
        lb_data = d; 
    }

    void FixedUpdate()
    {
        if (lr_data != null)
        {
            lr_data.Update(transform);
            lr_data.time -= Time.deltaTime;
            if(lr_data.time<= 0) lr_data = null;
        }
        else if (lb_data != null)
        {
            lb_data.Update(transform);
            if (lb_data.direction.magnitude <= 0.01f) lr_data = null;
        }
    }
}
public class rumbleData
{
    public float strengh;
    public float time;

    public rumbleData(float strengh,float time)
    {
        this.strengh = strengh;
        this.time = time;

    }

    public void Update(Transform transform)
    {
        transform.localPosition = Random.insideUnitCircle * strengh;
    }

}
public class bumpData
{
    public Vector2 direction;
    public float speed;
    public float bounce;

    float time;

    public bumpData(Vector2 direction, float speed, float bounce)
    {
        this.direction = direction;
        this.speed = speed;
        this.bounce = bounce;

    }

    public void Update(Transform transform)
    {
        if (time >= 0)
        {
            time += Time.deltaTime * speed;

            transform.localPosition = direction * time;

            if (time >= 1) direction *= bounce;
        }
        else
        {
            time -= Time.deltaTime * speed;

            transform.localPosition = direction * time;

            if (time <= -1) direction *= bounce;
        }

        if (direction.magnitude <= 0.01f) kill(transform);
    }
    public void kill(Transform transform)
    {
        transform.localPosition = Vector3.zero;
    }
}