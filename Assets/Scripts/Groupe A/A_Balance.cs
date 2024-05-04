using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Balance : Interactive
{
    [SerializeField] private int maxSkulls;
    [SerializeField] private GameObject[] _skulls;
    private int skullsCounts = 0;
    private Inventory _inventory;
    public override void OnInteraction()
    {
        skullsCounts++;
        if (skullsCounts == maxSkulls)
        {
            onlyOnce = true;
        }
        _skulls[skullsCounts -1].SetActive(true);
        _inventory.RemoveFromInventory(requiredItems[0]);
        GameObject.FindObjectOfType<A_EnignManager>().AddSkull();
    }

    private void Start()
    {
        for (int i = 0; i < _skulls.Length; i++)
        {
            if (_skulls[i].active == true)
            {
                skullsCounts++;
                if (skullsCounts + 1 == maxSkulls)
                {
                    onlyOnce = true;
                }
            }
        }
        _inventory = Inventory.Instance;
    }

    public int GetSkullsCount()
    {
        return skullsCounts;
    }

    public int GetMaxSkulls()
    {
        return maxSkulls;
    }
}
