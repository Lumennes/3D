using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeQuality : MonoBehaviour
{
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = $"Уровень графики: {QualitySettings.names[QualitySettings.GetQualityLevel()]}";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            //var next = QualitySettings.GetQualityLevel() + 1;
            //if (next >= 6)
            //    next = 0;
            QualitySettings.SetQualityLevel(
                QualitySettings.GetQualityLevel() >= 5 ? 0 : QualitySettings.GetQualityLevel() + 1, true);
            text.text = $"Уровень графики: {QualitySettings.names[QualitySettings.GetQualityLevel()]}";
            Cursor.visible = false;
        }
        //if (Input.GetKeyDown(KeyCode.Keypad2))
        //{
        //    QualitySettings.SetQualityLevel(1, true);
        //}
        //if (Input.GetKeyDown(KeyCode.Keypad3))
        //{
        //    QualitySettings.SetQualityLevel(2, true);
        //}
        //if (Input.GetKeyDown(KeyCode.Keypad4))
        //{
        //    QualitySettings.SetQualityLevel(3, true);
        //}
        //if (Input.GetKeyDown(KeyCode.Keypad5))
        //{
        //    QualitySettings.SetQualityLevel(4, true);
        //}
        //if (Input.GetKeyDown(KeyCode.Keypad6))
        //{
        //    QualitySettings.SetQualityLevel(5, true);
        //}
        
    }
}
