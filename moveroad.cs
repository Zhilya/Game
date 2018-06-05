using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class moveroad : MonoBehaviour
{

    public GUIStyle mystyle;//создание стиля
    int f, fuelst;
    float score = 0, speed = -0.2f, data, fuelpos;// переменные для хранения расстояния, скорости и рекорда
    public GameObject block;// игровой объект для размещения блока
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject fuel;
    bool turbotriger = false;

    void Start()
    {
        StreamReader scoredata = new StreamReader(Application.persistentDataPath + "/score.gd");
        data = float.Parse(scoredata.ReadLine());//чтение с файла информации о рекорде
        scoredata.Close();
    }


    void Update()
    {
        transform.Translate(new Vector3(0f, speed, 0f));//движение дороги с заданной выше скоростью
        score = score + (speed * -10);// подсчет расстояния
        if (transform.position.y < -19f) // если дорога уходит за пределы камеры то она "теле портируется" вверх
        {
            transform.position = new Vector3(0f, 33.4f, 0f);//новая позиция дороги
            block.transform.position = new Vector3(10.15f, block.transform.position.y, block.transform.position.z);
            block1.transform.position = new Vector3(8.42f, block1.transform.position.y, block1.transform.position.z);
            block2.transform.position = new Vector3(6.62f, block2.transform.position.y, block2.transform.position.z);
            block3.transform.position = new Vector3(4.95f, block3.transform.position.y, block3.transform.position.z);
            fuel.transform.position = new Vector3(11.86f, fuel.transform.position.y, fuel.transform.position.z);
            //скрытие за пределы камеры всех препятствий(блоков)
            f = Random.Range(0, 5);//случайное появление на дороге 1-го из 4-х блоков или канистры с бензином
            switch (f)
            {
                case 0: block.transform.position = new Vector3(2.40f, block.transform.position.y, block.transform.position.z); break;
                case 1: block1.transform.position = new Vector3(0.90f, block1.transform.position.y, block1.transform.position.z); break;
                case 2: block2.transform.position = new Vector3(-0.80f, block2.transform.position.y, block2.transform.position.z); break;
                case 3: block3.transform.position = new Vector3(-2.35f, block3.transform.position.y, block3.transform.position.z); break;
                case 4:
                    fuelst = Random.Range(0, 4);
                    if (fuelst == 0) { fuelpos = 2.40f; }
                    if (fuelst == 1) { fuelpos = 0.90f; }
                    if (fuelst == 2) { fuelpos = -0.80f; }
                    if (fuelst == 3) { fuelpos = -2.35f; }
                    fuel.transform.position = new Vector3(fuelpos, fuel.transform.position.y, fuel.transform.position.z);
                    break;
            }
            if (score > data)// если текущее пройденное расстояние превышает то что записано в файле рекорда то идет обновление данных
            {
                StreamWriter scoredata = new StreamWriter(Application.persistentDataPath + "/score.gd");//создаем файловую переменную для хранения пройденного расстояния
                scoredata.WriteLine(score);//записываем новое значение в файл
                scoredata.Close();//закрываем файловую переменную
            }
        }

    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height * 0.05f), "Distance(m): " + score, mystyle);//создаем окно для подсчета расстояния
    }
}