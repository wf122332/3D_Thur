using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{
    /// <summary>
    /// ��ܸ��
    /// </summary>

    [CreateAssetMenu(menuName ="S/Dialogue Data",fileName ="New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("��ܪ̦W��")]
        public string dialogueName;
        [Header("��ܪ̤��e"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}
