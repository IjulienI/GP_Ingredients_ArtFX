using System.IO;
using UnityEngine;

public class aDoor : Interactive
{

    public override void OnInteraction()
    {
         GetComponent<Animator>().SetTrigger("Open");
    }
}