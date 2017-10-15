using UnityEngine.UI;
using UnityEngine;

public class ScoreUI : MonoBehaviour {

	public Text text;
    

	RectTransform rt;
	Vector2 startPos;

	void Start ()
	{
		rt = GetComponent<RectTransform>();
		startPos = rt.anchoredPosition;
    }

	void Update ()
	{

        float sc = Planet.Score;

        text.text = sc.ToString("0.#") + "m";

       

       
       

		rt.anchoredPosition = Vector2.Lerp(Vector2.zero, startPos, Planet.Size);
	}

}
