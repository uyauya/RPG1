﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToOtherScene : MonoBehaviour
{
    private LoadSceneManager sceneManager;
    //　どのシーンへ遷移するか
    [SerializeField]
    private SceneMovementData.SceneType scene = SceneMovementData.SceneType.FirstVillage;
    //　シーン遷移中かどうか
    private bool isTransition;

    private void Awake()
    {
        sceneManager = FindObjectOfType<LoadSceneManager>();
    }

    private void OnTriggerEnter(Collider col)
    {
        //　次のシーンへ遷移途中でない時
        if (col.tag == "Player" && !isTransition)
        {
            isTransition = true;
            sceneManager.GoToNextScene(scene);
        }
    }
    //　フェードをした後にシーン読み込み
    IEnumerator FadeAndLoadScene(SceneMovementData.SceneType scene)
    {
        /*
        その他の処理
        */
        isTransition = false;
        yield return　null;   //補足
    }
}
