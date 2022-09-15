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
using MoralisUnity;
using Nethereum.Hex.HexTypes;
using Pixelplacement;
using TMPro;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using Hexlibrium;
using UnityEngine;
using Pixelplacement;



namespace HEXLIBRIUM
{
    

    public class H05 : State
    {
        private void OnEnable()
        {
            StateMachineManager.instance.MintingMetaverseItem();
        }
    }
}