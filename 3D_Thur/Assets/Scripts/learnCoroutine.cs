using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

namespace S
{
    /// <summary>
    /// �ǲߨ�P�{�� (coroutine)
    /// ���{�����d�F�쵥�ݪ��ĪG
    /// </summary>

    public class learnCoroutine : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(Test());
        }


        private IEnumerator Test()
        {
            print("<color=#33ff33>�Ĥ@��{��</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>�ĤG��{��</color>");
        }
    }
}