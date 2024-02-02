using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 30f; // �������� ��������

    void Update()
    {
        // �������� ������� ���� �������� ������� �� ��������� � ���������� �����������
        float currentRotationY = transform.rotation.eulerAngles.y;

        // ��������� ����� ���� �������� �� ������ �������� � �������
        float newRotationY = currentRotationY + (rotationSpeed * Time.deltaTime);

        // ������� ����� ������������� ���������� ��� �������� �� ���������� ����
        Quaternion newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, newRotationY, transform.rotation.eulerAngles.z);

        // ��������� ����� ���� �������� � Transform �������
        transform.rotation = newRotation;
    }
}
