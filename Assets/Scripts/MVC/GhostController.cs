using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GhostController
{
    public GhostModel Model { get; }
    public GhostView View { get; }

    public GhostController(GhostModel Model, GhostView GhostPrefab)
    {
        Model = GhostModel;
        View = GameObject.Instantiate<GhostView>(GhostPrefab);
        View.GhostController = this;
    }

    //to Checking Enemy Range Attack or Chaisng 
    public void EnemyTankRange()
    {
        if (GhostView != null)
        {
            GhostView.playerInSightRange = Physics.CheckSphere(GhostView.transform.position, GhostView.sightRange, GhostView.Player);
            GhostView.playerInAttackRange = Physics.CheckSphere(GhostView.transform.position, GhostView.attackrange, GhostView.Playe);
        }
    }


}