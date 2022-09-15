using System;
using System.Collections;
using System.Collections.Generic;
using Hexlibrium;
using UnityEngine;
using Pixelplacement;

namespace HEXLIBRIUM
{
    public class H01 : State
    {
       
        private void Awake()
        {
            
           
        }

        private void Start()
        {
            
        }

        public void Update()
        {
            
            Interface();
            
        }

        public void Interface()
        {
            StateMachineManager.instance.playerCamera.gameObject.SetActive(true);
            StateMachineManager.instance.boardCamera.gameObject.SetActive(false);
            StateMachineManager.instance.theFiveButtons.gameObject.SetActive(false);

            StartCoroutine(Lines());
        }

        public static IEnumerator Lines()
        {

            
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h0;
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h1;
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h2;
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h3;
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h4;
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h5;
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h6;
            yield return new WaitForSeconds(2f);
            H_Lines.instance.currentLine = H_Lines.LinesPhase.h7;






        }
    }
    
    
 
}