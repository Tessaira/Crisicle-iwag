using UnityEngine;
using System.Collections.Generic;
public class ObjectMovement : MonoBehaviour
{
    public List<GameObject> MovingObjects;

    [SerializeField] private float objectSpeed = 0.05f;

    private void Update ()
    {
        foreach (GameObject singleObject in MovingObjects)
        {
            singleObject.transform.position += new Vector3(-1 * objectSpeed, 0 , 0);
        }
    }
}
