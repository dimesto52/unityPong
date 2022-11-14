using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{

    private int left = 0;
    private int right = 0;

    public System.Action<int> leftChange = null;
    public System.Action<int> rightChange = null;

    public void addLeft()
    {
        //Debug.Log("left");
        left++;
        leftChange.Invoke(left);
    }
    public void addRight()
    {
        //Debug.Log("right");
        right++;
        rightChange.Invoke(right);
    }

    public static Score instance = new Score();

}
public enum sideScore
{
    left,right
}
