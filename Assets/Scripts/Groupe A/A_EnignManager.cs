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
    private void Start()
    {
        _player = GameObject.Find("Man");
        _infoCamera = GameObject.Find("InfoCamera");
        _infoCamera.SetActive(false);
        torchCount = GameObject.FindObjectsOfType<A_Torch>().Length;
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
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i].OpenDoor();
            }
        }
        
    }
}