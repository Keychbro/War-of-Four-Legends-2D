using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WOFL.Control;
using WOFL.UI;

namespace WOFL.Chat
{
    [RequireComponent(typeof(KamenButton))]
    public class ChatViewButton : MonoBehaviour
    {
        #region Variables

        [Header("Objects")]
        [SerializeField] private Image _background;
        [SerializeField] private Image _icon;
        [SerializeField] private NotificationPoint _notificationPoint;
        private KamenButton _button;

        [Header("Settings")]
        [SerializeField] private Color32 _inactiveColor;
        [SerializeField] private Color32 _activeColor;
        [Space]
        [SerializeField] private float _switchDuration;
        [SerializeField] private Ease _switchEase;

        public event Action<ChatViewButton> OnButtonClicked;

        #endregion

        #region Unity Methods

        private void OnDestroy()
        {
            _button.OnClick().RemoveListener(Click);
        }

        #endregion

        #region Control Methods

        public void Initialize()
        {
            _button = GetComponent<KamenButton>();
            _button.Initialize();
            _button.OnClick().AddListener(Click);

            _background.color = _inactiveColor;
        }
        private void Click()
        {
            OnButtonClicked?.Invoke(this);
        }
        public void SwitchActive(bool isActive)
        {
            _background.DOColor(isActive ? _activeColor : _inactiveColor, _switchDuration).SetEase(_switchEase);
        }

        #endregion
    }
}

