using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private void Update ()
    {
        transform.position += new Vector3(-1 * GlobalVariables.objectMovingSpeed, 0 , 0);
    }
}
