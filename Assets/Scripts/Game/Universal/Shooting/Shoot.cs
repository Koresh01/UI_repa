using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float reload;
    private float cur = 0f;
    public AudioClip clickSound; // Звук, который будет воспроизводиться

    private AudioSource audioSource;
    public GameObject bulletPrefab;
    public Transform tube;

    private void Start()
    {
        // Получаем компонент AudioSource из этого объекта или добавляем его, если его нет
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Update()
    {
        while (cur < reload)
        {
            // Проверяем, была ли нажата левая кнопка мыши
            if (cur >= reload)
            {
                // Воспроизводим звук
                audioSource.clip = clickSound;
                audioSource.Play();
                Instantiate(bulletPrefab, transform.position, tube.rotation);

                cur = 0f;
            }
        }
    }
}
