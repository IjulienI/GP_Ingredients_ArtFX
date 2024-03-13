using UnityEngine;

public class A_EnignManager : MonoBehaviour
{
    private int leverIndex = 1;
    [SerializeField] private A_Lever[] levers;
    private GameObject _player;
    private GameObject _infoCamera;
    private void Start()
    {
        _player = GameObject.Find("Man");
        _infoCamera = GameObject.Find("InfoCamera");
        _infoCamera.SetActive(false);
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
            Invoke(nameof(EndAnim), 3);
        }
    }

    private void EndAnim()
    {
        _player.transform.GetChild(2).gameObject.SetActive(true);
        _infoCamera.SetActive(false);       
    }
}