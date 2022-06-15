using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// просто штука которая изменияет уровень графики при нажатии кнопки на один шаг, для теста графики
/// </summary>
public class ChangeQuality : MonoBehaviour
{
    public static ChangeQuality instance;

    [SerializeField] private TMP_Text text;
    [SerializeField] private Text txt;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        txt.text = $"Уровень графики: {QualitySettings.names[QualitySettings.GetQualityLevel()]}"; // вывод текста в UI
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) // при нажатии кнопки L (думаю она ни за что не отвечает нигде)
        {
            UPGrapcis();
        }
    }

    public void UPGrapcis()
    {
        QualitySettings.SetQualityLevel( // устанавливаем уровень графики на 1 шаг лучше, если ур.гр. макс то минимальный
                QualitySettings.GetQualityLevel() >= 5 ? 0 : QualitySettings.GetQualityLevel() + 1, true);
        txt.text = $"Уровень графики: {QualitySettings.names[QualitySettings.GetQualityLevel()]}"; // вывод текста в UI
        //Cursor.visible = false; // скрываем курсор, инчае при нажатии он становится видимым 
    }
}
