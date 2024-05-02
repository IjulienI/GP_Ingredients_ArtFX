using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_BigDoor : MonoBehaviour
{
    private int torchCount = 0;
    private int torchOn = 0;
    private void Start()
    {
        torchCount = GameObject.FindObjectsOfType<A_Torch>().Length;
    }

    public void AddLightTorch()
    {
        torchOn++;
        if(torchOn == torchCount)
        {
            OpenDoor();
        }
    }

    public void OpenDoor()
    {
        //ToDo Open Door
        Debug.Log("OpenDoor");
    }
}
