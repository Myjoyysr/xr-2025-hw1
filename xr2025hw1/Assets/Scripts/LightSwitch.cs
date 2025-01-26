using UnityEngine;
using UnityEngine.InputSystem;


public class LightSwitch : MonoBehaviour
{
    public InputActionReference action;
    public Light light;

    new bool swithOn = false;

    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (swithOn == true){
                light.color = Color.white;
                swithOn = false;
            }else{
                light.color = Color.red;
                swithOn = true;
            }
            
        };
    }
}
