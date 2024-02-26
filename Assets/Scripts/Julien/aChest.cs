using UnityEngine;

public class aChest : Interactive
{
    private int TorchOn = 0;
    public override void OnInteraction()
    {
        GetComponent<Animator>().SetTrigger("Open");
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void AddTorch()
    {
        TorchOn++;
        if(TorchOn == 3)
        {
            gameObject.GetComponent<SphereCollider>().enabled = true;
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
        }
    }
}