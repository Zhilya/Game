using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class carconroller : MonoBehaviour 
{

	void Start () 
	{

	}
	
	
	public void Update () 
	{
		if (transform.rotation.z !=0) //проверка столкновения коллайдера автомобиля и препятствия, при столкновении происходит загрузка меню
		{
			Application.LoadLevel (0);
		}
		
	}
	}
	public void OnGUI()
	{
		if (GUI.RepeatButton (new Rect (Screen.width*0.1f, Screen.height*0.9f, Screen.width*0.2f, Screen.height*0.08f), "L")) //создаем кнопку для движения влево
		{
			if (transform.position.x > -2.4f)
			{
				transform.Translate (new Vector3 (-0.05f, 0f, 0f));
			}
		}

		if (GUI.RepeatButton (new Rect (Screen.width*0.7f, Screen.height*0.9f, Screen.width*0.2f, Screen.height*0.08f), "R")) //создаем кнопку для движения вправо
		{
			if (transform.position.x < 2.4f)
			{
				transform.Translate (new Vector3 (0.05f, 0f, 0f)); 
			}
		}
	}

}
