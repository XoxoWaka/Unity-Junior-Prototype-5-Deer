using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //создание массива для GameObject
    
    private float spawnRangeX = 10; // эта переменная для создания случайного числа для
                                    // позиции по Х которую запишем в Vector3
    private float spwanPosZ = 20;   // для позиции по Z 
    private float startDelay = 2;
    private float spawnInterval = 1.5f;


    private void Start()
    {
        // метод который вызывает нужную функцию(в нашем случае SpawnRandomAnimal)
        // через нужное время со старта и последний аргумет говорит через какой интервал будет вызываться метод
        // ОБРАТИ ВНИМАНИЕ ЧТО InvokeRepeating ВЫЗЫВАЕТСЯ В СТАРТЕ А НЕ В UPDATE
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    private void Update()
    {
       
    }

    
    void SpawnRandomAnimal() //создание нашей собственной функции в которой мы создаем игровой обьект(Животных)
    {
        //в интовую переменную animalIndex которая дальше ббудет определять индекс эллемента массива для создания объекта
        //мы помещаем случайны число в диапозоне от (0, до animalPrefabs.Length длинны массива)
        //метод Random.Range и создает нам это случайно число в диапазоне
        int animalIndex = Random.Range(0, animalPrefabs.Length);


        // задаем вектор для создания обьекта ятоб всю эту канитель не писать при создании объекта
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spwanPosZ);

        // Создает один из элементов массива animalPrefabs под индексом animalIndex, в точке на карте (0, 0, 20)
        // и углов вращения этого же элемента массива(в нашем случае одного из животных)
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
