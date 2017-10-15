using System.Collections;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

	public GameObject meteorPrefab;
	public float distance = 20f;
    public float intervalMeterior = 1f;

	void Start ()
	{
		StartCoroutine(SpawnMeteor());
	}

	IEnumerator SpawnMeteor()
	{
		Vector3 pos = Random.onUnitSphere * distance;
		Instantiate(meteorPrefab, pos, Quaternion.identity);

		yield return new WaitForSeconds(intervalMeterior);

		StartCoroutine(SpawnMeteor());
	}

}
