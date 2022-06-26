using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiboxMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float skyboxSpeed = 1f;
    [SerializeField] public float timeMultiplier = 1;
    [SerializeField] public GameObject sun;
    [HideInInspector] public Light sunLight;

    void Start()
    {
        //sun = gameObject;
        //sunLight = gameObject.GetComponent<Light>();
    }
    // Update is called once per frame
    void Update()
    {
        //RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxSpeed);
        //SunUpdate();
    }
    public void SunUpdate()
    {
        sun.transform.localEulerAngles = new Vector3(Time.time * timeMultiplier, -30, 0);
    }
}
