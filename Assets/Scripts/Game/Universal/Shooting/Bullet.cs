using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float destroyTime = 2f;

    private void Start()
    {
        StartCoroutine(DestroyAfterDelay(destroyTime));
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Проверка на столкновение с противниками
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, speed * Time.deltaTime))
        {
            if (hit.collider.GetComponentInChildren<EnemyMovement>() != null) 
            {
                // Обработка столкновения
                Destroy(hit.collider.gameObject);
                Destroy(gameObject); // Уничтожаем пулю
            }
        }
    }

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
