using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

namespace S
{
    /// <summary>
    /// 學習協同程序 (coroutine)
    /// 讓程式停留達到等待的效果
    /// </summary>

    public class learnCoroutine : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(Test());
        }


        private IEnumerator Test()
        {
            print("<color=#33ff33>第一行程式</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>第二行程式</color>");
        }
    }
}