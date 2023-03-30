using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Image _playImage;
    
    [SerializeField] private Sprite _pressed;
    [SerializeField] private Sprite _unpressed;

    private void Start()
    {
        _play.onClick.AddListener(ChangeImage);
        _play.transform.DOScale(1.2f, 1.5f).SetLoops(-1, LoopType.Yoyo);
    }

    private void ChangeImage()
    {
        if (_playImage.sprite == _pressed)
        {
            _playImage.sprite = _unpressed;
        }
        else
        {
            _playImage.sprite = _pressed;
        }
    }
}
