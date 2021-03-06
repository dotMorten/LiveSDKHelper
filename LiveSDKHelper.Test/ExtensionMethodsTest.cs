﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable CheckNamespace
namespace LiveSDKHelper.Test.ExtensionMethodsClass
{
	public class ExtensionMethodsTest
	{
		[TestClass]
		public class ToConcatenatedStringMethodTest
		{
			[TestMethod]
			public void MustReturnConcatenatedValuesFromListOfStrings()
			{
				var list = new List<string> { "1", "2", "3" };

				var result = list.ToConcatenatedString(item => item);

				var expected = "123";

				Assert.AreEqual(expected, result);
			}

			[TestMethod]
			public void MustReturnCommaSeparatedValuesFromListOfStrings()
			{
				var list = new List<string> { "1", "2", "3" };

				var result = list.ToConcatenatedString(item => item, ",");

				var expected = "1,2,3";

				Assert.AreEqual(expected, result);
			}

			[TestMethod]
			public void MustReturnCommaSeparatedValuesWithSpaceFromListOfStrings()
			{
				var list = new List<string> { "1", "2", "3" };

				var result = list.ToConcatenatedString(item => item, ", ");

				var expected = "1, 2, 3";

				Assert.AreEqual(expected, result);
			}

			[TestMethod]
			public void MustReturnPipeSeparatedValuesWithSurroundingSpaceFromListOfStrings()
			{
				var list = new List<string> { "1", "2", "3" };

				var result = list.ToConcatenatedString(item => item, " | ");

				var expected = "1 | 2 | 3";

				Assert.AreEqual(expected, result);
			}

			[TestMethod]
			public void MustReturnSpaceSeparatedValuesFromListOfScopes()
			{
				var list = new List<Scope> { Scope.SignIn, Scope.Basic, Scope.SkyDrive };

				var result = list.ToConcatenatedString(item => item.ToStringScope(), " ");

				var expected = "wl.signin wl.basic wl.skydrive";

				Assert.AreEqual(expected, result);
			}
		}

		[TestClass]
		public class ToScopeMethodTest
		{
			[TestMethod]
			public void MustReturnStringScope()
			{
				var scope = Scope.SkyDriveUpdate;

				var scopeName = scope.ToStringScope();

				var expected = "wl.skydrive_update";

				Assert.AreEqual(expected, scopeName);
			}
		}
	}
}
