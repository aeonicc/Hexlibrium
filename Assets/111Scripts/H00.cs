using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using Hexlibrium;

namespace HEXLIBRIUM
{
    

public class H00 : State
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        StateMachineManager.instance.playerCamera.gameObject.SetActive(true);
        StateMachineManager.instance.boardCamera.gameObject.SetActive(false);
        StateMachineManager.instance.theFiveButtons.gameObject.SetActive(false);
    }
}
}