using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotationSpeed = 10f; // Скорость вращения

    void Update()
    {
        // Получаем текущий угол поворота объекта по вертикали
        float currentRotation = transform.rotation.eulerAngles.y;

        // Вычисляем новый угол поворота на основе скорости и времени
        float newRotation = currentRotation + (rotationSpeed * Time.deltaTime);

        // Применяем новый угол поворота к Transform объекта
        transform.rotation = Quaternion.Euler(-90f, newRotation, 0f);
    }
}
