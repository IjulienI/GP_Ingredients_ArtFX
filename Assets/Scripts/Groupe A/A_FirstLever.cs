using UnityEngine;

public class A_FirstLever : A_LeverInteract
{
    [SerializeField] private GameObject cylinder;
    public override void Activate()
    {
        cylinder.GetComponent<Animator>().SetTrigger("Activate");
    }
}
