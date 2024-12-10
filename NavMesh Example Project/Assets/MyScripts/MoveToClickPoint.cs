﻿/*
* Kayden Miller
* Assignment 9
* Moves gameobject to click point using navmesh
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveToClickPoint : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.destination = hit.point;
            }
        }
    }
}
