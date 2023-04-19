using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [Tooltip("The material that's switched to.")]
    public Material redMaterial = null;
    public Material orangeMaterial = null;
    public Material yellowMaterial = null;
    public Material greenMaterial = null;
    public Material cyanMaterial = null;
    public Material blueMaterial = null;
    public Material magentaMaterial = null;

    private bool usingOther = false;
    private MeshRenderer meshRenderer = null;
    private Material originalMaterial = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

    public void SetRedMaterial()
    {
        usingOther = true;
        meshRenderer.material = redMaterial;
    }

    public void SetOrangeMaterial()
    {
        usingOther = true;
        meshRenderer.material = orangeMaterial;
    }

    public void SetYellowMaterial()
    {
        usingOther = true;
        meshRenderer.material = yellowMaterial;
    }

    public void SetGreenMaterial()
    {
        usingOther = true;
        meshRenderer.material = greenMaterial;
    }

    public void SetCyanMaterial()
    {
        usingOther = true;
        meshRenderer.material = cyanMaterial;
    }

    public void SetBlueMaterial()
    {
        usingOther = true;
        meshRenderer.material = blueMaterial;
    }

    public void SetMagentaMaterial()
    {
        usingOther = true;
        meshRenderer.material = magentaMaterial;
    }

    public void SetOriginalMaterial()
    {
        usingOther = false;
        meshRenderer.material = originalMaterial;
    }

    public void ToggleMaterial()
    {
        usingOther = !usingOther;

        if (usingOther)
        {
            meshRenderer.material = blueMaterial;
        }
        else
        {
            meshRenderer.material = originalMaterial;
        }
    }
}