﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Duality;
using Duality.Drawing;

using NUnit.Framework;

namespace Duality.Tests.Utility
{
	[TestFixture]
	public class LogFormatTest
	{
		[Test] public void HumanFriendlyId()
		{
			// Check whether both negative and positive numbers return valid strings
			for (int i = -10; i <= 10; i++)
			{
				string id = LogFormat.HumanFriendlyId(i);
				Assert.IsNotNullOrEmpty(id);
			}

			// Check a large number of sequential ID tokens, expect no collisions
			HashSet<string> knownIds = new HashSet<string>();
			for (int i = 0; i < 1000; i++)
			{
				string id = LogFormat.HumanFriendlyId(i);
				Assert.IsNotNullOrEmpty(id);
				Assert.IsTrue(knownIds.Add(id));
			}

			// Check a large number of random ID tokens, expect valid strings
			Random rnd = new Random(1);
			for (int i = 0; i < 1000; i++)
			{
				string id = LogFormat.HumanFriendlyId(rnd.Next());
				Assert.IsNotNullOrEmpty(id);
			}

			// Expect the same token to always return the same result
			for (int i = 0; i < 1000; i++)
			{
				int token = rnd.Next();
				string id1 = LogFormat.HumanFriendlyId(token);
				string id2 = LogFormat.HumanFriendlyId(token);
				Assert.AreEqual(id1, id2);
			}

			// Check special numbers
			Assert.IsNotNullOrEmpty(LogFormat.HumanFriendlyId(0));
			Assert.IsNotNullOrEmpty(LogFormat.HumanFriendlyId(int.MaxValue));
			Assert.IsNotNullOrEmpty(LogFormat.HumanFriendlyId(int.MinValue));
		}
	}
}
