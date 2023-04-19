using UnityEngine;
using UnityEngine.Events;

public class OnMouseOverEvent : MonoBehaviour
{
    [Tooltip("Event invoked when the mouse enters the object.")]
    public UnityEvent onMouseEnterEvent;

    [Tooltip("Event invoked when the mouse leaves the object.")]
    public UnityEvent onMouseExitEvent;

    private void OnMouseEnter()
    {
        // Invoke the onMouseEnterEvent.
        onMouseEnterEvent.Invoke();
    }

    private void OnMouseExit()
    {
        // Invoke the onMouseExitEvent.
        onMouseExitEvent.Invoke();
    }
}