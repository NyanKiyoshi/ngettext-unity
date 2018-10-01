using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using ngettext_unity;

public class CoreTests {

    [Test]
    public void CoreTestsSimplePasses() {
        // Use the Assert class to test conditions.
        NGettextUnity.Instance.LoadLocale("fr-FR");
        Assert.AreEqual(
            NGettextUnity.Catalog.GetString("Hello, {0}!", "World"), "Heyo, World!");
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator CoreTestsWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
