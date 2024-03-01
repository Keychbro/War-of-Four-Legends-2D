using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WOFL.Control;

namespace WOFL.Settings
{
    [CreateAssetMenu(fileName = "Unit Level Info", menuName = "WOFL/Settings/Units/Unit Level Info", order = 1)]
    public class UnitLevelInfo : ScriptableObject
    {
        #region Variables

        [Header("Game Settings")]
        [SerializeField] private UnitTypeManager.UnitType _type;
        [SerializeField] private int _maxHealthValue;
        [SerializeField] private WeaponLevelInfo _weaponInfo;
        [SerializeField] private int _amountGoldForKill;
        [SerializeField] private int _manePrice;

        [Header("Upgrade Settings")]
        [SerializeField] private int _amountCardToUpgrade;
        [SerializeField] private int _amountGoldToUpgrade;

        #endregion

        #region Properties

        public UnitTypeManager.UnitType Type { get => _type; }
        public int MaxHealthValue { get => _maxHealthValue; }
        public WeaponLevelInfo WeaponInfo { get => _weaponInfo; }
        public int AmountGoldForKill { get => _amountGoldForKill; }
        public int ManaPrice { get => _manePrice; }

        public int AmountCardToUpgrade { get => _amountCardToUpgrade; }
        public int AmountGoldToUpgrade { get => _amountGoldToUpgrade; }

        #endregion
    }
}