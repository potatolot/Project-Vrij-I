using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndCutscene : MonoBehaviour
{
    Animator EndScene;
    Animator Text;
    public GameObject Menu;
    Animator Credits;

    bool end = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(showEnd());
        EndScene = GameObject.Find("Panel").GetComponent<Animator>();
        Text = GameObject.Find("Text").GetComponent<Animator>();
        Credits = GameObject.Find("Credits").GetComponent<Animator>();    
    }


    private void Awake()
    {
        GameObject.FindGameObjectWithTag("music").GetComponent<SoundStart>().PlayMusic();
        Menu.SetActive(false);
    }
    void Update()
    {
       //if(textshow)
       // {
       //     TextS();
       // }


    }

    IEnumerator showEnd()
    {
        yield return new WaitForSeconds(3);
        EndScene.Play("EndScene", 0, 0);
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(2);
        Text.Play("TextShow", 0, 0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Menu.SetActive(true);
        StartCoroutine(ShowCredits());
    }
    IEnumerator ShowCredits()
    {
        yield return new WaitForSeconds(1);
        Credits.Play("CreditSRoll", 0, 0);
    }
    public void toMenu()
    {
        SceneManager.LoadScene("HomeMenu");
    }
}
