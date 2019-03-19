using UnityEngine;
using UnityEngine.SceneManagement;

public class DropStopScript : MonoBehaviour
{
    public GameObject walkCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);

        if (collision.CompareTag(GlobalVariables.icicle))
        {
            collision.GetComponentInParent<Rigidbody2D>().simulated = false;
            collision.GetComponent<BoxCollider2D>().enabled = false;

            walkCollider.SetActive(true);
        }
        else if (collision.CompareTag(GlobalVariables.player))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}