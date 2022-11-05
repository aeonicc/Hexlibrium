using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HEXLIBRIUM
{
    public class HexagramObject
    {
        
        [SerializeField] private List<GameObject> vertex = new List<GameObject>();
        [SerializeField] private List<GameObject> edges = new List<GameObject>();
        [SerializeField] private List<GameObject> faces = new List<GameObject>();
        
        [SerializeField] private List<GameObject> lines = new List<GameObject>();
        
        private int ballsCount = 0;
        
    }
}