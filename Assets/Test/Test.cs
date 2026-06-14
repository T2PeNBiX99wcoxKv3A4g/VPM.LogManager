using io.github.ykysnk.CheatClientProtector;
using io.github.ykysnk.LogManager;
using UnityEngine;

namespace Test
{
#if !COMPILER_UDONSHARP && UNITY_EDITOR
    public partial class Test : ILogManager
    {
        public LogManager LogManager
        {
            get => logManager;
            set => logManager = value;
        }
    }
#endif

    public partial class Test : CheatClientProtectorBehaviour
    {
        [SerializeField] private LogManager logManager;

        private void Start()
        {
            logManager.Log("black", "test", $"test: {this}", logManager.RandomKey);
        }

        public override void Interact()
        {
            logManager.Log("black", "test", $"interact test: {this}", logManager.RandomKey);
        }
    }
}