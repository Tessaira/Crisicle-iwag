using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGod : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private float gap;
    [SerializeField] private GameObject icicle;
    [SerializeField] private GameObject player;
    [SerializeField] private float yOffsetGround, groundSize, yOffsetIcicle;
    [SerializeField] private ObjectMovement objectMovement;
    

    private void SpawnLayer()
    {
        GameObject tempGround = Instantiate(
            ground,
            new Vector3(player.transform.position.x + groundSize + gap, player.transform.position.y - yOffsetGround, 0),
            Quaternion.identity);
        objectMovement.MovingObjects.Add(tempGround);

        GameObject tempIcicle = Instantiate(
            icicle,
            new Vector3(player.transform.position.x + groundSize / 2 + gap / 2, player.transform.position.y + yOffsetIcicle, 0),
            Quaternion.identity);
        objectMovement.MovingObjects.Add(tempIcicle);
    }

    private void Start()
    {
        SpawnStartingObjects();
        SpawnLayer();
    }

    private void SpawnStartingObjects ()
    {
        GameObject tempGround = Instantiate(
           ground,
           new Vector3(player.transform.position.x, player.transform.position.y - yOffsetGround, 0),
           Quaternion.identity);
        objectMovement.MovingObjects.Add(tempGround);
    }
}