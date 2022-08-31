using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationDemo : MonoBehaviour
{
    public MobileUnit Unit;
    
	// Use this for initialization
	void Start ()
    {
        TileHex.OnTileClickedAction += OnTileClicked;
	}
	

    public void OnTileClicked(TileHex tile)
    {
        if(!Unit.moving)
        {
            Stack<TileHex> path;
            if(Hexsphere.planetInstances[0].navManager.findPath(Unit.currentTile, tile, out path))
            {
                Unit.moveOnPath(path);
            }
        }
    }
}
