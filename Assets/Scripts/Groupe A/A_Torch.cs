using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Torch : Interactive
{
    public override void OnInteraction()
    {
        GameObject.FindObjectOfType<A_EnignManager>().AddLightTorch();
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
