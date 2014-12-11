using UnityEngine;
using System.Collections;

public class paralaxing : MonoBehaviour {
	public Transform[] backgrounds;   //це якби ну походу масив з всіх моїх задніх і передніх планів
	private float[] parallaxScales;   // по ходу це позицыя ъх выдносно камери. пропорції камери, тобто як вона відносно планів рухається
	public float smoothing = 1f; //плавність паралаксування (має бути обов'язково більше 0, а то паралакс не спрацює)
	
	private Transform cam; // відсилка до головної трансформації камери (ЩО?????)
	private Vector3 previousCamPos; // попередня позициція камери (в попередньому кадрі)
	
	void Awake ()
	{
		//я встановлюю відсилку до головної трансформації камери (ЩО???)
		cam = Camera.main.transform;
	}
	
	// Use this for initialization
	void Start ()
	{
		//позиція камери в попередньому кадрі - це моя наявна позиція камери
		previousCamPos = cam.position;
		
		//тут магія для усіх моїх фонів
		parallaxScales = new float[backgrounds.Length];
		for (int i = 0; i < backgrounds.Length; i++)
		{
			parallaxScales[i] = backgrounds[i].position.z*-1;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		//магія для кожного фону окремо
		for (int i = 0; i < backgrounds.Length; i++)
		{
			Vector2 parallax = (previousCamPos - cam.position) * parallaxScales[i];
			
			//беремо за ціль фон у теперешній його позиції.
			Vector3 backgroundTargetPos = new Vector3(backgrounds[i].position.x + parallax.x, backgrounds[i].position.y + parallax.y, backgrounds[i].position.z);
			
			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargetPos, smoothing * Time.fixedDeltaTime);
		}
		previousCamPos = cam.position;
	}
}