using UnityEditor;
using UnityEngine;

public class A_EnignManager : MonoBehaviour
{
    private int leverIndex = 1;
    [SerializeField] private A_Lever[] levers;
    [SerializeField] private A_ScriptedDoor door;
    private GameObject _player;
    private GameObject _infoCamera;
    private int torchCount = 0;
    private int torchOn = 0;

    private A_Balance[] _balances;
    private int skullOn = 0;
    private int maxSkull;
    [SerializeField] private GameObject balanceDoor;
    private void Start()
    {
        _player = GameObject.Find("Man");
        _infoCamera = GameObject.Find("InfoCamera");
        _infoCamera.SetActive(false);
        torchCount = GameObject.FindObjectsOfType<A_Torch>().Length;
        _balances = GameObject.FindObjectsOfType<A_Balance>();
        for (int i = 0; i < _balances.Length; i++)
        {
            maxSkull += _balances[i].GetMaxSkulls();
        }
    }
    public void FirstEnigm(int index)
    {
        if(leverIndex == index)
        {
            leverIndex++;
        }
        else
        {
            leverIndex = 1;
            foreach(A_Lever lever in levers)
            {
                lever.ResetLever();
            }
        }
        if(leverIndex == 7)
        {
            _infoCamera.SetActive(true);
            _player.transform.GetChild(2).gameObject.SetActive(false);
            door.OpenDoor();
            Invoke(nameof(EndAnim), 3);
        }
    }

    private void EndAnim()
    {
        _player.transform.GetChild(2).gameObject.SetActive(true);
        _infoCamera.SetActive(false);       
    }

    public void AddLightTorch()
    {
        torchOn++;
        if(torchOn == torchCount)
        {
            A_BigDoor[] doors = GameObject.FindObjectsOfType<A_BigDoor>();
            Debug.Log(doors.Length);

            _infoCamera.transform.rotation = Quaternion.Euler(_infoCamera.transform.rotation.x, 180, _infoCamera.transform.rotation.z);
            _infoCamera.SetActive(true);
            _player.transform.GetChild(2).gameObject.SetActive(false);
            Invoke(nameof(EndAnim), 3.5f);

            for (int i = 0; i < doors.Length; i++)
            {
                doors[i].OpenDoor();
            }
        }        
    }

    public void AddSkull()
    {
        skullOn = 0;
        for (int i = 0; i < _balances.Length; i++)
        {
            skullOn += _balances[i].GetSkullsCount();
        }
        if (skullOn == maxSkull)
        {
            balanceDoor.GetComponent<Animator>().SetTrigger("open");
        }
    }
}