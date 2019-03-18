using UnityEngine;

public class DropStopScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);

        if (collision.CompareTag(GlobalVariables.icicle))
        {
            collision.GetComponentInParent<Rigidbody2D>().simulated = false;
        }
    }
}