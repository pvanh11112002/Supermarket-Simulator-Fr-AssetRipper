using System;
using System.Collections.Generic;
using UnityEngine;

public class Loom : MonoBehaviour
{
	private struct NoDelayedQueueItem
	{
		public Action<object> action;

		public object param;
	}

	private struct DelayedQueueItem
	{
		public Action<object> action;

		public object param;

		public float time;
	}

	private static bool isInitialized;

	public static Loom _ins;

	private List<NoDelayedQueueItem> listNoDelayActions;

	private List<DelayedQueueItem> listDelayedActions;

	private List<NoDelayedQueueItem> currentActions;

	private List<DelayedQueueItem> currentDelayed;

	public static Loom ins => null;

	private void Awake()
	{
	}

	public static void Initialize()
	{
	}

	public static void QueueOnMainThread(Action<object> taction, object param)
	{
	}

	public static void QueueOnMainThread(Action<object> action, object param, float time)
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}
