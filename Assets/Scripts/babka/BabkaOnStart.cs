using UnityEngine;
using System.Collections;

public class BabkaOnStart : MonoBehaviour
{
    
    private Vector3 startPosition;
    private Vector3 endPosition = new Vector3(0f, -0.4492862f, -3.58f);

    void Start()
    {
        startPosition = transform.position;
        MainMenu.OnPlay += BabkaStart;
        DeadMenu.GoToMenu += OnEnd;
    }

    public void BabkaStart(){
        StartCoroutine(SmoothTransitionCoroutine());
    }

    public void OnEnd(){
        transform.position = startPosition;
    }

    IEnumerator SmoothTransitionCoroutine()
    {
        float duration = 2f; // Длительность движения, например 2 секунды
        float elapsedTime = 0f;
        while (Vector3.Distance(transform.position, endPosition) > 0.01f)
        {
            elapsedTime += Time.deltaTime; // Увеличиваем время, прошедшее с начала корутины
            float t = Mathf.Clamp01(elapsedTime / duration); // Вычисляем нормализованное значение времени

            transform.position = Vector3.Lerp(startPosition, endPosition, t);
            yield return null; 
        }
    }

}
