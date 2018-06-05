using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class menu : MonoBehaviour {
	
	public GUIStyle mystyle; //объявляется для того чтобы изменять начертание GUI компонентов(шрифт, размер и.т.п.)
	string score; //переменная для хранения пройденной дистанции
	void Start () 
	{
		StreamReader scoredata = new StreamReader (Application.persistentDataPath + "/score.gd"); //создание файловой переменной
		score = scoredata.ReadLine (); //чтение строки
		scoredata.Close (); //закрытие файловой переменной
	}
	
	
	void Update () {
	
	}
	void OnGUI(){
		GUI.Box (new Rect (Screen.width*0.15f, Screen.height*0.8f, Screen.width*0.7f, Screen.height*0.1f), "MAX DISTANCE:"+score,mystyle); //создаем небольшое окошко для показа пройденного расстояния
		if (GUI.Button (new Rect (Screen.width*0.15f, Screen.height*0.25f, Screen.width*0.7f, Screen.height*0.1f), "Start game",mystyle)) //создаем кнопку для запуска игровой сцены
		{
			Application.LoadLevel(1);//Загрузка игровой сцены
		

}
