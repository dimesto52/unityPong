using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class markPoint : MonoBehaviour
{

    public sideScore side = sideScore.left;

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
        ballMove bm = collision.gameObject.GetComponent<ballMove>();
        if (bm != null)
        {
            if (side == sideScore.left)
                Score.instance.addLeft();
            else
                if (side == sideScore.right)
                Score.instance.addRight();

            bm.reset();
            rumbleManager.r_data.Invoke(new rumbleData(0.1f, 0.1f));
        }
    }
}
