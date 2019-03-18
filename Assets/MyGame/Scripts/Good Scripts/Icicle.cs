using UnityEngine;

public class Icicle : MonoBehaviour
{
    private float clickAmount;

    [SerializeField] private float minClickAmount, maxCLickAmount;

    private void OnMouseDown()
    {
        clickAmount--;
        Debug.Log(clickAmount);
    }
}