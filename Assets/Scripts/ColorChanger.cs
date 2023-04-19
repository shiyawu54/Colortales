using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects;
    [SerializeField] private Color[] colors;

    public void ChangeColorBasedOnString(string input)
    {
        Debug.Log("ChangeColorBasedOnString called with input: " + input);
        switch (input)
        {
            case "R":
                ChangeColor(colors[0]);
                Debug.Log("ChangeColorRed");
                break;
            case "O":
                ChangeColor(colors[1]);
                break;
            case "Y":
                ChangeColor(colors[2]);
                break;
            case "G":
                ChangeColor(colors[3]);
                break;
            case "C":
                ChangeColor(colors[4]);
                break;
            case "B":
                ChangeColor(colors[5]);
                break;
            case "V":
                ChangeColor(colors[6]);
                break;
            case "U":
            default:
                Debug.Log("Unknown color");
                break;
        }
    }

    private void ChangeColor(Color newColor)
    {
        foreach (GameObject obj in gameObjects)
        {
           Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null && renderer.materials.Length > 0)
            {
                Material material = renderer.materials[0];

                // Enable emission
                material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
                // Set emission color
                material.SetColor("_EmissionColor", newColor);

                Debug.Log("Emission color set for object: " + obj.name + " to color index: " + newColor);
            }
            else
            {
                Debug.LogError("Renderer or materials not found for object: " + obj.name);
            }
        }
    }
}
