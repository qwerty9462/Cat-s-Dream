using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTo : MonoBehaviour
{
    public string to;
    public Vector3 pos;

    public void SetDest(string dest)
    {
        to = dest;
    }
    public void SetPos(Vector3 prevPos)
    {
        pos = prevPos;
    }
    public string GetDest()
    {
        return to;
    }
    public Vector3 GetPos()
    {
        return pos;
    }
}
