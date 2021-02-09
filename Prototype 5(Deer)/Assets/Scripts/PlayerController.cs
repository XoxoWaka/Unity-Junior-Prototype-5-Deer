using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 10f; //правая граница а если с минусом то левая граница по оси Х
                               //но вообще это просто число 10 а потом позиция игрока(число)
                               //сравнивается с числом которое записано в xRange

    public GameObject projectilePrefab; //в эту переменную можно поместить префаб или другой обьект в инспекторе
                                        //чтоб потом его вызвать или вызвать у него какие то свойства

    private void Update()
    {
        //если левая позиция по Х игрока меньше чем левая заданная граница то
        //игрок так и остается в левой позиции
        //то же актуально и для правой только со знаком больше и без минуса
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //обращаемся к Input менеджеру которые знает все клавиши и не только
        //и коворим что при нажатии на пробел произойдет что-то
        //можно подставить любую клавишу
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //создание обьекта запиханного в переменную projectilePrefab(пиццы в нашем случае)
            //мы создаем его в transform.position игрока, то есть она вылетает из игрока
            //и задаем ей ее(пиццы) вращение, вот тут немножко не понятно наверное это чтобы при вылете
            // вращение не зависело от вращения игрока хотя в этой игре его и нет
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
