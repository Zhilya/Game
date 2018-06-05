using UnityEngine;
using System.Collections;

public class triger : MonoBehaviour {


	public GameObject fuel;//добавляем сюда greenfuel
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void  OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "playercar") //проверка пересечения автомобиля и объекта fuel
		{
			fuel.transform.position=new Vector3(0,fuel.transform.position.y,fuel.transform.position.z);
			fuel.transform.localScale = new Vector3(1, 1, 1);
                        //восстановление у объекта fuel стандартных значений
		}
	}


}
