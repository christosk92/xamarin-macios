//
// Unit tests for HKWorkoutBuilder
//
// Authors:
//	TJ Lambert  <TJ.Lambert@microsoft.com>
//
// Copyright 2022 Xamarin Inc. All rights reserved.
//

#if HAS_HEALTHKIT

using System;

using Foundation;
using HealthKit;
using UIKit;
using NUnit.Framework;

namespace MonoTouchFixtures.HealthKit {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class HKWorkoutBuilderTest {

		[Test]
		public void GetSeriesBuilderNullReturnTest ()
		{
			var store = new HKHealthStore ();
			var seriesBuilder = new HKWorkoutBuilder (new HKHealthStore (), new HKWorkoutConfiguration (), HKDevice.LocalDevice);
			var ret = seriesBuilder.GetSeriesBuilder (HKSeriesType.HeartbeatSeriesType);
			Assert.IsNull (ret, "GetSeriesBuilder should return a null value without proper configuration.");
		}
	}
}
#endif // HAS_HEALTHKIT
