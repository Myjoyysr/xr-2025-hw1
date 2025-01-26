using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float xAngle, yAngle, zAngle;

    public GameObject objectToRotate;



    // Update is called once per frame
    void Update()
    {
        objectToRotate.transform.Rotate(xAngle* Time.deltaTime,yAngle* Time.deltaTime,zAngle * Time.deltaTime, Space.Self);
    }
}

