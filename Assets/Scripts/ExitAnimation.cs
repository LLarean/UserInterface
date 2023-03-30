using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ExitAnimation : MonoBehaviour
{
    [SerializeField] private Button _exit;
    private Vector3 _startPosition;

    private void Start()
    {
        _exit.onClick.AddListener(ChangePosition);
        _startPosition = _exit.transform.localPosition;
    }

    private void ChangePosition()
    {
        var localPosition = _exit.transform.localPosition;
        var shiftLength = 250;

        if (_startPosition == localPosition)
        {
            localPosition.x += shiftLength;
        }
        else
        {
            localPosition.x -= shiftLength;
        }
        
        _exit.transform.DOLocalMove(localPosition, .1f);
    }
}