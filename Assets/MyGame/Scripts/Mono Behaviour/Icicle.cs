using UnityEngine;

public class Icicle : MonoBehaviour
{
    private int clickAmount;

    [SerializeField] private GameObject dropStop;
    [SerializeField] private int minClickAmount, maxClickAmount;

    private void OnMouseDown()
    {
        if (clickAmount > 0)
        {
            clickAmount--;
        }
        else if (clickAmount <= 0)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().isKinematic = false;
            dropStop.SetActive(true);
        }
        Debug.Log(clickAmount);
    }

    private void Start()
    {
        clickAmount = Random.Range(minClickAmount, maxClickAmount +1);
    }
}