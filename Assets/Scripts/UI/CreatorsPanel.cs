using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CreatorsPanel : UIPanel
{
    [SerializeField] private Button _returnToMenuButton;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private float _openDuration;
    [SerializeField] private MenuPanel _menuPanel;

    private void Awake()
    {
        Close();
    }

    private void OnEnable()
    {
        _returnToMenuButton.onClick.AddListener(OnReturnToMenuButton);
    }

    private void OnDisable()
    {
        _returnToMenuButton.onClick.RemoveListener(OnReturnToMenuButton);
    }

    public override void Open()
    {
        _canvasGroup.DOFade(1, _openDuration).OnComplete(() =>
        {
            _canvasGroup.blocksRaycasts = true;
            _returnToMenuButton.interactable = true;
        });
    }

    public override void Close()
    {
        _canvasGroup.alpha = 0;
        _canvasGroup.blocksRaycasts = false;
        _returnToMenuButton.interactable = false;
    }

    private void OnReturnToMenuButton()
    { 
        Close();
        
        _menuPanel.Open();
    }

}
