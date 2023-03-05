using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit Class", menuName = "Unit/Class", order = 1)]

public class UnitRoleData : ScriptableObject{
    public float refreshRate = 0.5f;
    public float attackSpeed = .8f;
    public float health = 100;
    public float damage = 2f;
    
    public ResourcePrice cost;

    public List<CollectData> getterData = new List<CollectData>();

    public List<BuildingData> buildables = new List<BuildingData>();
}

[System.Serializable]
public class CollectData{
    public ResourceData resource;
    public float getterSpeed = .01f;
    public int getterAmount = 1;
    public int maxPocket = 20;

}
