using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ScreenTransition : MonoBehaviour {
 
    
 
    //追加した
    //ボタンを押した時の処理
    public void OnClick()
    {
        SceneManager.LoadScene("MeishiScene");
    }
}