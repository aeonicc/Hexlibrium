using System;
using System.Collections;
using System.Collections.Generic;
using HEXLIBRIUM;
using UnityEngine;
using MoralisUnity.Platform.Objects;
using Unity.VisualScripting;
using UnityEngine.UI;
using StateMachine = Pixelplacement.StateMachine;
using Update = UnityEngine.PlayerLoop.Update;
    
namespace Hexlibrium
{
    
    #region DATA_CLASSES

    // public class DatabaseItem : MoralisObject
    // {
    //     public string metadata { get; set; }
    //     public DatabaseItem() : base("DatabaseItem") {}
    // }
    //
    // public class MetadataObject
    // {
    //     public string name;
    //     public string description;
    //     public string image;
    // }

    #endregion
    

public class StateMachineManager : StateMachine
{
    
    public Camera playerCamera;
    public Camera boardCamera;
    public GameObject theFiveButtons;

    // public GameObject buttonHeath;
    // public GameObject buttonCrystal;
    // public GameObject buttonCoin;

    public GameObject theBoss;

    public GameObject hLines;

    
    
    public static StateMachineManager instance;
    
   
    
    private void Awake()
    {
        instance = this;
    }

    public void Update()
    {
        // var _time = Time.time;
        // Debug.Log(_time);
        
        // for (int i = 0; i <= 5; i++)
        // {
        //     var io = io++;
        //     Debug.Log(io);
        // }
        
        // var time = DateTime.Now.Ticks;
        // Debug.Log(time);
    }
    // public void OnStateEnteredHandler(GameObject stateEntered)
    // {
    //     switch (stateEntered.name)
    //     {
    //         case "Authenticating":
    //             //player.input.EnableInput(false);
    //             break;
    //             
    //         case "Instantiating":
    //             //player.input.EnableInput(true);
    //             break;
    //             
    //         case "Menu":
    //             //player.input.EnableInput(false);
    //             break;
    //             
    //         case "ConsumingPowerUp":
    //             //player.input.EnableInput(false);
    //             break;
    //             
    //         case "PoweredUp":
    //             //player.input.EnableInput(true);
    //
    //             //audioSource.clip = powerUpClip;
    //             //audioSource.Play();
    //             break;
    //     }
    // }
        
    // public void OnStateExitedHandler(GameObject stateExited)
    // {
    //     switch (stateExited.name)
    //     {
    //         case "Authenticating":
    //             break;
    //             
    //         case "Exploring":
    //             break;
    //             
    //         case "Menu":
    //             break;
    //             
    //         case "ConsumingPowerUp":
    //             break;
    //             
    //         case "PoweredUp":
    //             //audioSource.clip = powerDownClip;
    //             //audioSource.Play();
    //             break;
    //     }
    // }


    public void StartGame()
    {
        
        //player.walletAddress.Activate()
        ChangeState("H01");
    }
    
    //public void GoToAuthenticating()
    //{
        //player.walletAddress.Deactivate();
        //ChangeState("Authenticating");
    //}
    
    //private void RespawnPlayer()
    //{
        //player.gameObject.SetActive(false);
        //player.transform.position = player.initPos;
        //player.gameObject.SetActive(true);
    //}
    
    //private void GoToConsumingPowerUp() //InventoryItem selectedPowerUp
    //{
        // We save the current selected item (NFT PowerUp)
        //currentPowerUp = selectedPowerUp;

        // We change to the state that will take care of the burning transaction
        //ChangeState("ConsumingPowerUp");
    //}
    
    // public void SetCurrentLootBox(GameObject obj)
    // {
    //     //currentLootBox = obj;
    // }
    //
    // public GameObject GetCurrentLootBox()
    // {
    //     if (currentLootBox is null)
    //     {
    //         Debug.Log("No loot box spawned!");
    //         return null;
    //     }
    //     
    //     return currentLootBox;
    // }[
    public void MintingCoin()
    {
        //player.walletAddress.Deactivate();
        ChangeState("MintingCoin");
    }
    
    public void MintingMetaverseItem()
    {
        Debug.Log("message");
    //player.walletAddress.Deactivate();
        ChangeState("MintingMetaverseItem");
    }
    
    public void Hh01()
    {
        ChangeState("H01");
    }
    
    public void Hh02()
    {
        ChangeState("H02");
    }
    
    public void Hh03()
    {
        ChangeState("H03");
    }


    public void Hh04()
    {
        ChangeState("H04");
    }
    
    public void Hh05()
    {
        ChangeState("H05");
    }
    
    public void Hh06()
    {
        ChangeState("H06");
    }

    public void MintingRandomNumber()
    {
        ChangeState("MintingRandomNumber");
    }


    public void Hh64()
    {
        ChangeState("H64");
    }
}
}