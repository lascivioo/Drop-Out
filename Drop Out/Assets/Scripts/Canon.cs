﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public Transform spawnPoint;
    private GameObject clones;
    public GameObject projectilePrefab;
    public float fireRate = 7f;
    private float lastFireTime = 0;
    public bool spawnStart = false;
    void Start()
    {
        spawnStart = false;
    }

   
    void Update()
    {
        Debug.Log(spawnStart);
        if (spawnStart){
            if (Time.time>=lastFireTime+fireRate)
            {
                lastFireTime = Time.time;
                Destroy(Instantiate(projectilePrefab, new Vector3(spawnPoint.position.x, spawnPoint.position.y,spawnPoint.position.z + 1), spawnPoint.rotation), 15f);

                fireRate = Random.Range(7,10);
                
            }
        }
        
    }

    // void OnTriggerEnter(Collider col)
    // {
    //     Debug.Log("destroy");
    //     if (col.gameObject.tag == "DeathCollider"){
    //         Destroy(Instantiate(projectilePrefab.gameObject, spawnPoint.position, spawnPoint.rotation));
    //     }
    // }
}