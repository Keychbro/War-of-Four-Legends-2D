using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WOFL.Settings
{
    [CreateAssetMenu(fileName = "Unit Level Info", menuName = "WOFL/Settings/Unit Level Info", order = 1)]
    public class UnitLevelInfo : ScriptableObject
    {
        #region Variables

        [Header("Game Settings")]
        [SerializeField] private int _maxHealthValue;
        [SerializeField] private WeaponLevelInfo _weaponInfo;
        [SerializeField] private int _amountGoldForKill;

        [Header("Upgrade Settings")]
        [SerializeField] private int _amountCardToUpgrade;
        [SerializeField] private int _amountGoldToUpgrade;

        #endregion

        #region Properties

        public int MaxHealthValue { get => _maxHealthValue; }
        public WeaponLevelInfo WeaponInfo { get => _weaponInfo; }
        public int GolldForKill { get => _goldForKill; }

        public int AmountCardToUpgrade { get => _amountCardToUpgrade; }
        public int AmountGoldToUpgrade { get => _amountGoldToUpgrade; }

        #endregion
    }
}