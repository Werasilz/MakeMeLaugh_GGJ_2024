using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionUIController : SceneSingleton<QuestionUIController>
{
    [SerializeField] private GameObject _content;
    [SerializeField] private CanvasGroup _canvasGroup;

    [Header("Enemy Profile")]
    [SerializeField] private Image _enemyImage;
    [SerializeField] private TMP_Text _enemyNameText;

    [Header("Question")]
    [SerializeField] private TMP_Text _questionText;

    protected override void Awake()
    {
        base.Awake();
    }

    public void SetActiveContent(bool isActive)
    {
        _content.SetActive(isActive);
    }

    public void SetQuestion(string dialogue)
    {
        _questionText.text = dialogue;
    }

    public void SetEnemyProfile(Profile enemyProfile)
    {
        _enemyImage.sprite = enemyProfile.sprite;
        _enemyNameText.text = enemyProfile.profileName;
    }

    public void SetCanvasGroupAlpha(float alphaTarget)
    {
        float value = _canvasGroup.alpha;
        DOTween.To(() => value, x => value = x, alphaTarget, GlobalConfig.DELAY_ALPHA_DEFAULT).OnUpdate(() =>
        {
            _canvasGroup.alpha = value;
        }).OnComplete(() =>
        {
            _canvasGroup.alpha = alphaTarget;
        });
    }
}
