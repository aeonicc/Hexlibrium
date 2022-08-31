using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.LookDev;

public class TimeController : MonoBehaviour
{
    [SerializeField] private float timeMultiplier;
    [SerializeField] private float StartHour;
    [SerializeField] private GameObject sky;
    [SerializeField] private Material skybox;
    [SerializeField] private Light[] _lights;
    private float timeCounter;
    private static bool lerpBool;
    public float time;

    public static TimeController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        sky = gameObject;
        skybox = sky.GetComponent<MeshRenderer>().materials[0];
    }

    private void Update()
    {
        
        if (lerpBool)
        {
            var ColorCurrent = skybox.GetColor("_Color");
            StartCoroutine(ChangeSkybox(skybox, ColorCurrent));
        }
        UpdateTimeOfDay();
    }

    public void ActivateTimeChange()
    {
        timeCounter = 0;
        lerpBool = true;
    }

    // Update is called once per frame
    void UpdateTimeOfDay()
    {
       time += Time.deltaTime * timeMultiplier;

    }

    public IEnumerator ChangeSkybox(Material skybox, Color ColorCurrent)
    {
        timeCounter += Time.deltaTime * timeMultiplier;
        foreach (var light in _lights)
        {
            light.intensity = Mathf.Lerp(0, 1, timeCounter);
        }
        skybox.color = Color.Lerp(ColorCurrent, Color.cyan, timeCounter);
        if (timeCounter >= 1)
        {
            lerpBool = false;
        }

        yield return null;
    }

    public void StopTheGrayWorld()
    {
        Debug.Log("a");
    }

    void MoveSunAndMoon()
    {
        
    }
}
