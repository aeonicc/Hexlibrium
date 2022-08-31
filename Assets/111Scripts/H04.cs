using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using HEXLIBRIUM;
using UnityEngine;
using MoralisUnity.Platform.Objects;
//using Unity.VisualScripting;
using StateMachine = Pixelplacement.StateMachine;

using System;
using Cysharp.Threading.Tasks;
using Hexlibrium;
using MoralisUnity;
using Nethereum.Hex.HexTypes;
using Pixelplacement;
using TMPro;
using UnityEngine;


namespace HEXLIBRIUM
{
    

    public class H04 : State
    {
      

        public void OnEnable()
        {
            Hhh04();
        }

        public void Update()
        {
            for (int i = 0; i <= 5; i++)
            {
                //_buttons. 
            
            }
        }

        public void Hhh04()
        {
            // BossController.instance.DamageBoss();
            //BossController.instance.currentPhase = BossController.BossPhase.end;
            // StateMachineManager.instance.MintingMetaverseItem();
            //StateMachineManager.instance.Hh05();
           StartCoroutine(CallYinYang());
        }
        
        public IEnumerator CallYinYang()
        {
            
            yield return new WaitForSeconds(4f);
            
            Board.instance.YinYanForm();
            
            StateMachineManager.instance.MintingMetaverseItem();
        }
    }
}