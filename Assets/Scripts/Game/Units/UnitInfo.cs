using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WOFL.Game;
using WOFL.Control;

namespace WOFL.Settings
{
    [CreateAssetMenu(fileName = "Unit Info", menuName = "WOFL/Settings/Units/Unit Info", order = 1)]
    public class UnitInfo : ScriptableObject
    {
        #region Variables

        [Header("Main Settings")]
        [SerializeField] private string _uniqueName;
        [SerializeField] private UnitTypeManager.UnitType _type;
        [SerializeField] private UnitLevelsHolder _levelsHolder;
        [SerializeField] private SkinsHolder _skinsHolder;
        [SerializeField] private Unit _prefab;

        [Header("Additional Settings")]
        [SerializeField] private float _moveSpeed;

        #endregion

        #region Properties

        public string UniqueName { get => _uniqueName; }
        public UnitTypeManager.UnitType Type { get => _type; }
        public UnitLevelsHolder LevelsHolder { get => _levelsHolder; }
        public SkinsHolder SkinsHolder { get => _skinsHolder; }
        public Unit Prefab { get => _prefab; }

        public float MoveSpeed { get => _moveSpeed; }

        #endregion
    }
}