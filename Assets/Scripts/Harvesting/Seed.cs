﻿using UnityEngine;

public class Seed : MonoBehaviour
{
    public Animator GrowSeedAnim;
    [SerializeField]
    private bool _seedGrownUp;

    [field : SerializeField]
    public string SeedName { get; private set; }

    [field : SerializeField]
    public int PurchasePrice { get; private set; }

    public void SeedGrowthStartAnim()
    {
        GrowSeedAnim.SetTrigger("Grow");
    }

    /// <summary>
    /// Called by the animator in the end of the animation
    /// </summary>
    public void SetSeedGrownUp()
    {
        _seedGrownUp = true;
    }

    public bool GetSeedGrownUp()
    {
        return _seedGrownUp;
    }
}
