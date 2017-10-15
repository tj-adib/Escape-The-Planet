using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class FinalScoreUI : MonoBehaviour {

	void Start ()
	{
        float sc = Planet.Score;

       

       
        GetComponent<Text>().text = "d = <i><b>" + sc.ToString("0.#") + "</b>m</i>";
        if (PlayerPrefs.GetFloat("High", 0) > sc)
        {
            PlayerPrefs.SetFloat("High", sc);
        }
    }

}
