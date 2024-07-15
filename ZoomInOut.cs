using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
    public float zoomSpeed = 1.0f;
    public float minZoomDistance = 1.0f;
    public float maxZoomDistance = 10.0f;

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(0, 0, scroll * zoomSpeed, Space.Self);

        Vector3 currentPosition = transform.position;
        currentPosition.z = Mathf.Clamp(currentPosition.z, -maxZoomDistance, -minZoomDistance);
        transform.position = currentPosition;
    }
}
