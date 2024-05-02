using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class A_ScriptedDoor : MonoBehaviour
{
    private bool open;

    public void OpenDoor()
    {
        open = true;
    }
    void Update()
    {
        if (open)
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 150, 0), .02f);
        }
        else
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 90, 0), .02f);
        }
    }
}
