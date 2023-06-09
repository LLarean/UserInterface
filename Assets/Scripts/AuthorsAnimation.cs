using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class AuthorsAnimation : MonoBehaviour
{
    [SerializeField] private Button _author;
    [SerializeField] private Color _colorTo;
    // private Color _startColor;
    private Image _image;

    private void Start()
    {
        _author.onClick.AddListener(ChangeColor);
        _image = _author.GetComponent<Image>();
        // _startColor = _image.color;
    }

    private void ChangeColor()
    {
        if (_image.color == Color.white)
        {
            _image.DOColor(_colorTo, 1f);
        }
        else
        {
            _image.DOColor(Color.white, 1f);
        }
    }
}
