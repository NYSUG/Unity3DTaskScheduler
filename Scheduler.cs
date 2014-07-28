/**
 * @License Unity3DTaskScheduler v 1.0
 * (c) 2014 No, You Shut Up Games LLC. http://www.noyoushutupgames.com
 * License: MIT
 */

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Scheduler {
	
	private readonly Dictionary<Action, ScheduledTask> _scheduledTask = new Dictionary<Action, ScheduledTask>();

	public void Execute(Action action, int timeoutMs)
	{
		var task = new ScheduledTask(action, timeoutMs);
		task.TaskComplete += RemoveTask;
		_scheduledTask.Add(action, task);
		task.Timer.Start();
	}

	public void RemoveTask(object sender, EventArgs e)
	{
		var task = (ScheduledTask) sender;
		task.TaskComplete -= RemoveTask;
		ScheduledTask deleted;
		_scheduledTask.Remove(task.Action);
	}
}
