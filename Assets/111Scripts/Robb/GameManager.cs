﻿using System.Collections;
using System.Collections.Generic;
using Hexlibrium;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HEXLIBRIUM
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        
        private Vector3 respawnPosition;

        public GameObject deathEffect;

        public int currentCoins;
        
        public int currentYinYang;
        
        public int currentCrystals;

        public int levelEndMusic = 8;

        public string levelToLoad;

        public bool isRespawning;

        public GameCoin gameCoin;
        
        [SerializeField] GameObject player;

        public Camera _camera;

        private void Awake()
        {
            instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            Cursor.visible = true;
           Cursor.lockState = CursorLockMode.None;

        //respawnPosition = PlayerController.instance.transform.position;
        //respawnPosition = player.transform.position = new Vector3(0, 0, 0);

        AddCoins(0);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseUnpause();
            }
        }

        public void Respawn()
        {
            StartCoroutine(RespawnCo());

            HealthManager.instance.PlayerKilled();
        }

        public IEnumerator RespawnCo()
        {
            //PlayerController.instance.gameObject.SetActive(false);

            //CameraController.instance.theCMBrain.enabled = false;

            UIManager.instance.fadeToBlack = true;

            //Instantiate(deathEffect, PlayerController.instance.transform.position + new Vector3(0f, 1f, 0f), PlayerController.instance.transform.rotation);

            yield return new WaitForSeconds(2f);

            isRespawning = true;

            HealthManager.instance.ResetHealth();

            UIManager.instance.fadeFromBlack = true;

            //PlayerController.instance.transform.position = respawnPosition;
            

            //CameraController.instance.theCMBrain.enabled = true;

            //PlayerController.instance.gameObject.SetActive(true);

            player.transform.localPosition = new Vector3(0, 60, 0);
        }

        public void SetSpawnPoint(Vector3 newSpawnPoint)
        {
            respawnPosition = newSpawnPoint;
            Debug.Log("Spawn Point Set");
        }

        public void AddCoins(int coinsToAdd)
        {
            currentCoins += coinsToAdd;
            UIManager.instance.coinText.text = "" + currentCoins;

            if (currentCoins == 100)
            {
                UIManager.instance.ActivateButton();
                //StateMachineManager.instance.MintingCoin();
            }
        }
        
        public void AddGold(int goldToAdd)
        {
            // currentCoins += goldToAdd;
            // UIManager.instance.coinText.text = "" + currentCoins;
            //
            // if (currentCoins == 100)
            // {
            //     UIManager.instance.ActivateButton();
            //     //StateMachineManager.instance.MintingCoin();
            // }
        }
        
    
        public void SeedCamera()
        {
            _camera.GameObject().SetActive(true);
        }

        public void PauseUnpause()
        {
            if (UIManager.instance.pauseScreen.activeInHierarchy)
            {
                UIManager.instance.pauseScreen.SetActive(false);
                Time.timeScale = 1f;

                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                UIManager.instance.pauseScreen.SetActive(true);
                UIManager.instance.CloseOptions();
                Time.timeScale = 0f;

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        public IEnumerator LevelEndCo()
        {
            AudioManager.instance.PlayMusic(levelEndMusic);
            PlayerController.instance.stopMove = true;

            yield return new WaitForSeconds(2f);

            UIManager.instance.fadeToBlack = true;

            yield return new WaitForSeconds(2f);
            Debug.Log("Level Ended");


            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_unlocked", 1);

            if (PlayerPrefs.HasKey(SceneManager.GetActiveScene().name + "_coins"))
            {
                if (currentCoins > PlayerPrefs.GetInt(SceneManager.GetActiveScene().name + "_coins"))
                {
                    PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_coins", currentCoins);
                }
            }
            else
            {
                PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_coins", currentCoins);
            }

            SceneManager.LoadScene(levelToLoad);
        }
    }
}