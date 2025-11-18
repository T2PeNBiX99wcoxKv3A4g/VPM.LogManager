using io.github.ykysnk.CheatClientProtector;
using io.github.ykysnk.LogManager;
using UnityEngine;

namespace Test
{
    public class Test : CheatClientProtectorBehaviour
#if !COMPILER_UDONSHARP && UNITY_EDITOR
        , ILogManager
#endif
    {
        [SerializeField] private LogManager logManager;

        private void Start()
        {
            logManager.Log("black", "test", $"test: {this}", logManager.RandomKey);
        }

#if !COMPILER_UDONSHARP && UNITY_EDITOR
        public LogManager LogManager
        {
            get => logManager;
            set => logManager = value;
        }
#endif

        public override void Interact()
        {
            logManager.Log("black", "test", $"interact test: {this}", logManager.RandomKey);
        }
    }
}