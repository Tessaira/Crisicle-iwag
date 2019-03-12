using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag(GlobalVariables.icicle) && col.collider.CompareTag(GlobalVariables.ground))
        {
            Destroy(col.gameObject);
        }
    }
}
