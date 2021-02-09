using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20; //верхняя граница выше которой мы ниче не видим и можно удалять объекты
                                 //нам не нужные
    private float lowerBound = -20;

    private void Update()
    {
        //если позиция по z вышла за обозначенную границу
        //то вызываем метод Destroy и в скобочках говорим что нужно удалить
        //GameObject на котором висит этот скрипт при if == true;
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
