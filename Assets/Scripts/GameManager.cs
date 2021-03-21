using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject inputGOTarget;
    public GameObject inputWin;
     public Text inputScoreText;

     private int score =0;
     private bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAparecer", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(win == true)
        {
            CancelInvoke("SpawnAparecer");
        }

        if(Input.GetMouseButtonDown(0)){
            GetComponent<AudioSource>().Play();
        }
    }

    void SpawnAparecer(){
        float randomX = Random.Range(-5.42f,5.62f);
        float randomY = Random.Range(-3.78f,3.87f);

        Vector3 position = new Vector3(randomX, randomY, 0);

        Instantiate(inputGOTarget, position, Quaternion.identity);
    }

    public void IncrementScore(){
        score++;
        inputScoreText.text = score.ToString();

        if(score >=10){
            win = true;
            inputWin.SetActive(true);
        }
    }
}
