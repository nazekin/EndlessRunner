using UnityEngine;
using System.Collections;

public class TiledBackground : MonoBehaviour {

	//Height and Width are equal
	public int textureWidth = 32;
	public bool scaleHorizontally = true;
	public bool scaleVertically = true;

	// Use this for initialization
	void Start () {

		var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil (Screen.width / (textureWidth * PixelPerfectCamera.scale));
		var newHeight = !scaleVertically ? 1 : Mathf.Ceil (Screen.height / (textureWidth * PixelPerfectCamera.scale));

		transform.localScale = new Vector3 (newWidth * textureWidth, newHeight * textureWidth, 1);

		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 ( newWidth, newHeight, 1);
	}
}
