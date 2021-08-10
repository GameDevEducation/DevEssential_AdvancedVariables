using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConfigData
{
    public float VolumeLevel;
}

public class CustomDataDemo : MonoBehaviour
{
    [SerializeField] ConfigData Config;
    [SerializeField] List<ConfigData> Configurations;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
