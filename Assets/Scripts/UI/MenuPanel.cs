using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPanel : UIPanel
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _creatorsButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private CreatorsPanel _creatorsPanel;
    [SerializeField] private CanvasGroup _canvasGroup;

    private const string _gameSceneName = "Game";

    private void Awake()
    {
        Open();
    }

    private void OnEnable()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
        _creatorsButton.onClick.AddListener(OnCreatorsButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnPlayButtonClick);
        _creatorsButton.onClick.RemoveListener(OnCreatorsButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
    }

    public override void Open()
    {
        _canvasGroup.alpha = 1;
        _canvasGroup.blocksRaycasts = true;
        _playButton.interactable = true;
        _creatorsButton.interactable = true;
        _exitButton.interactable = true;
    }

    public override void Close()
    {
        _canvasGroup.alpha = 0;
        _canvasGroup.blocksRaycasts = false;
        _playButton.interactable = false;
        _creatorsButton.interactable = false;
        _exitButton.interactable = false;
    }

    private void OnPlayButtonClick()
    {
        SceneManager.LoadScene(_gameSceneName);
    }

    private void OnCreatorsButtonClick()
    {
        Close();
        _creatorsPanel.Open();
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }
}
