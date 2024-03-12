using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WOFL.Settings;

namespace WOFL.Game
{
    [CreateAssetMenu(fileName = "Fraction", menuName = "WOFL/Settings/Fraction", order = 1)]
    public class Fraction : ScriptableObject
    {
        #region Enums

        public enum FractionName
        {
            None,
            Angle,
            Demon,
            Vampire,
            Human
        }

        #endregion

        #region Variables

        [Header("Settings")]
        [SerializeField] private FractionName _name;
        [SerializeField] private Color32 _mainColor;
        [SerializeField] private CastleSettings _castleSettings;
        [SerializeField] private UnitInfo[] _units;

        #endregion

        #region Properties

        public FractionName Name { get => _name; }
        public Color32 MainColor { get => _mainColor; }
        public CastleSettings CastleSettings { get => _castleSettings; }
        public UnitInfo[] Units { get => _units; }

        #endregion
    }
}