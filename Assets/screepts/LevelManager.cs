using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Text coinstext;
	public float respawndDelay;
	public Playercontroler gamePlayer;
    public int coints;
    // Start is called before the first frame update
    void Start()
    {
		gamePlayer = FindObjectOfType<Playercontroler>();
        coinstext.text = "Scrore of Conits: " + coints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Respawn()
	{
		StartCoroutine("RespawnCoroutine");
	}
	public IEnumerator RespawnCoroutine()
	{
		gamePlayer.gameObject.SetActive(false);
		yield return new WaitForSeconds(respawndDelay);
		gamePlayer.transform.position = gamePlayer.RPoint;
		gamePlayer.gameObject.SetActive(true);
	}
    public void Addconits(int nuberofcoints)
    {
        coints += nuberofcoints;
        coinstext.text = "Scrore of Conits: " + coints;
    }
}
