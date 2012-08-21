using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace jni4net.proxygen.test
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void GetFoldersFromClassTypes_Success()
        {
            String[] testValues = new String[] {
                "com.jni4net.TestClass",
                "org.myapp.newclass"
            };

            List<String> jvmClassPaths = net.sf.jni4net.proxygen.Program
                .GetFoldersFromClassTypes(new List<String>(testValues));

            Assert.AreEqual(2, jvmClassPaths.Count);
            Assert.AreEqual("com\\jni4net", jvmClassPaths[0]);
            Assert.AreEqual("org\\myapp", jvmClassPaths[1]);
        }

        [Test]
        public void GetNormalizedFolderPathsFromFileURIs_Success()
        {
            String[] testValues = new String[] {
                "work\\jvm\\myclass.java",
                "work\\jvm\\org\\myapp\\newclass.java",
                "work\\jvm\\org\\myapp\\newclass2.java",
                "work\\jvm\\org\\myapp\\newclass3.java"
        };
            //System.Threading.Thread.Sleep(30000);
            List<String> jvmPaths = net.sf.jni4net.proxygen.Program
                .GetNormalizedFolderPathsFromFileURIs(new List<String>(testValues), "jvm");

            Assert.AreEqual(2, jvmPaths.Count);
            Assert.AreEqual("jvm\\", jvmPaths[0]);
            Assert.AreEqual("jvm\\org\\myapp\\", jvmPaths[1]);
        }
    }
}
