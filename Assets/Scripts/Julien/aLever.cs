using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aLever : Interactive
{
    public bool open;
    public override void OnInteraction()
    {
        open = true;
        interactionType = InteractionType.FailedAction;
    }

    private void Update()
    {
        if (open)
        {
            transform.GetChild(1).rotation = Quaternion.Lerp(transform.GetChild(1).rotation,Quaternion.Euler(45,0,0),.02f);
        }
        else
        {
            transform.GetChild(1).rotation = Quaternion.Lerp(transform.GetChild(1).rotation, Quaternion.Euler(-45, 0, 0), .02f);
        }
    }
}
