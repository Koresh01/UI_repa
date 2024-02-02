using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float reload;
    private float cur = 0f;
    public AudioClip clickSound; // ����, ������� ����� ����������������

    private AudioSource audioSource;
    public GameObject bulletPrefab;
    public Transform tube;

    private void Start()
    {
        // �������� ��������� AudioSource �� ����� ������� ��� ��������� ���, ���� ��� ���
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
            // ���������, ���� �� ������ ����� ������ ����
            if (cur >= reload)
            {
                // ������������� ����
                audioSource.clip = clickSound;
                audioSource.Play();
                Instantiate(bulletPrefab, transform.position, tube.rotation);

                cur = 0f;
            }
        }
    }
}
