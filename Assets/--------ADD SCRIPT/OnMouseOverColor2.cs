using UnityEngine;

public class OnMouseOverColor2 : MonoBehaviour
{
    [Tooltip("The color to use when the mouse is over the object.")]
    public Color mouseOverColor = Color.red;

    [Tooltip("The RGB value to use when the mouse is over the object.")]
    public Vector3 rgbValue = new Vector3(1f, 0f, 0f);

    private Color originalColor;
    private MeshRenderer renderer;

    private void Start()
    {
        // Cache the MeshRenderer component.
        renderer = GetComponent<MeshRenderer>();

        // Cache the original color of the object.
        originalColor = renderer.material.color;
    }

    private void OnMouseEnter()
    {
        // Change the color of the object to the mouseOverColor or the RGB value entered in the inspector.
        renderer.material.color = mouseOverColor != Color.red ? mouseOverColor : new Color(rgbValue.x, rgbValue.y, rgbValue.z);
    }

    private void OnMouseExit()
    {
        // Reset the color of the object to its original color.
        renderer.material.color = originalColor;
    }
}


