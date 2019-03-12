using UnityEngine;

public class Icicle : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    private int health = 5;
    private string mouse1Input = "Fire1";

    private void Start ()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

	void Update ()
    {
        if (Input.GetButtonDown(mouse1Input))
        {
            Debug.Log ("hdioaghasdfioghiosdfgh");
            health--;
            if(health == 0)
            {
                myRigidbody2D.simulated = true;
            }
        }
	}
}
