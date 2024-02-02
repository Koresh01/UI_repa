using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 30f; // Скорость вращения

    void Update()
    {
        // Получаем текущий угол поворота объекта по вертикали в глобальных координатах
        float currentRotationY = transform.rotation.eulerAngles.y;

        // Вычисляем новый угол поворота на основе скорости и времени
        float newRotationY = currentRotationY + (rotationSpeed * Time.deltaTime);

        // Создаем новую кватернионную переменную для поворота по глобальным осям
        Quaternion newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, newRotationY, transform.rotation.eulerAngles.z);

        // Применяем новый угол поворота к Transform объекта
        transform.rotation = newRotation;
    }
}
