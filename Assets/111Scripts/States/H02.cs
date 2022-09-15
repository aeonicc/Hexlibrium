using System.Collections;
using System.Collections.Generic;
using Hexlibrium;
using UnityEngine;
using Pixelplacement;

namespace HEXLIBRIUM
{
    public class H02 : State
    {
        public void Awake()
        {
            Hhh02();
        }

        public void Update()
        {
         
        }

        public void Hhh02()
        {
            StateMachineManager.instance.playerCamera.gameObject.SetActive(false);
            StateMachineManager.instance.boardCamera.gameObject.SetActive(true);
            StateMachineManager.instance.theFiveButtons.gameObject.SetActive(true);
            
           UIManager.instance.crystalButton.gameObject.SetActive(false);
           UIManager.instance.coinButton.gameObject.SetActive(false);
           
           StateMachineManager.instance.theBoss.SetActive(true);
           
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
