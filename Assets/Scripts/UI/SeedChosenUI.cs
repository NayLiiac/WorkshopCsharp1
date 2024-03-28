﻿using TMPro;
using UnityEngine;

public class SeedChosenUI : MonoBehaviour
{
    [SerializeField]
    private SeedSelectorUI _seedSelectorUI;
    [SerializeField]
    private TextMeshProUGUI _cantChoseThisSeed;
    [SerializeField]
    private PlayerMain _playerMain;

    public void ChooseThisSeed(Seed seed)
    {
        bool seedFound = false;
        foreach (Seed seed1 in _playerMain.SeedBag.SeedBagList)
        {
            if(seed1.SeedName == seed.SeedName)
            {
                _playerMain.PlAction.TempHarvester.Sow.SowASeed(seed1);
                _playerMain.SeedBag.SeedBagList.Remove(seed1);
                seedFound = true;
                break;
            }
        }

        if (!seedFound)
        {
            _cantChoseThisSeed.gameObject.SetActive(true);
            _cantChoseThisSeed.text = $"You don't have this seed in your bag :'(";
        }
        else
        {
            _cantChoseThisSeed.gameObject.SetActive(false);
            _seedSelectorUI.CloseSeedSelectorUI();
        }
    }
}