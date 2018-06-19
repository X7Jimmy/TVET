using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private float size;

    [SerializeField]
    GameObject platform;
    Vector3 lastpos;
	void Start () {
        size = platform.transform.localScale.x;
        lastpos = platform.transform.position;
        for (int x = 0; x < 24; x++);
        {
            SpawnZ();
        }
        InvokeRepeating("SpawnPlatform", 2f, 0.2f);
	}
	
	void Update () {
		
	}
    private void SpawnPlatform()
    {
        int random = Random.Range(0, 6);
        if (random < 3)
            SpawnX();

        if (random >= 3)
            SpawnZ();
    }
    private void SpawnX()
    {
        GameObject _platform = Instantiate(platform) as GameObject;
        _platform.transform.position += new Vector3(size, 0f, 0f);
        lastpos = platform.transform.position;
    }

    private void SpawnZ()
    {
        GameObject _platform = Instantiate(platform) as GameObject;
        _platform.transform.position += new Vector3(0f, 0f, size);
        lastpos = platform.transform.position;

    }
}
