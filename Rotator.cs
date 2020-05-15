using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int speed = 1;

    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        // transform.Rotate(Vector3.right * Time.deltaTime);

        // Rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
    }
}