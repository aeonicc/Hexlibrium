﻿using System.Collections;
using System.Collections.Generic;
using Hexlibrium;
using Unity.VisualScripting;
using UnityEngine;


public class BE2_TargetObjectSpacecraft3D : BE2_TargetObject
{
    GameObject _bullet;
    
    public Transform Transform => transform;

    //
   
    //The currently selected unit.
    public static Hybe selectedUnit;
    [Tooltip("The instance of the HexSphere which this unit resides on")]
    public Hexsphere parentPlanet;
    [Tooltip("How quickly this unit moves between tiles")]
    public float moveSpeed;
    [Tooltip("The reference to the tile on which this unit currently resides")]
    public TileHex currentTile;

    public bool moving;

    void Awake()
    {
        _bullet = transform.GetChild(transform.childCount-1).gameObject;
        
        Debug.Log(this.gameObject);
    }

    public void moveOnPath(Stack<TileHex> path)
    {
        StartCoroutine ("move", path);
    }

    public IEnumerator move(Stack<TileHex> path)
    {
        moving = true;
        //Pop the first tile from the stack as it is the one we are currently on
        currentTile = path.Pop ();
        Vector3 lastPos = transform.position;
        //Pop off the tiles in the path and move to each one
        while (path.Count > 0)
        {
            TileHex next = path.Pop();
            //Vector3 currentPos = transform.position - parentPlanet.transform.position;
            Vector3 currentPos = transform.position;
            float t = 0f;
            //Spherically Interpolate current position to the next position

            while(t < 1f)
            {
                t += Time.deltaTime * moveSpeed;
                Vector3 vSlerp = Vector3.Slerp(currentPos, next.FaceCenter, t);
                transform.position = vSlerp;
                Vector3 lookDir = transform.position - lastPos;
                //Correct rotation to keep transform forward aligned with movement direction and transform up aligned with tile normal
                transform.rotation = Quaternion.LookRotation(lookDir, transform.position - parentPlanet.transform.position);
                lastPos = transform.position;
                yield return new WaitForSeconds(Time.deltaTime);
            }
            //Assign the unit's current tile when it has finished interpolating to it.
            currentTile = next;
        }
        moving = false;
    }
   //

    //void Start()
    //{
    //
    //}

    //void Update()
    //{
    //
    //}

    public void Mining()
    {
        StateMachineManager.instance.MiningGold();
    }

 

    public void Shoot()
    {
        GameObject newBullet = Instantiate(_bullet, _bullet.transform.position, Quaternion.identity);
        newBullet.SetActive(true);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        StartCoroutine(C_DestroyTime(newBullet));
    }
    IEnumerator C_DestroyTime(GameObject go)
    {
        yield return new WaitForSeconds(1f);
        Destroy(go);
    }
}
