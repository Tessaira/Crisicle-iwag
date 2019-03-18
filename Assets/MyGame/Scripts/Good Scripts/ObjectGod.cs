using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGod : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private float gap;
    [SerializeField] private GameObject icicle;
    [SerializeField] private GameObject player;
    [SerializeField] private float yOffsetGround;

    private void SpawnLayer()
    {
        GameObject tempGround = Instantiate(
            ground,
            new Vector3(player.transform.position.x + ground.GetComponent<BoxCollider2D>().size.x * 2 + gap, player.transform.position.y - yOffsetGround, 0),
            Quaternion.identity);
    }

    private void Start()
    {
        SpawnLayer();
    }
}