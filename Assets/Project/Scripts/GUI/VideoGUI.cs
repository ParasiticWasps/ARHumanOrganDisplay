using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoGUI : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    [SerializeField] private Button videoButton;

    [SerializeField] private Sprite playSprite;

    [SerializeField] private Sprite stopSprite;

    private bool isPlaying = true;

    private void Start()
    {
        SetActive(false);
        //ClickedPlayButton();
    }

    public void ClickedPlayButton()
    {
        Action action = isPlaying ? () => {
            videoPlayer.Pause();
            videoButton.image.sprite = playSprite;
        } :
        () => {
            videoPlayer.Play();
            videoButton.image.sprite = stopSprite;
        };
        isPlaying = !isPlaying;
        action?.Invoke();
    }

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }
}
