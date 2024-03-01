using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kamen;
using System;

namespace WOFL.Control
{
    public class UnitTypeManager : SingletonComponent<UnitTypeManager>
    {
        #region Enums

        public enum UnitType
        {
            Warrior,
            Archer,
            King,
            Barrack
        }

        #endregion

        #region Classes

        [Serializable] private struct UnitTypeInfo
        {
            #region UnitTypeInfo Variables

            [SerializeField] private UnitType _type;
            [SerializeField] private Sprite _logo;

            #endregion

            #region UnitTypeInfo Properties

            public UnitType Type { get => _type; }
            public Sprite Logo { get => _logo; }

            #endregion
        }

        #endregion

        #region Variables

        [Header("Settings")]
        [SerializeField] private UnitTypeInfo[] _typeInfos;

        #endregion
    }
}