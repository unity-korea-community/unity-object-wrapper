using System.Collections;
using Moq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

[Category("UNKO")]
public class ActivatorTests : MonoBehaviourTests
{
    [UnityTest]
    public IEnumerator Start_GameObjectIsSet_CallsSetActive()
    {
        var go = new Mock<IGameObject>();
        var activator = subject.AddComponent<Activator>();
        activator.ObjectToActivate = go.Object;

        yield return new WaitForEndOfFrame(); // Awake
        yield return new WaitForEndOfFrame(); // Start

        go.Verify(g => g.SetActive(true));
        Assert.IsTrue(go.Object.activeSelf);
    }
}