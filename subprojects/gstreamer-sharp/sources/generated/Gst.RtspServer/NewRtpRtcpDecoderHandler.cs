// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServer {

	using System;

	public delegate void NewRtpRtcpDecoderHandler(object o, NewRtpRtcpDecoderArgs args);

	public class NewRtpRtcpDecoderArgs : GLib.SignalArgs {
		public Gst.Element Object{
			get {
				return (Gst.Element) Args [0];
			}
		}

	}
}