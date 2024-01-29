using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotationSpeed = 10f; // �������� ��������

    void Update()
    {
        // �������� ������� ���� �������� ������� �� ���������
        float currentRotation = transform.rotation.eulerAngles.y;

        // ��������� ����� ���� �������� �� ������ �������� � �������
        float newRotation = currentRotation + (rotationSpeed * Time.deltaTime);

        // ��������� ����� ���� �������� � Transform �������
        transform.rotation = Quaternion.Euler(-90f, newRotation, 0f);
    }
}
