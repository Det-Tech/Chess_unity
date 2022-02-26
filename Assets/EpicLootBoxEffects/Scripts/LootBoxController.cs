using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootBoxController : MonoBehaviour {

	public int idIcon;
	public int idEffect;
	public bool isOpened;

	// public GameObject[] IconPrefabs;
	public GameObject[] EffectPrefabs;
	public GameObject[] DesFxObjs;
	public GameObject[] DesIconObjs;
	private GameObject Lootbox;

	public Text effectsText;
	public Text nameEffectText;

	void Start () {
		idEffect += 1;
		idIcon += 1;
		isOpened = false;
		StartCoroutine(PlayFx());

		
	}

	private void OnMouseDown (){
		if (!isOpened) {
			StartCoroutine(PlayFx());
		}
	}

	IEnumerator PlayFx() {
		isOpened = true;
		idEffect = Mathf.Clamp(idEffect, 1, 25);
		Destroy (Lootbox);
		yield return new WaitForSeconds(0.3f);
		Instantiate (EffectPrefabs [idEffect], this.transform.position, this.transform.rotation);
	}


	// public void ResetVfx () {
	// 	DesFxObjs = GameObject.FindGameObjectsWithTag("Effects");
	
	// 	foreach(GameObject DesFxObj in DesFxObjs)
	// 			Destroy(DesFxObj.gameObject);
	// 	isOpened = false;

	// 	DesIconObjs = GameObject.FindGameObjectsWithTag("Icon");
	
	// 	foreach(GameObject DesIconObj in DesIconObjs)
	// 		Destroy(DesIconObj.gameObject);
	// 	StartCoroutine(PlayIcon());
	// }
}