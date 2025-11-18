using io.github.ykysnk.CheatClientProtector;
using io.github.ykysnk.LogManager;
using UnityEngine;

namespace Test
{
    public class Test : CheatClientProtectorBehaviour
    {
        [SerializeField] private LogManager logManager;

        private void Start()
        {
            logManager.Log("black", "test", $"test: {this}", logManager.RandomKeyPublic);
        }

        public override void Interact()
        {
            logManager.Log("black", "test", $"test: {this}", logManager.RandomKeyPublic);
        }
    }
}