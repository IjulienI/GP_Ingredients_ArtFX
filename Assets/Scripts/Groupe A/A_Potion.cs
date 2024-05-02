using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A_Potion : Interactive
{
    [SerializeField] private Vector2 position;
    [SerializeField] private bool deleteSystem32;
    public override void OnInteraction()
    {
        if (deleteSystem32)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            GameObject player = GameObject.FindAnyObjectByType<PlayerController>().gameObject;
            player.transform.position = new Vector3(position.x, player.transform.position.y, position.y);
        }
    }
}