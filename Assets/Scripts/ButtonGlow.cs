using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonGlow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Button _button;
    private RawImage _buttonImage;
    private Color _originalColor;

    void Start()
    {
        _button = GetComponent<Button>();
        _buttonImage = _button.GetComponent<RawImage>();
        _originalColor = _buttonImage.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _buttonImage.color = Color.yellow; // Замените на нужный цвет
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _buttonImage.color = _originalColor;
    }
}