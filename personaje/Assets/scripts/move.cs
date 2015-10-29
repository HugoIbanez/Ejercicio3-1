using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed =20;
	}
	
	// Update is called once per frame
	void Update () {
		//moveforward ();
	}
	//funcion que mueve el personaje
	public void moveL()
	{
		Debug.Log ("Hola");
		//Mover posicion de forma constante
		//vector3.down
		this.transform.Translate ((Time.deltaTime * speed)* Vector3.left);
	}
	//function que mueve al personaje
	public void moveR()
	{
		//Debug.Log ("Hola");
		//Mover posicion de forma constante
		this.transform.Translate ((Time.deltaTime * speed)* Vector3.right);
	}
}
