using UnityEngine;

public class A_Lever : Interactive
{
    public bool open;
    [SerializeField] private bool once = true;
    public override void OnInteraction()
    {
        if(once)
        {
            open = true;
            interactionType = InteractionType.FailedAction;
        }
        else
        {
            open = !open;
        }
        if(open)
        {
            GetComponent<A_LeverInteract>().Activate();
        }
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
