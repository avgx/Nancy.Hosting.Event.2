﻿using System;
using System.Runtime.InteropServices;

namespace Nancy.Hosting.Event2.Interop
{
	internal class EventBase : SafeHandle
	{
		public EventBase()
			: base(IntPtr.Zero, true)
		{
		}

		protected override bool ReleaseHandle()
		{
			Event.EventBaseFree(handle);
			return true;
		}

		public override bool IsInvalid
		{
			get { return handle == IntPtr.Zero; }
		}
	}
}