using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using WOFL.Settings;
using TMPro;

namespace WOFL.Game.Components
{
    public class HealthBar : MonoBehaviour
    {
        #region Variables

        [Header("Objects")]
        [SerializeField] private Slider _instantSlider;
        [SerializeField] private Image _instantSliderFill;
        [SerializeField] private Slider _animationSlider;
        [SerializeField] private Image _animationSliderFill;
        [SerializeField] private Image _icon;
        [SerializeField] private TextMeshProUGUI _amountHealth;

        [Header("Settings")]
        [SerializeField] private float _animationDuration;
        [SerializeField] private Ease _animationEase;

        [Header("Variables")]
        private IDamageable _damageableObject;
        private IHealable _healableObject;
        private HealthBarSettings _currentSettings;

        #endregion

        #region Unity Methods
        private void Start()
        {
            Initialize();
        }
        private void OnDestroy()
        {
            _damageableObject.OnTakedDamage -= CallMinusValue;
            _healableObject.OnHealed += CallPlusValue;
        }

        #endregion

        #region Control Methods

        private void Initialize()
        {
            _damageableObject = GetComponent<IDamageable>();
            _damageableObject.OnTakedDamage += CallMinusValue;

            _healableObject = GetComponent<IHealable>();
            _healableObject.OnHealed += CallPlusValue;

            SetUpSlider(_instantSlider, _damageableObject.MaxHealth);
            SetUpSlider(_animationSlider, _damageableObject.MaxHealth);
        }
        public void UpdateBarViewStyle(HealthBarSettings settings)
        {
            _currentSettings = settings;

            _instantSliderFill.sprite = _currentSettings.InstantFillSprite;
            _animationSliderFill.sprite = _currentSettings.AnimationFillSprite;

            _icon.sprite = _currentSettings.Icon;
            _icon.color = _currentSettings.MainColor;
            _icon.rectTransform.sizeDelta = _currentSettings.IconSize;
            _icon.transform.localPosition = _currentSettings.IconPosition;
        }
        private void CallMinusValue(int value) => UpdateBarView(_instantSlider.value - value);
        private void CallPlusValue(int value) => UpdateBarView(_instantSlider.value + value);
        private void UpdateBarView(float value)
        {
            _instantSlider.value = value;
            _animationSlider?.DOValue(value, _animationDuration).SetEase(_animationEase);

            _amountHealth.text = value.ToString();
        }
        private void SetUpSlider(Slider slider, int maxValue)
        {
            slider.maxValue = maxValue;
            slider.value = maxValue;

            _amountHealth.text = maxValue.ToString();
        }

        #endregion
    }
}

