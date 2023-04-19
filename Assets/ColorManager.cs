using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    private Material material;
    public Color color;
    public float intensity = 1;
    public GameObject gameObject;// The gameobject that will change color
    private Renderer renderer;
    public float Red;
    public float Green;
    public float Blue;
    public float Hue;
    public float Saturation;
    public float Value;
    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();//
        material = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        color = new Color(Red / 255f, Green / 255f, Blue / 255f);
        //color = Color.HSVToRGB(Hue, Saturation, Value);
        material.SetColor("_EmissionColor",color*intensity);
    }
}
