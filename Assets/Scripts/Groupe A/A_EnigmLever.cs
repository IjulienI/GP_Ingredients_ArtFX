using UnityEngine;

public class A_EnigmLever : A_LeverInteract
{
    [SerializeField] private int leverIndex;
    private A_EnignManager _enignManager;
    private void Start()
    {
        _enignManager = GameObject.Find("EnigmManager").GetComponent<A_EnignManager>();
    }
    public override void Activate()
    {
        _enignManager.FirstEnigm(leverIndex);
    }

    public int GetIndex()
    {
        return leverIndex;
    }
}