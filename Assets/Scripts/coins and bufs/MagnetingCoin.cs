using UnityEngine;
using System.Collections;

public class MagnetingCoin : MonoBehaviour
{
    private Transform target; // Ссылка на игрока (персонажа)
    public float speed = 5f;  // Скорость движения
    private Coroutine magnetCoroutine; // Для хранения ссылки на корутину

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; // Находим игрока
        Trigger_Collision_Controller.OnMagneting += ActivateMagnet;
    }

    public void ActivateMagnet()
    {
        // Если монетка уже притягивается, не запускаем корутину
        if (magnetCoroutine != null)
        {
            return;
        }

        // Запускаем корутину, которая будет двигать монетку
        magnetCoroutine = StartCoroutine(MoveTowardsPlayer());
    }

    private IEnumerator MoveTowardsPlayer()
    {
        while (transform.position != target.position)
        {
            // Двигаем монетку к игроку
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            // Ждем следующего кадра
            yield return null;
        }
    }

    // Отписка от события при уничтожении объекта
    void OnDestroy()
    {
        Trigger_Collision_Controller.OnMagneting -= ActivateMagnet;
    }
}