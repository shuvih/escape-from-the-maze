using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public void open()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
    }
}
