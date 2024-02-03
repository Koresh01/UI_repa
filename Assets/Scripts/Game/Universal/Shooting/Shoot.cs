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

    private bool _canShot = true;

    private void Start()
    {
        // �������� ��������� AudioSource �� ����� ������� ��� ��������� ���, ���� ��� ���
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && _canShot)
        {
            StartCoroutine(MakeShoot());

            // ������������� ����
            audioSource.clip = clickSound;
            audioSource.Play();
            Instantiate(bulletPrefab, transform.position, tube.rotation);

            _canShot = false;
        }
    }

    IEnumerator MakeShoot()
    {
        yield return new WaitForSeconds(reload);
        _canShot = true;
    }
}