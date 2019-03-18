using UnityEngine;

public class Icicle : MonoBehaviour
{
    private float clickAmount;
    private Camera cam;

    [SerializeField] private float minClickAmount, maxCLickAmount;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

        Debug.Log()
    }


}