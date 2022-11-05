using UnityEngine;
using System;
using UnityEditor.Rendering;
// using Random = System.Random;
using UnityEngine;
using System.Collections;
using System.Linq;
using ExitGames.Client.Photon.StructWrapping;
using Hexlibrium;
using Random = UnityEngine.Random;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Playables;


namespace HEXLIBRIUM
{
    public class Horacle : MonoBehaviour
    {
        
        public string[] hexCompressString = new string[6];
        private int h;
        
        private static readonly int Stunned = Animator.StringToHash("Stunned");
        private static readonly int SwitchToHoverFatherReverse = Animator.StringToHash("SwitchToHoverFatherReverse");
        private static readonly int SwitchToHoverFather = Animator.StringToHash("SwitchToHoverFather");
        private static readonly int StopStunned = Animator.StringToHash("StopStunned");

        public int Player_Choice;
        public int randomButtonCounter;
        public int hexagramEnumLinesState;
        public HexagramData.HexagramEnumLines hexagramLineState;

        public string[] hexSix;

        public string trigramLeftLow;
        public string trigramLeftHigh;
        
        public string trigramRightLow;
        public string trigramRightHigh;
        //public var test;
        
        public GameObject MagicMathMap;
        
        public GameObject Mythic;

        public GameObject Mythic1
        {
            get => Mythic;
            set => Mythic = value;
        }

        public int buttonFive;

        public int buttonEight;

        public int[] five = new int[5]
        {
            1, 2, 3, 4, 5
        };

        public int[] eight = new int[8]
        {
            222, 223, 232, 233, 322, 323, 332, 333
        };

        public int fiveHandRight;
        public int fiveHandLeft;

        public enum YinYang
        {
            YoungYang,
            OldYang,
            YoungYin,
            OldYin
        }

        public YinYang yinyang;
        public enum Elements
        {
            fire,
            earth,
            metal,
            water,
            wood
        }
        
        public enum Math_Results
        {
            Loss,
            Win,
            Got_Stunned,
            Stunned,
            Draw
        }

        public Elements elements; //; = new Elements();

        public enum Trigrams
        {
            sky,
            wind,
            lake,
            fire,
            water,
            mountain,
            earth
        }

        public Trigrams trigrams;
        
        private Matrix4x4 _matrix;
        
       public void RandomButton()
       {
           StartCoroutine(RandomCube());
       }

       public IEnumerator RandomStar()
       {
           yield return new WaitForSeconds(1.0f);
       }

       public IEnumerator RandomCube()
        {
            randomButtonCounter++;

            // if (randomButtonCounter > 5)
            // {
            //     randomButtonCounter = 0;
            // }
            
            HexagramData.instance.hexagramEnumLines = (HexagramData.HexagramEnumLines)randomButtonCounter;
            
            var stageLines = HexagramData.instance.hexagramEnumLines;
      
            if(1 <= randomButtonCounter && randomButtonCounter <= 6)
            {
                // int _eight = Random.Range(1, 8);
                int _four = Random.Range(6, 9);

                switch (_four)
                {
                    case 6:
                        
                        HexagramData.hexagramInputArray[0, randomButtonCounter- 1] = 0;
                        HexagramData.hexagramInputArray[1, randomButtonCounter- 1] = 6;
                        HexagramData.hexagramInputArray[2, randomButtonCounter- 1] = 1;
                        
                        break;
                    case 7:
                        
                        HexagramData.hexagramInputArray[0, randomButtonCounter- 1] = 1;
                        HexagramData.hexagramInputArray[1,randomButtonCounter- 1] = 7;
                        HexagramData.hexagramInputArray[2, randomButtonCounter- 1] = 1;
                        
                        break;
                    case 8:
                        
                        HexagramData.hexagramInputArray[0, randomButtonCounter- 1] = 0;
                        HexagramData.hexagramInputArray[1, randomButtonCounter- 1] = 8;
                        HexagramData.hexagramInputArray[2, randomButtonCounter- 1] = 0;
                        
                        break;
                    case 9:
                        
                        HexagramData.hexagramInputArray[0, randomButtonCounter- 1] = 1;
                        HexagramData.hexagramInputArray[1, randomButtonCounter- 1] = 9;
                        HexagramData.hexagramInputArray[2, randomButtonCounter- 1] = 0;
                        
                        break;
                }
                
                // Debug.Log(HexagramData.hexagramInputArray[0, randomButtonCounter- 1]);
            }
            
            else
            {
                  
                StartCoroutine(RandomMatch());
                randomButtonCounter = 0;  
            }
            
            Debug.Log(randomButtonCounter);
            
            
            
            yield return new WaitForSeconds(1.0f);

        }

       public IEnumerator RandomMatch()
       {
           Debug.Log("randomMatch");

           HexagramData.hexagramProcessArray[0] = (
               HexagramData.hexagramInputArray[0,0],
               HexagramData.hexagramInputArray[0,1],
               HexagramData.hexagramInputArray[0,2],
               HexagramData.hexagramInputArray[0,3],
               HexagramData.hexagramInputArray[0,4],
               HexagramData.hexagramInputArray[0,5]).ToString();
           
           HexagramData.hexagramProcessArray[1] = (
               HexagramData.hexagramInputArray[1,0],
               HexagramData.hexagramInputArray[1,1],
               HexagramData.hexagramInputArray[1,2],
               HexagramData.hexagramInputArray[1,3],
               HexagramData.hexagramInputArray[1,4],
               HexagramData.hexagramInputArray[1,5]).ToString();
           
           HexagramData.hexagramProcessArray[2] = (
               HexagramData.hexagramInputArray[2,0],
               HexagramData.hexagramInputArray[2,1],
               HexagramData.hexagramInputArray[2,2],
               HexagramData.hexagramInputArray[2,3],
               HexagramData.hexagramInputArray[2,4],
               HexagramData.hexagramInputArray[2,5]).ToString();

           HexagramData.hexagramProcessArray[0] = ((HexagramData.hexagramProcessArray[0].Replace(",", "")).Replace("(", "")).Replace(")","");
           HexagramData.hexagramProcessArray[1] = ((HexagramData.hexagramProcessArray[1].Replace(",", "")).Replace("(", "")).Replace(")","");
           HexagramData.hexagramProcessArray[2] = ((HexagramData.hexagramProcessArray[2].Replace(",", "")).Replace("(", "")).Replace(")","");

           

           for (int i = 0; i < 64; i++)
           {
               if ((HexagramData.hexagramStringData[i, 0, 0]) == HexagramData.hexagramProcessArray[0]) //
               {
                   HexagramData.hexagramOutputArray[0,0] = HexagramData.hexagramStringData[i, 0, 0];
                   
               } ;
           }
           
           //middle
           for (int j = 0; j < 64; j++)
           {
               for (int i = 0; i < 6; i++)
               {
                   if (HexagramData.hexagramInputArray[1, i] == 6 || HexagramData.hexagramInputArray[1, i] == 9) //
                   {

                       HexagramData.hexagramOutputArray[1, i] = HexagramData.hexagramStringData[j, 1, i];

                   }

               }
           }

           string s = (HexagramData.hexagramOutputArray[1, 0],
               HexagramData.hexagramOutputArray[1, 1],
               HexagramData.hexagramOutputArray[1, 2],
               HexagramData.hexagramOutputArray[1, 3],
               HexagramData.hexagramOutputArray[1, 4],
               HexagramData.hexagramOutputArray[1, 5]).ToString();
           
           
           for (int i = 0; i < 64; i++)
           {
               if ((HexagramData.hexagramStringData[i, 0, 0]) == HexagramData.hexagramProcessArray[2]) //
               {
                   HexagramData.hexagramOutputArray[2,0] = HexagramData.hexagramStringData[i, 0, 0];
                   
               } ;
           }

          
           // for (int i = 0; i < 6; i++)
           // {
           Debug.Log(HexagramData.hexagramOutputArray[0,0]);
               Debug.Log(s);
               Debug.Log(HexagramData.hexagramOutputArray[2,0]);
           // }
           
           
           yield return new WaitForSeconds(1.0f);

       }
    
        public void Start()
        {
            
            // _matrix.
        }

        public void Update()
        {
            var lineState = (HexagramData.HexagramEnumLines)randomButtonCounter;
            var tetraState = (YinYang)randomButtonCounter;
            
           // Debug.Log(randomButtonCounter);
            
            //Debug.Log(HexagramData.hexagramStringData[0,0]);
            
            switch(yinyang)
            {
                case YinYang.YoungYang:
                    HexagramData.instance.hexagramEnumLines = (HexagramData.HexagramEnumLines)randomButtonCounter;
                    break;
                case YinYang.OldYang:
                    break;
                case YinYang.YoungYin:
                    break;
                case YinYang.OldYin:
                    break;
               
            }
            
            switch (buttonFive)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            
             

            switch (elements)
            {
                case Elements.fire:
                    break;
                case Elements.earth:
                    break;
                case Elements.metal:
                    break;
                case Elements.water:
                    break;
                case Elements.wood:
                    break;
            }

            switch (trigrams)
            {
            }
        }

  
    }
}