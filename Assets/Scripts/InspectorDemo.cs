using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorDemo : MonoBehaviour
{
    [Header("Intensity Control")]
    [Range(0f, 10f)] [Tooltip("Controls the intensity of something (0-10 range)")] public float Intensity;

    [Header("Colour Control")]
    [SerializeField] [ColorUsage(false, true)] Color TintColour;

    [Header("Debug Options")]
    [SerializeField] bool Debug_Enable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
