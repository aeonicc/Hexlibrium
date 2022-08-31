using System;
using System.Collections;
using System.Collections.Generic;
using Hexlibrium;
using UnityEngine;
using Pixelplacement;

namespace HEXLIBRIUM
{
    public class H03 : State
    {
        public void Awake()
        {
            
        }

        public void Start()
        {
            
        }

        public void OnEnable()
        {
            Hhh03();
        }

        public void Update()
        {
            for (int i = 0; i <= 5; i++)
            {
                //_buttons. 
            
            }
            
        }

        public void Hhh03()
        {
            StateMachineManager.instance.playerCamera.gameObject.SetActive(true);
            StateMachineManager.instance.boardCamera.gameObject.SetActive(false);
            StateMachineManager.instance.theFiveButtons.gameObject.SetActive(false);
            
            UIManager.instance.crystalButton.gameObject.SetActive(true);
            UIManager.instance.coinButton.gameObject.SetActive(true);
            
            //TimeController.instance.ActivateTimeChange();
            
            //BossController.instance.DamageBoss();
            BossController.instance.gameObject.SetActive(false);
            
            StateMachineManager.instance.Hh04();
            
        }

  

    }
    
}
