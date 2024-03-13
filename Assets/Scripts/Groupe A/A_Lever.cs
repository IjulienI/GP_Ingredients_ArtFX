using UnityEngine;

public class A_Lever : Interactive
{
    public bool open;
    [SerializeField] private bool once = true;
    private bool used;
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
        if(open && !used)
        {
            if(once)
            {
                used = true;
            }
            GetComponent<A_LeverInteract>().Activate();
        }
    }
    private void Update()
    {
        if (open)
        {
            transform.GetChild(1).localRotation = Quaternion.Lerp(transform.GetChild(1).localRotation,Quaternion.Euler(45,0,0),.02f);
        }
        else
        {
            transform.GetChild(1).localRotation = Quaternion.Lerp(transform.GetChild(1).localRotation, Quaternion.Euler(-45, 0, 0), .02f);
        }
    }
    public void ResetLever()
    {
        open = false;
        used = false;
        interactionType = InteractionType.PushButton;
    }
}