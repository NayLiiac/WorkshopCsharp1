﻿using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public PlayerSeedBag SeedBag;
    public PlayerPlantBag PlantBag;
    public PlayerMoney Money;

    [field : SerializeField]
    public PlayerAction PlAction {get; private set;} 
}
