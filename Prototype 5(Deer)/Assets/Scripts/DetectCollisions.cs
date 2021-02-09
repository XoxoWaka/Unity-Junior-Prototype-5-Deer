using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    //метод который обрабатывает столкновение коллайдеров в нашем случае когда они триггеры
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //при соприкосновении уничтожает обьект на котором висит скрипт
        Destroy(other.gameObject); //при соприкосновении коллайдеров, по коллайдеру находит обьект которому этот
                                   //коллайдер принадлежит и уничтожает этот обьект
    }
}
