using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiboxMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float skyboxSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxSpeed);
    }
}
