using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPAlpha : MonoBehaviour
{
    [SerializeField]
    private float lerpTime = 1.0f;  // ���� �迭 �Լ� �̿��ؼ� �ý��� �޼��� �������� �ð� ���� 
    private TextMeshProUGUI text;

    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void FadeOut()
    {
        StartCoroutine(AlphaLerp(1, 0));
    }
    private IEnumerator AlphaLerp(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1.0f) 
        {
            currentTime += Time.deltaTime;
            percent = currentTime / lerpTime;

            Color color = text.color;
            color.a = Mathf.Lerp(start, end, percent);
            text.color = color;

            yield return null;
        }
    }
}