using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour
{
    public float transitionSpeed = 1f;      // Скорость плавного перехода

    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector3 endPosition = new Vector3(0f, 1.43f, -5.537551f);  // Целевая позиция по X
    private Quaternion endRotation = Quaternion.Euler(30f, 0f, 0f);  // Целевой угол поворота

    void Start()
    {
        // Начальные значения
        startPosition = transform.position;
        startRotation = transform.rotation;

        MainMenu.OnPlay += OnStart;
        DeadMenu.GoToMenu += OnEnd;
    }  


    void OnStart(){
        StartCoroutine(SmoothTransitionCoroutine());
    }

    void OnEnd(){
        transform.position = new Vector3(0,1.43f,-7.02f);
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

  IEnumerator SmoothTransitionCoroutine()
    {
        while (Vector3.Distance(transform.position, endPosition) > 0.01f || Quaternion.Angle(transform.rotation, endRotation) > 1f)
        {
            // Плавное перемещение камеры
            transform.position = Vector3.Lerp(transform.position, endPosition, transitionSpeed * Time.deltaTime);

            // Плавное изменение поворота камеры
            transform.rotation = Quaternion.Slerp(transform.rotation, endRotation, transitionSpeed * Time.deltaTime);

            yield return null; // Ждём один кадр перед продолжением
        }
    }
}
