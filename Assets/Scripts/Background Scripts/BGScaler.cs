using UnityEngine;
using System.Collections;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;
        float width= sr.sprite.bounds.size.x;
        float worldHeight = Camera.main.orthographicSize * 2.0f;
        float worldWidth = worldWidth = worldHeight / Screen.height * Screen.width;
        tempScale.x = worldWidth / width;
        transform.localScale = tempScale;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
