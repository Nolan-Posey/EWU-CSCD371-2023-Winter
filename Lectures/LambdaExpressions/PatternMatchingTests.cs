using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LambdaExpressions;
[TestClass]
public class PatternMatchingTests
{
    [TestMethod]
    public void SetName_IndigoMontoya_Success()
    {
        FullName testName = new FullName("Indigo Montoya");
        (string firstName,string lastName) actual = (testName.FirstName, testName.LastName);
        Assert.AreEqual<(string,string)>(("Indigo", "Montoya"), actual);
        Assert.IsTrue(testName.FirstName is "Indigo");
    }

    [TestMethod]
    public void Initials_InigoMontoya_Success()
    {
        FullName testName = new FullName("Inigo Montoya");
        string actuals = testName.Initials;
        Assert.AreEqual<string>("IM", actuals);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_EmptyStrings_Fails()
    {
        _ = new FullName("", "");
    }

    [TestMethod]
    public void MyTestMethod()
    {
        (string, string) name = ("Inigo", "Montoya");
        _ = name switch
        {
            (string {Length: > 0 and < 10 } firstName, string {Length: > 0 and < 10 } lastName) => true,

        };
    }
}