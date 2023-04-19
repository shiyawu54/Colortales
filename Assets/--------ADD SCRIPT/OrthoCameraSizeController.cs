using UnityEngine;
using System.Collections;

public class OrthoCameraSizeController : MonoBehaviour
{
    public float targetSize = 10.0f;
    public float transitionSpeed = 2.0f;

    new private Camera camera; // Use the 'new' keyword to explicitly hide the inherited 'camera' member

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Mathf.Abs(camera.orthographicSize - targetSize) > 0.01f)
        {
            StartCoroutine(SmoothSizeTransition());
        }
    }

    private IEnumerator SmoothSizeTransition()
    {
        while (Mathf.Abs(camera.orthographicSize - targetSize) > 0.01f)
        {
            camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, targetSize, transitionSpeed * Time.deltaTime);

            yield return null;
        }
    }
}