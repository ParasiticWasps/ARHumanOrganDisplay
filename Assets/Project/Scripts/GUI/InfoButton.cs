using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoButton : MonoBehaviour
{
    public Button SelfButton;

    public AudioClip clip;

    public event Action<InfoButton> OnButtonClick;

    public void Start()
    {
        SelfButton.onClick.AddListener(() =>
        {
            OnButtonClick?.Invoke(this);
        });
    }
}
