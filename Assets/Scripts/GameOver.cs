using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void Update ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			GameManager.instance.Restart();
		}

        if (Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene("Menu");
        }

        GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
	}

	public void Menu ()
	{
        SceneManager.LoadScene("Menu");
    }

}
