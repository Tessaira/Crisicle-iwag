using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public GameObject[] MovingObjects;

    private void Update ()
    {
        foreach (GameObject singleObject in MovingObjects)
        {
            singleObject.transform.position += new Vector3(-1 * GlobalVariables.objectMovingSpeed, 0 , 0);
        }
    }
}
