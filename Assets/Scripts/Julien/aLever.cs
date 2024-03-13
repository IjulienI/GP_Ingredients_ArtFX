using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aLever : Interactive
{
    public bool open;
    public override void OnInteraction()
    {
        open = true;
    }

    private void Update()
    {
        if (open)
        {
            transform.GetChild(1).rotation = Quaternion.Lerp(transform.GetChild(1).rotation,Quaternion.Euler(45,0,0),.4f);
        }
        else
        {
            transform.GetChild(1).rotation = Quaternion.Lerp(transform.GetChild(1).rotation, Quaternion.Euler(-45, 0, 0), .4f);
        }
    }
}
