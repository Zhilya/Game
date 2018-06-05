using UnityEngine;
using System.Collections;

public class fuelscript : MonoBehaviour {

	public GameObject fuelall;
	float mytimer=100f;// задание плавающего числа
	// Use this for initialization
	void Start () 
	{

	}
	void Update () 
	{
		mytimer = 100f;
		mytimer -= Time.deltaTime;//изменения числа с течением времени
		if (mytimer/mytimer==1f) //проверка на период времени в 1 секунду
		{
			fuelall.transform.position=new Vector3(fuelall.transform.position.x-0.0011f,fuelall.transform.position.y,fuelall.transform.position.z);
			fuelall.transform.localScale = new Vector3(fuelall.transform.localScale.x-0.001f, 1, 1);
                        //выше идет сдвижение влево и уменьшение по ширине зеленой полосы для имитации шкалы
		}
		if (fuelall.transform.localScale.x < 0) //если шкала исчезла то загрузка идет загрузка главного меню 
		{
			Application.LoadLevel(0);
		}
	}
}fuelscript.cs
