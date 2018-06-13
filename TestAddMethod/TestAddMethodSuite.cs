using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestAddMethod {
	[TestClass]
	public class TestAddMethodSuite {

		[TestMethod]
		public void TestMore() {
			var test1 = "abc";
			var result = Program.Add(test1);
			Assert.AreEqual(-1, result);
		}

		[TestMethod]
		public void TestAdd() { //make the method name descriptive to what it does
			var test4 = "a,2";
			var actual = Program.Add(test4);
			Assert.AreEqual(-1, actual); //asserts that the actual variable will be -1, if not then the test fails

			var test5 = "2,3";
			actual = Program.Add(test5);
			Assert.AreEqual(4, actual); //this should fail b/c 2+3=5

		}
	}
}
