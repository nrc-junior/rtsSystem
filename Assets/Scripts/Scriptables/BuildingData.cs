using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Building Data", menuName = "Buildings/data", order = 1)]

public class BuildingData : ScriptableObject {
    public new string name;
    public Sprite icon;
    
    public List<ResourcePrice> cost = new List<ResourcePrice>();
    public List<UnitRoleData> unitsFactory = new List<UnitRoleData>();
    
    public List<ResourceData> acceptResources = new List<ResourceData>();
    
    public Building building;
    //public static Action purchase;

    public delegate void Purchase(BuildingData building);
    public Purchase purchase;
}
