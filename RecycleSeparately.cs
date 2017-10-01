using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DTObjectPoolManager.Internal;

namespace DTObjectPoolManager {
	public class RecycleSeparately : MonoBehaviour, IRecycleCleanupSubscriber {
		// PRAGMA MARK - IRecycleCleanupSubscriber Implementation
		void IRecycleCleanupSubscriber.OnRecycleCleanup() {
			ObjectPoolManager.Recycle(this);
		}
	}
}