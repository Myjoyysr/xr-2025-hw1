using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportTo : MonoBehaviour
{
    public InputActionReference action;
    public GameObject spawnPointA;
    public GameObject spawnPointB;
    public GameObject player;
    private int location = 0;


    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (location == 0){
                player.transform.position = spawnPointB.transform.position;
                player.transform.rotation = spawnPointB.transform.rotation;
                location = 1;
            }else{
                player.transform.position = spawnPointA.transform.position;
                player.transform.rotation = spawnPointA.transform.rotation;
                location = 0;
            }
            
        };
    }

}
