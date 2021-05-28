using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    [Header("Opacity Parameters")]
    public float maxOpacity;
    public float minOpacity;
    public float opacityStep;

    [Header("Renderer and Material References")]
    public MeshRenderer objectRenderer;
    public Material objectMaretial;

    private Color tempColor;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = gameObject.GetComponent<MeshRenderer>();
        objectMaretial = objectRenderer.material;

        tempColor = new Color(objectMaretial.color.r, objectMaretial.color.g, objectMaretial.color.b, objectMaretial.color.a);
    }

    // Update is called once per frame
    void Update()
    {
        //if opacity has reached the bounds then reverse opacity step
        if (tempColor.a <= minOpacity || tempColor.a >= maxOpacity)
            opacityStep *= -1.0f;
        // add opacity to our tempColor
        tempColor.a += opacityStep;
        objectMaretial.SetColor("_Color", tempColor);
    }
}
