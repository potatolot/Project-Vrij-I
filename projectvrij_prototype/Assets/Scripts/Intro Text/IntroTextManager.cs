using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTextManager : MonoBehaviour
{
    Text sentence1;
    Text sentence2;
    Text sentence3;
    // Start is called before the first frame update
    void Start()
    {
        sentence1 = GameObject.Find("Sentence1").GetComponent<Text>();
        sentence2 = GameObject.Find("Sentence2").GetComponent<Text>(); ;
        sentence3 = GameObject.Find("Sentence3").GetComponent<Text>(); ;


        
    }

    private void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Sentence1();
    }

    void Sentence1()
    {
        sentence1.text = "my name is emily.";
        StartCoroutine(Sentence2());
    }

    IEnumerator Sentence2()
    {
        yield return new WaitForSeconds(2);
        sentence2.text = "what you are about to see is a snippet of my life.";
        StartCoroutine(Sentence3());
    }

    IEnumerator Sentence3()
    {
        yield return new WaitForSeconds(2);
        sentence3.text = "...or...well, our lives.";
        
 
    }
}
