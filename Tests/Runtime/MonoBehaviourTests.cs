using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;

public class MonoBehaviourTests
{
    protected GameObject subject;

    [SetUp]
    public void SetUp()
    {
        subject = new GameObject("Subject");
    }

    [TearDown]
    public void TearDown()
    {
        Object.FindObjectsOfType<GameObject>().ToList().ForEach(go => Object.DestroyImmediate(go));
    }
}
