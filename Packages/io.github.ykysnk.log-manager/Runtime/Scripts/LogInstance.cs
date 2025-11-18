using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace io.github.ykysnk.LogManager
{
    [AddComponentMenu("yky/Log Manager/Log Instance")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class LogInstance : UdonSharpBehaviour
    {
        [SerializeField] private TMP_InputField inputField;

        public string Text
        {
            get => inputField.text;
            set => inputField.text = value;
        }

        private void OnValidate()
        {
            if (!Utilities.IsValid(inputField))
                inputField = GetComponent<TMP_InputField>();
        }
    }
}