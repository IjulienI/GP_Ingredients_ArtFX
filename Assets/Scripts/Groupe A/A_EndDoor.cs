using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A_EndDoor : Interactive
{
    [SerializeField] private string nextLevel;
    public override void OnInteraction()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
