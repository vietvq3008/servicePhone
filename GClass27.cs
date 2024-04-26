using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;
using OpenCvSharp;
using OpenCvSharp.Extensions;

public class GClass27
{
	public enum GEnum10
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = 5,
		const_6 = 6,
		const_7 = 7,
		const_8 = 8,
		const_9 = 9,
		const_10 = 10,
		const_11 = 11,
		const_12 = 12,
		const_13 = 13,
		const_14 = 14,
		const_15 = 0xF,
		const_16 = 0x10,
		const_17 = 17,
		const_18 = 18,
		const_19 = 19,
		const_20 = 20,
		const_21 = 21,
		const_22 = 22,
		const_23 = 23,
		const_24 = 24,
		const_25 = 25,
		const_26 = 26,
		const_27 = 27,
		const_28 = 28,
		const_29 = 29,
		const_30 = 30,
		const_31 = 0x1F,
		const_32 = 0x20,
		const_33 = 33,
		const_34 = 34,
		const_35 = 35,
		const_36 = 36,
		const_37 = 37,
		const_38 = 38,
		const_39 = 39,
		const_40 = 40,
		const_41 = 41,
		const_42 = 42,
		const_43 = 43,
		const_44 = 44,
		const_45 = 45,
		const_46 = 46,
		const_47 = 47,
		const_48 = 48,
		const_49 = 49,
		const_50 = 50,
		const_51 = 51,
		const_52 = 52,
		const_53 = 53,
		const_54 = 54,
		const_55 = 55,
		const_56 = 56,
		const_57 = 57,
		const_58 = 58,
		const_59 = 59,
		const_60 = 60,
		const_61 = 61,
		const_62 = 62,
		const_63 = 0x3F,
		const_64 = 0x40,
		const_65 = 65,
		const_66 = 66,
		const_67 = 67,
		const_68 = 68,
		const_69 = 69,
		const_70 = 70,
		const_71 = 71,
		const_72 = 72,
		const_73 = 73,
		const_74 = 74,
		const_75 = 75,
		const_76 = 76,
		const_77 = 77,
		const_78 = 78,
		const_79 = 79,
		const_80 = 80,
		const_81 = 81,
		const_82 = 82,
		const_83 = 83,
		const_84 = 187,
		const_85 = 164
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class E59F4C14
	{
		public static readonly E59F4C14 _003C_003E9 = new E59F4C14();

		public static Func<string, Guid> _003C_003E9__130_0;

		public static Func<Rect, int> _003C_003E9__158_0;

		public static Func<Rect, int> _003C_003E9__158_1;

		public static Func<string, Guid> _003C_003E9__176_0;

		public static Func<string, Guid> _003C_003E9__176_1;

		public static Func<string, bool> _003C_003E9__181_0;

		public static Func<string, bool> _003C_003E9__189_0;

		public static Func<string, string> _003C_003E9__212_0;

		internal Guid method_0(string string_0)
		{
			return Guid.NewGuid();
		}

		internal int method_1(Rect rect_0)
		{
			return rect_0.Y;
		}

		internal int method_2(Rect rect_0)
		{
			return rect_0.X;
		}

		internal Guid method_3(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_4(string string_0)
		{
			return Guid.NewGuid();
		}

		internal bool method_5(string string_0)
		{
			return !string.IsNullOrEmpty(string_0);
		}

		internal bool method_6(string string_0)
		{
			return string_0.StartsWith("com.facebook.ka");
		}

		internal string method_7(string string_0)
		{
			return string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class51
	{
		public string string_0;

		public string string_1;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				string_0 = string_0 + e.Data + "\n";
			}
		}

		internal void method_1(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				string_1 = string_1 + e.Data + "\n";
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class52
	{
		public string string_0;

		public GClass27 gclass27_0;

		internal void method_0()
		{
			gclass27_0.method_97("shell am start -n " + string_0 + "/v.q -c android.intent.category.LAUNCHER -a android.intent.action.MAIN");
		}
	}

	[CompilerGenerated]
	private sealed class Class53
	{
		public GClass27 gclass27_0;

		public int int_0;

		internal void method_0()
		{
			lock (gclass27_0.object_0)
			{
				int tickCount = Environment.TickCount;
				do
				{
					gclass27_0.bool_2 = gclass27_0.gclass25_0.method_1() == 1;
				}
				while (!gclass27_0.bool_2 && Environment.TickCount - tickCount < int_0 * 1000);
			}
		}
	}

	private Random random_0 = new Random();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_0 = "http://127.0.0.1";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_1 = "4723";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0 = 360000;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_2 = "";

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_3 = "";

	public bool bool_0 = false;

	private string string_4 = "";

	public string string_5 = "com.facebook.katana";

	public string string_6 = "com.ss.android.ugc.trill";

	public string string_7 = "com.instagram.android";

	public bool bool_1 = false;

	private System.Drawing.Point? nullable_0 = null;

	public int int_1 = 0;

	public string string_8 = "";

	public GClass25 gclass25_0;

	private bool bool_2 = false;

	private object object_0 = new object();

	private int int_2 = 0;

	private int int_3 = 10;

	public string string_9 = "";

	private object object_1 = new object();

	private object object_2 = new object();

	private string string_10 = "";

	private string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	private string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	private string String_3
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string method_0()
	{
		if (String_3 == "")
		{
			String_3 = method_97("shell getprop ro.build.version.release");
		}
		return String_3;
	}

	public string method_1(bool bool_3 = false)
	{
		if (string_4 == "")
		{
			string_4 = Class76.smethod_4(String_2);
			if (string_4 == "")
			{
				if (bool_3)
				{
					return "";
				}
				method_16();
			}
		}
		return string_4;
	}

	public void method_2(string string_11 = "")
	{
		string_4 = string_11;
	}

	public void method_3(int int_4, string string_11)
	{
		int_1 = int_4;
		string_8 = string_11;
	}

	public void method_4()
	{
		method_97("shell settings put global http_proxy :0");
		method_97("shell settings delete global http_proxy");
		method_97("shell settings delete global global_http_proxy_host");
		method_97("shell settings delete global global_http_proxy_port");
		method_98("com.cell47.College_Proxy");
		int_1 = 0;
		string_8 = "";
	}

	public bool method_5(int int_4 = 0)
	{
		if (string.IsNullOrEmpty(string_8))
		{
			return true;
		}
		if (int_4 == 0)
		{
			method_97("shell settings put global http_proxy " + string_8);
			return true;
		}
		return method_32(string_8);
	}

	public void method_6(string string_11, string string_12)
	{
		gclass25_0 = new GClass25(string_11, string_12, 0, 1);
	}

	public string method_7()
	{
		bool_2 = false;
		return gclass25_0.string_1;
	}

	public void method_8(int int_4 = 60)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			lock (object_0)
			{
				int tickCount = Environment.TickCount;
				do
				{
					bool_2 = gclass25_0.method_1() == 1;
				}
				while (!bool_2 && Environment.TickCount - tickCount < int_4 * 1000);
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	public bool method_9(int int_4 = 300)
	{
		lock (object_0)
		{
		}
		int tickCount = Environment.TickCount;
		do
		{
			if (bool_2)
			{
				if (gclass25_0.method_4())
				{
					return true;
				}
			}
			else
			{
				method_8();
				lock (object_0)
				{
				}
				method_81(5.0);
			}
		}
		while (Environment.TickCount - tickCount < int_4 * 1000);
		return false;
	}

	private string method_10(int int_4, string string_11, string string_12 = "")
	{
		try
		{
			string text3;
			while (true)
			{
				if (!bool_1)
				{
					string text = $"{String_0}:{String_1}/wd/hub";
					if (string_11.Contains("{this.sessionId}"))
					{
						string text2 = method_1();
						if (text2 == "")
						{
							return "";
						}
						text += string_11.Replace("{this.sessionId}", text2);
					}
					else
					{
						text += string_11;
					}
					GClass24 gClass = new GClass24("", "", "", 0);
					text3 = ((int_4 == 0) ? gClass.method_0(text) : gClass.method_1(text, string_12, "application/json"));
					if (!bool_1)
					{
						if (text3.Contains("cannot be proxied to UiAutomator2 server because the instrumentation process is not running (probably crashed)"))
						{
							if (int_2 >= int_3)
							{
								int_2 = 0;
								Class76.smethod_2();
								Class76.smethod_3();
							}
							int_2++;
							continue;
						}
						int_2 = 0;
						if (text3.Contains("Cannot find any free port in range 8200..8299"))
						{
							GClass7.smethod_3();
							GClass7.smethod_4();
							continue;
						}
						if (text3.Contains("cannot_connect") || text3.Contains("A session is either terminated or not started") || text3.Contains("Could not proxy command to the remote server") || text3.Contains("The requested resource could not be found, or a request was received using an HTTP method that is not supported by the mapped resource"))
						{
							Class76.smethod_3();
							method_17();
							continue;
						}
						if (!(Regex.Match(text3, "device (.*?) not found").Groups[1].Value != "") && !text3.Contains("was not in the list of connected devices") && !text3.Contains("Could not find a connected Android device"))
						{
							break;
						}
						if (method_12())
						{
							continue;
						}
						return "disconnect";
					}
					return "disconnect";
				}
				return "disconnect";
			}
			return text3;
		}
		catch (Exception)
		{
			return "";
		}
	}

	private bool method_11()
	{
		List<string> list = GClass7.smethod_0();
		if (list.Contains(String_2))
		{
			return true;
		}
		if (String_2.StartsWith("127.0.0.1:") || String_2.StartsWith("emulator-"))
		{
			if (String_2.StartsWith("127.0.0.1:"))
			{
				String_2 = string.Format("emulator-{0}", Convert.ToInt32(String_2.Replace("127.0.0.1:", "")) - 1);
			}
			else if (String_2.StartsWith("emulator-"))
			{
				String_2 = string.Format("127.0.0.1:{0}", Convert.ToInt32(String_2.Replace("emulator-", "")) + 1);
			}
			return list.Contains(String_2);
		}
		return false;
	}

	private bool method_12(int int_4 = 60)
	{
		try
		{
			if (method_11())
			{
				return true;
			}
			int tickCount = Environment.TickCount;
			bool flag = false;
			while (!bool_1)
			{
				string input = method_97("reconnect");
				if (!(flag = Regex.Match(input, "device (.*?) not found").Groups[1].Value == "") && (String_2.StartsWith("127.0.0.1:") || String_2.StartsWith("emulator-")))
				{
					int num = 0;
					if (String_2.StartsWith("127.0.0.1:"))
					{
						num = Convert.ToInt32(String_2.Replace("127.0.0.1:", ""));
					}
					else if (String_2.StartsWith("emulator-"))
					{
						num = Convert.ToInt32(String_2.Replace("emulator-", "")) + 1;
					}
					flag = !GClass7.smethod_1($"adb connect 127.0.0.1:{num}").Contains("cannot connect to");
				}
				if (flag)
				{
					method_81(3.0);
					if (method_11())
					{
						return true;
					}
				}
				if (Environment.TickCount - tickCount >= int_4 * 1000)
				{
					break;
				}
			}
			bool_1 = true;
			LicenseManager.gclass26_0.method_1(this);
		}
		catch (Exception)
		{
		}
		return false;
	}

	private string method_13(string string_11)
	{
		return method_10(0, string_11);
	}

	public string method_14(string string_11, string string_12)
	{
		return method_10(1, string_11, string_12);
	}

	public GClass27(string string_11)
	{
		String_2 = string_11;
	}

	private string method_15()
	{
		string string_ = "/session/{this.sessionId}";
		return method_13(string_);
	}

	private bool method_16()
	{
		while (Class76.int_0 >= Class76.int_1)
		{
			FormHelper.smethod_64(1.0);
		}
		Class76.int_0++;
		string text = "";
		string string_ = "/session";
		JsonHelper gClass = new JsonHelper();
		gClass.AddValue("platformName", "Android");
		gClass.AddValue("platformVersion", method_0());
		gClass.AddValue("deviceName", String_2);
		gClass.AddValue("udid", String_2);
		gClass.AddValue("automationName", "UiAutomator2");
		gClass.AddValue("noReset", true);
		gClass.AddValue("disableWindowAnimation", true);
		gClass.AddValue("gpsEnabled", false);
		gClass.AddValue("skipLogcatCapture", true);
		gClass.AddValue("dontStopAppOnReset", true);
		gClass.AddValue("ignoreHiddenApiPolicyError", true);
		gClass.AddValue("noSign", false);
		gClass.AddValue("newCommandTimeout", Int32_0);
		string text2 = "{ \"desiredCapabilities\":" + gClass.GetJsonString() + "}";
		string text3 = method_14(string_, text2);
		try
		{
			text = JObject.Parse(text3)["sessionId"]!.ToString();
		}
		catch (Exception)
		{
		}
		if (text != "")
		{
			method_2(text);
			method_19(text3);
		}
		else
		{
			lock (Class76.object_1)
			{
				File.AppendAllText("device.txt", text2 + Environment.NewLine);
				File.AppendAllText("device.txt", text3 + Environment.NewLine);
				File.AppendAllText("device.txt", "-----------------------------" + Environment.NewLine);
			}
		}
		Class76.int_0--;
		return text != "";
	}

	public bool method_17()
	{
		string text = method_1(bool_3: true);
		if (text == "")
		{
			return false;
		}
		string text2 = "/session/" + text;
		string requestUriString = $"{String_0}:{String_1}/wd/hub" + text2.Replace("{this.sessionId}", text);
		bool result = false;
		try
		{
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "DELETE";
			webRequest.Headers["Cache-Control"] = "no-cache";
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				streamReader.ReadToEnd();
			}
			result = true;
		}
		catch (Exception)
		{
		}
		method_2();
		return result;
	}

	private string method_18(int int_4, List<string> list_0 = null)
	{
		string result = "";
		try
		{
			if (list_0 == null || list_0.Count == 0)
			{
				list_0 = GClass7.smethod_0();
			}
			new List<string>
			{
				"127.0.0.1:" + (int_4 * 2 + 5555),
				"emulator-" + (int_4 * 2 + 5554)
			};
		}
		catch
		{
		}
		return result;
	}

	public System.Drawing.Point? method_19(string string_11 = "")
	{
		try
		{
			if (!nullable_0.HasValue)
			{
				if (string.IsNullOrEmpty(string_11))
				{
					string_11 = method_15();
				}
				if (string_11.Contains("deviceScreenSize"))
				{
					string text = JObject.Parse(string_11)["value"]!["deviceScreenSize"]!.ToString();
					nullable_0 = new System.Drawing.Point(Convert.ToInt32(text.Split('x')[0]), Convert.ToInt32(text.Split('x')[1]));
				}
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return nullable_0;
	}

	public int method_20()
	{
		return method_19().Value.Y;
	}

	public int method_21()
	{
		return method_19().Value.X;
	}

	public string method_22()
	{
		try
		{
			string string_ = "/session/{this.sessionId}/appium/device/current_activity";
			string json = method_13(string_);
			return JObject.Parse(json)["value"]!.ToString();
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return "";
	}

	private bool method_23(string string_11)
	{
		try
		{
			method_168("Open app " + string_5 + "...");
			string string_12 = "/session/{this.sessionId}/appium/device/activate_app";
			string string_13 = "{\"bundleId\": \"" + string_11 + "\"}";
			method_14(string_12, string_13);
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	private void method_24()
	{
		method_97("reboot recovery");
		for (int i = 0; i < 2; i++)
		{
			method_97("wait-for-recovery");
			if (i == 0)
			{
				method_81(5.0);
			}
		}
	}

	internal void method_25(string string_11)
	{
		method_97("shell twrp format data");
		method_97("shell twrp wipe data");
		method_97("shell twrp wipe cache");
		method_97("shell twrp wipe dalvik");
		method_97("shell twrp wipe system");
		List<string> list = Directory.GetFiles(string_11).ToList();
		for (int i = 0; i < list.Count; i++)
		{
			method_97("shell rm -r /sdcard/");
			method_97("push \"" + list[i] + "\" /sdcard/" + Path.GetFileName(list[i]), 600);
			method_97("shell twrp install /sdcard/" + Path.GetFileName(list[i]), 600);
		}
		method_97("reboot");
	}

	private int method_26(string string_11)
	{
		try
		{
			string string_12 = "/session/{this.sessionId}/appium/device/app_state";
			string string_13 = "{\"bundleId\": \"" + string_11 + "\"}";
			string json = method_14(string_12, string_13);
			return Convert.ToInt32(JObject.Parse(json)["value"]!.ToString());
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return -1;
	}

	public bool method_27(string string_11)
	{
		try
		{
			method_97("shell su -c am start -n " + string_11);
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public bool method_28(int int_4 = 1, double double_0 = 0.5)
	{
		try
		{
			method_168("Back...");
			string string_ = "/session/{this.sessionId}/back";
			for (int i = 0; i < int_4; i++)
			{
				method_14(string_, "");
				method_81(double_0);
			}
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public string method_29(int int_4, string string_11, List<string> list_0)
	{
		return method_30(int_4, ref string_11, list_0);
	}

	public string method_30(int int_4, ref string string_11, List<string> list_0)
	{
		int tickCount = Environment.TickCount;
		do
		{
			if (!bool_1)
			{
				if (string_11 == "")
				{
					string_11 = method_53();
				}
				for (int i = 0; i < list_0.Count; i++)
				{
					if (method_31(0, string_11, list_0[i]))
					{
						return list_0[i];
					}
				}
				if (int_4 == 0 || Environment.TickCount - tickCount > int_4 * 1000)
				{
					break;
				}
				method_81(1.0);
				string_11 = "";
				continue;
			}
			return "";
		}
		while (Environment.TickCount - tickCount < int_4 * 1000);
		return "";
	}

	public bool method_31(int int_4, string string_11, string string_12)
	{
		return method_37(int_4, string_11, string_12).Count > 0;
	}

	internal bool method_32(string string_11)
	{
		if (!method_175().Contains("com.cell47.College_Proxy"))
		{
			method_177(ApplicationHelper.GetApplicationDirectory() + "\\app\\collegeproxy.apk");
			method_81(3.0);
		}
		method_98("com.cell47.College_Proxy");
		method_85("com.cell47.College_Proxy");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 120;
		while (!bool_1)
		{
			text = method_53();
			text2 = method_29(0, text, new List<string> { "//*[@text='STOP PROXY SERVICE']", "(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]", "//android.widget.Button[@text='START SERVICE']", "//*[@text='Please enter a valid IPV4 server address.']", "//*[@text='OK']" });
			switch (text2)
			{
			case "//android.widget.Button[@text='START SERVICE']":
				if (!method_146(text, "Things are good and ready to go"))
				{
					method_60(text2, text);
					break;
				}
				method_60(text2, text);
				return true;
			case "//*[@text='OK']":
				method_60(text2, text);
				break;
			case "(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]":
				method_50("(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]", string_11.Split(':')[0]);
				method_50("(//*[starts-with(@text,'Proxy Port:')]/parent::*/child::*)[last()]", string_11.Split(':')[1]);
				if (string_11.Split(':').Length > 3)
				{
					method_50("(//*[starts-with(@text,'Username:')]/parent::*/child::*)[last()]", string_11.Split(':')[2]);
					method_50("(//*[starts-with(@text,'Password:')]/parent::*/child::*)[last()]", string_11.Split(':')[3]);
				}
				method_60("//*[@text='START PROXY SERVICE']");
				break;
			case "//*[@text='STOP PROXY SERVICE']":
				method_163();
				return true;
			case "//*[@text='Please enter a valid IPV4 server address.']":
				return false;
			}
			method_81(2.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	public bool method_33(int int_4, ref string string_11, string string_12)
	{
		return method_38(int_4, ref string_11, string_12).Count > 0;
	}

	public List<string> method_34(string string_11, string string_12, string string_13 = "bounds")
	{
		List<string> list = new List<string>();
		try
		{
			if (string_11 == "")
			{
				string_11 = method_53();
			}
			string_11 = string_11.ToLower();
			string_12 = string_12.ToLower();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(string_11);
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes(string_12);
			for (int i = 0; i < xmlNodeList.Count; i++)
			{
				try
				{
					list.Add(xmlNodeList[i].Attributes[string_13].Value);
				}
				catch
				{
				}
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return list;
	}

	public List<string> method_35(int int_4, string string_11)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (string_11 == "")
				{
					string_11 = method_53();
				}
				string_11 = string_11.ToLower();
				MatchCollection matchCollection = Regex.Matches(string_11, "bounds=\"(.*?)\"");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					list.Add(matchCollection[i].Groups[1].Value);
				}
				if (list.Count <= 0 && int_4 != 0)
				{
					method_81(1.0);
					string_11 = "";
					if (Environment.TickCount - tickCount >= int_4 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return list.Distinct().ToList();
	}

	public List<string> method_36(int int_4, string string_11, string string_12)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (string_11 == "")
				{
					string_11 = method_53();
				}
				string_11 = string_11.ToLower();
				MatchCollection matchCollection = Regex.Matches(string_11, Regex.Replace(string_12.ToLower(), "\\p{Cs}", "").Replace("(", "\\(").Replace(")", "\\)")
					.Replace("[", "\\[")
					.Replace("]", "\\]") + "(.*?)/>");
				if (matchCollection.Count == 0 && string_12.Contains("&"))
				{
					matchCollection = Regex.Matches(string_11, Regex.Replace(string_12.ToLower(), "\\p{Cs}", "").Replace("&", "&amp;").Replace("(", "\\(")
						.Replace(")", "\\)")
						.Replace("[", "\\[")
						.Replace("]", "\\]") + "(.*?)/>");
				}
				for (int i = 0; i < matchCollection.Count; i++)
				{
					list.Add(Regex.Match(matchCollection[i].Value, "bounds=\"(.*?)\"").Groups[1].Value);
				}
				if (list.Count <= 0 && int_4 != 0)
				{
					method_81(1.0);
					string_11 = "";
					if (Environment.TickCount - tickCount >= int_4 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return list.Distinct().ToList();
	}

	public List<string> method_37(int int_4, string string_11, string string_12)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (string_11 == "")
				{
					string_11 = method_53();
				}
				list = method_34(string_11, string_12);
				if (list.Count <= 0 && int_4 != 0)
				{
					method_81(1.0);
					string_11 = "";
					if (Environment.TickCount - tickCount >= int_4 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return list.Distinct().ToList();
	}

	public List<string> method_38(int int_4, ref string string_11, string string_12)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (string_11 == "")
				{
					string_11 = method_53();
				}
				list = method_34(string_11, string_12);
				if (list.Count <= 0 && int_4 != 0 && Environment.TickCount - tickCount <= int_4 * 1000)
				{
					method_81(1.0);
					string_11 = "";
					if (Environment.TickCount - tickCount >= int_4 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return list.Distinct().ToList();
	}

	internal void method_39()
	{
		method_97("shell media volume --show --stream 0 --set 1");
		method_97("shell media volume --show --stream 1 --set 0");
		method_97("shell media volume --show --stream 3 --set 0");
		method_97("shell media volume --show --stream 4 --set 1");
		method_97("shell media volume --show --stream 5 --set 0");
		method_97("shell cmd media_session volume --show --stream 0 --set 1");
		method_97("shell cmd media_session volume --show --stream 1 --set 0");
		method_97("shell cmd media_session volume --show --stream 3 --set 0");
		method_97("shell cmd media_session volume --show --stream 4 --set 1");
		method_97("shell cmd media_session volume --show --stream 5 --set 0");
	}

	public List<string> method_40(int int_4, string string_11, List<string> list_0)
	{
		return method_41(int_4, ref string_11, list_0);
	}

	public List<string> method_41(int int_4, ref string string_11, List<string> list_0)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (string_11 == "")
				{
					string_11 = method_53();
				}
				for (int i = 0; i < list_0.Count; i++)
				{
					list.AddRange(method_37(0, string_11, list_0[i]));
				}
				if (list.Count <= 0 && int_4 != 0)
				{
					method_81(1.0);
					string_11 = "";
					if (Environment.TickCount - tickCount >= int_4 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return list;
	}

	public bool method_42(int int_4)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (method_146("", "android.widget.ProgressBar", "Row showing that your post is", "Sharing", "Uploading", "Finishing up", "Updating"))
				{
					if (Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_81(2.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return false;
	}

	internal bool method_43()
	{
		string text = method_97("shell ime set com.android.adbkeyboard/.AdbIME");
		if (text == "")
		{
			method_97("shell am start -a android.settings.INPUT_METHOD_SETTINGS");
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				string text2 = method_53();
				string text3 = method_29(0, text2, new List<string> { "//*[@text='ADB Keyboard']/parent::*/parent::*/child::*/child::*[@checked='true']", "//*[@text='ADB Keyboard']", "//android.widget.Button[@text='OK']" });
				switch (text3)
				{
				case "//*[@text='ADB Keyboard']":
				case "//android.widget.Button[@text='OK']":
					method_60(text3, text2);
					break;
				case "//*[@text='ADB Keyboard']/parent::*/parent::*/child::*/child::*[@checked='true']":
					text = method_97("shell ime set com.android.adbkeyboard/.AdbIME");
					return true;
				}
				method_81(1.0);
				if (Environment.TickCount - tickCount >= 60000)
				{
					break;
				}
			}
		}
		return false;
	}

	internal void method_44()
	{
		method_97("reboot");
		method_97("wait-for-device", 120);
		while (!method_97("shell getprop sys.boot_completed").Equals("1"))
		{
			FormHelper.smethod_64(1.0);
		}
	}

	internal void method_45()
	{
		method_97("shell reboot -p");
	}

	public bool method_46(string string_11, int int_4 = 0)
	{
		string text = method_48(string_11, int_4).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return method_47(text);
		}
		return false;
	}

	private bool method_47(string string_11)
	{
		try
		{
			string string_12 = "/session/{this.sessionId}/element/" + string_11 + "/clear";
			string json = method_14(string_12, "");
			return JObject.Parse(json)["status"]!.ToString() == "0";
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public List<string> method_48(string string_11, int int_4 = 0)
	{
		List<string> list = new List<string>();
		int tickCount = Environment.TickCount;
		while (!bool_1)
		{
			try
			{
				string string_12 = "/session/{this.sessionId}/elements";
				JsonHelper gClass = new JsonHelper();
				gClass.AddValue("using", "xpath");
				gClass.AddValue("value", string_11);
				string string_13 = gClass.GetJsonString();
				string json = method_14(string_12, string_13);
				JToken jToken = JObject.Parse(json)["value"];
				foreach (JToken item in (IEnumerable<JToken>)jToken)
				{
					list.Add(item["ELEMENT"]!.ToString());
				}
				if (list.Count > 0 || int_4 == 0)
				{
					break;
				}
				method_81(1.0);
				goto IL_00df;
			}
			catch (Exception exception_)
			{
				method_82(exception_);
				goto IL_00df;
			}
			IL_00df:
			if (Environment.TickCount - tickCount >= int_4 * 1000)
			{
				break;
			}
		}
		return list;
	}

	internal void method_49(string string_11)
	{
		method_168("Uninstall app " + string_5 + "...");
		method_97("uninstall \"" + string_11 + "\"", 120);
	}

	public bool method_50(string string_11, string string_12, int int_4 = 0, bool bool_3 = false)
	{
		string_12 = FormHelper.smethod_28(string_12);
		method_168("Send key " + string_12 + "...");
		string text = method_48(string_11, int_4).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			method_47(text);
			method_57(text);
			if (FormHelper.smethod_111(string_12))
			{
				if (bool_3)
				{
					string text2 = string_12;
					foreach (char c in text2)
					{
						method_97("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(c.ToString())) + "'");
					}
				}
				else
				{
					method_97("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_12)) + "'");
				}
				return true;
			}
			try
			{
				string string_13 = "/session/{this.sessionId}/element/" + text + "/value";
				JsonHelper gClass = new JsonHelper();
				gClass.AddValue("text", string_12);
				string string_14 = gClass.GetJsonString();
				string json = method_14(string_13, string_14);
				return JObject.Parse(json)["status"]!.ToString() == "0";
			}
			catch (Exception exception_)
			{
				method_82(exception_);
			}
		}
		return false;
	}

	public bool method_51(string string_11, string string_12, int int_4 = 0)
	{
		method_168("Send key " + string_12 + "...");
		string text = method_48(string_11, int_4).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			method_47(text);
			method_57(text);
			string_12 = string_12.Replace(" ", "%s").Replace("&", "\\&").Replace("<", "\\<")
				.Replace(">", "\\>")
				.Replace("?", "\\?")
				.Replace(":", "\\:")
				.Replace("{", "\\{")
				.Replace("}", "\\}")
				.Replace("[", "\\[")
				.Replace("]", "\\]")
				.Replace("|", "\\|")
				.Replace("'", "\\'");
			method_97("shell input text \"" + string_12 + "\"");
			return true;
		}
		return false;
	}

	internal void method_52()
	{
		method_97("shell input keyevent 3");
		method_97("shell input keyevent 187");
		for (int i = 0; i < 10; i++)
		{
			method_97("shell input touchscreen swipe 700 1550 700 50");
		}
		method_97("shell input keyevent 3");
	}

	public string method_53()
	{
		string result = "";
		try
		{
			string string_ = "/session/{this.sessionId}/source";
			string json = method_13(string_);
			result = JObject.Parse(json)["value"]!.ToString();
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return result;
	}

	public bool method_54(System.Drawing.Point point_0, int int_4 = 1, int int_5 = 100)
	{
		return method_55(point_0.X, point_0.Y, int_4, int_5);
	}

	public bool method_55(int int_4, int int_5, int int_6 = 1, int int_7 = 100)
	{
		try
		{
			string string_ = "/session/{this.sessionId}/touch/perform";
			string text = "{ \"actions\": [ { \"action\": \"tap\", \"options\": { \"x\": " + int_4 + ", \"y\": " + int_5 + " } },";
			for (int i = 1; i < int_6; i++)
			{
				text = text + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_7 + " } }, { \"action\": \"tap\", \"options\": { \"x\": " + int_4 + ", \"y\": " + int_5 + " } },";
			}
			text += "{ \"action\": \"release\", \"options\": {} } ] }";
			method_14(string_, text);
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public bool method_56(int int_4, int int_5, int int_6 = 1, int int_7 = 100)
	{
		try
		{
			string text = $"shell \"input tap {int_4} {int_5}";
			for (int i = 1; i < int_6; i++)
			{
				text += $" && sleep {(double)int_7 * 1.0 / 1000.0} && ";
				text += $"input tap {int_4} {int_5}";
			}
			text += "\"";
			method_97(text);
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	private bool method_57(string string_11, int int_4 = 1, int int_5 = 100)
	{
		string string_12 = "/session/{this.sessionId}/touch/perform";
		string text = "{ \"actions\": [ { \"action\": \"tap\", \"options\": { \"element\": \"" + string_11 + "\"} },";
		for (int i = 1; i < int_4; i++)
		{
			text = text + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_5 + " } }, { \"action\": \"tap\", \"options\": { \"element\": \"" + string_11 + "\"} },";
		}
		text += "{ \"action\": \"release\", \"options\": {} } ] }";
		method_14(string_12, text);
		return true;
	}

	public bool method_58(string string_11, int int_4 = 0, int int_5 = 1, int int_6 = 100)
	{
		method_168("Tap " + string_11 + "...");
		string text = method_48(string_11, int_4).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return method_57(text, int_5, int_6);
		}
		return false;
	}

	internal void method_59()
	{
		if (!method_161())
		{
			method_97("shell input keyevent 26");
		}
	}

	public bool method_60(string string_11, string string_12 = "", int int_4 = 1, int int_5 = 100)
	{
		method_168("Tap " + string_11 + "...");
		return method_61(0, string_11, string_12, int_4, int_5);
	}

	public bool method_61(int int_4, string string_11, string string_12, int int_5 = 1, int int_6 = 100)
	{
		method_168("Tap " + string_11 + "...");
		string text = method_37(int_4, string_12, string_11).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return method_54(new Class77(text).method_1());
		}
		return false;
	}

	public bool method_62(string string_11, string string_12 = "", int int_4 = 1, int int_5 = 100)
	{
		method_168("Tap " + string_11 + "...");
		return method_63(0, string_11, string_12, int_4, int_5);
	}

	public bool method_63(int int_4, string string_11, string string_12, int int_5 = 1, int int_6 = 100)
	{
		method_168("Tap " + string_11 + "...");
		string value = method_37(int_4, string_12, string_11).FirstOrDefault();
		if (!string.IsNullOrEmpty(value))
		{
			return method_54(new Class77(value).method_1());
		}
		return false;
	}

	public bool method_64(string string_11, int int_4, params string[] string_12)
	{
		string string_13 = method_30(int_4, ref string_11, string_12.ToList());
		return method_60(string_13, string_11);
	}

	public bool method_65(int int_4, string string_11, string string_12, int int_5 = 1, int int_6 = 100)
	{
		method_168("Tap " + string_11 + "...");
		string text = method_36(int_4, string_12, string_11).LastOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return method_66(text, int_5, int_6);
		}
		return false;
	}

	public bool method_66(string string_11, int int_4 = 1, int int_5 = 100)
	{
		try
		{
			System.Drawing.Point point = method_74(string_11);
			int x = point.X;
			int y = point.Y;
			return method_55(x, y, int_4, int_5);
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public bool method_67(string string_11, string string_12, int int_4 = 1, int int_5 = 100)
	{
		try
		{
			string text = method_37(0, string_12, string_11).FirstOrDefault();
			if (!string.IsNullOrEmpty(text))
			{
				return method_68(text, int_4, int_5);
			}
			return false;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public bool method_68(string string_11, int int_4 = 1, int int_5 = 100)
	{
		try
		{
			System.Drawing.Point point = method_74(string_11);
			int x = point.X;
			int y = point.Y;
			return method_56(x, y, int_4, int_5);
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	internal void method_69()
	{
		if (method_161())
		{
			method_97("shell input keyevent 26");
			method_81(1.0);
		}
		method_97("shell input keyevent 82");
	}

	internal bool method_70(string string_11)
	{
		method_142(new List<string> { string_11 });
		method_97("shell am start -a android.settings.DISPLAY_SETTINGS");
		method_81(2.0);
		int tickCount = Environment.TickCount;
		while (!bool_1)
		{
			string text = method_53();
			string text2 = method_29(0, text, new List<string> { "//*[contains(@text,'Styles & wallpapers')]", "//*[@text='Wallpaper']", "//*[@text='set wallpaper']", "//*[@text='Gallery']" });
			switch (text2)
			{
			case "//*[@text='Wallpaper']":
				if (method_31(0, text, "//*[@text='Wallpaper categories']/following-sibling::*"))
				{
					method_60("//*[@text='Wallpaper categories']/following-sibling::*", text);
				}
				else
				{
					method_66(method_37(0, text, text2).LastOrDefault());
				}
				break;
			case "//*[contains(@text,'Styles & wallpapers')]":
				if (method_31(0, text, "//*[@text='Allow']"))
				{
					method_60("//*[@text='Allow']", text);
				}
				else if (method_31(0, text, "//*[@text='Allow access']"))
				{
					method_62("//*[@text='Allow access']", text);
				}
				else
				{
					method_66(method_37(0, text, text2).LastOrDefault());
				}
				break;
			case "//*[@text='Gallery']":
				method_60("//android.widget.LinearLayout/android.widget.RelativeLayout", text);
				break;
			case "//*[@text='set wallpaper']":
				if (!method_31(0, text, "//*[@text='Home screen and lock screen']"))
				{
					method_62(text2, text);
					break;
				}
				method_60("//*[@text='Home screen and lock screen']", text);
				method_81(2.0);
				method_79(GEnum10.const_3);
				return true;
			}
			method_81(1.0);
			if (Environment.TickCount - tickCount >= 60000)
			{
				break;
			}
		}
		return false;
	}

	internal void method_71()
	{
		bool flag = method_161();
		method_97("shell \"input keyevent 26\"");
		if (!flag)
		{
			method_81(1.0);
			method_97("shell \"input keyevent 26\"");
		}
	}

	public bool method_72(int int_4, int int_5, int int_6 = 500)
	{
		try
		{
			string string_ = "/session/{this.sessionId}/touch/perform";
			string string_2 = "{ \"actions\": [ { \"action\": \"press\", \"options\": { \"x\": " + int_4 + ", \"y\": " + int_5 + " } }, { \"action\": \"wait\", \"options\": { \"ms\": " + int_6 + " } }, { \"action\": \"release\", \"options\": {} } ] }";
			method_14(string_, string_2);
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public bool method_73(int int_4, int int_5, int int_6, int int_7, int int_8 = 500)
	{
		try
		{
			string string_ = "/session/{this.sessionId}/touch/perform";
			string text = "{ \"actions\": [ ";
			text = text + "{ \"action\": \"press\", \"options\": { \"x\": " + int_4 + ", \"y\": " + int_5 + " } },";
			text = text + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_8 + " } },";
			text = text + "{ \"action\": \"moveTo\", \"options\": { \"x\": " + int_6 + ", \"y\": " + int_7 + " } },";
			text += "{ \"action\": \"release\", \"options\": {} } ] }";
			method_14(string_, text);
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public System.Drawing.Point method_74(string string_11)
	{
		try
		{
			string[] array = string_11.Split('[', ',', ']');
			int x = random_0.Next(Convert.ToInt32(array[1]), Convert.ToInt32(array[4]));
			int y = random_0.Next(Convert.ToInt32(array[2]), Convert.ToInt32(array[5]));
			return new System.Drawing.Point(x, y);
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return default(System.Drawing.Point);
	}

	public bool method_75(string string_11, string string_12, int int_4 = 500)
	{
		System.Drawing.Point point = method_74(string_11);
		int x = point.X;
		int y = point.Y;
		System.Drawing.Point point2 = method_74(string_12);
		int x2 = point2.X;
		int y2 = point2.Y;
		return method_73(x, y, x2, y2, int_4);
	}

	public bool method_76(int int_4 = 1, int int_5 = 1, int int_6 = 0)
	{
		int num = method_20();
		int num2 = method_21();
		string text = $"[{num2 / 4},{num / 4}][{num2 / 4 * 3},{num / 4 + 50}]";
		string text2 = $"[{num2 / 4},{num / 4 * 3}][{num2 / 4 * 3},{num / 4 * 3 + 50}]";
		if (int_6 == 0)
		{
			int_6 = random_0.Next(2000000, 2560000) / num;
		}
		for (int i = 0; i < int_5; i++)
		{
			if (int_4 == 1)
			{
				method_75(text2, text, int_6);
			}
			else
			{
				method_75(text, text2, int_6);
			}
		}
		return true;
	}

	public bool method_77(string string_11, string string_12, int int_4 = 500, int int_5 = 1, int int_6 = 1)
	{
		string text = method_53();
		for (int i = 0; i < int_6; i++)
		{
			if (int_5 == 1)
			{
				method_75(string_11, string_12, int_4);
			}
			else
			{
				method_75(string_12, string_11, int_4);
			}
		}
		method_81(1.0);
		return method_53() == text;
	}

	public bool method_78(int int_4 = 1, int int_5 = 1, int int_6 = 0)
	{
		method_168("Scroll...");
		int num = method_20();
		int num2 = method_21();
		string string_ = $"[{num2 / 4},{num / 4}][{num2 / 4 * 3},{num / 4 + 50}]";
		string string_2 = $"[{num2 / 4},{num / 4 * 3}][{num2 / 4 * 3},{num / 4 * 3 + 50}]";
		if (int_4 == 2)
		{
			string_2 = $"[{num2 / 4},{num / 4 * 2}][{num2 / 4 * 2},{num / 4 * 2 + 50}]";
			int_4 = 1;
		}
		if (int_6 == 0)
		{
			int_6 = random_0.Next(2000000, 2560000) / num;
		}
		return method_77(string_2, string_, int_6, int_4, int_5);
	}

	public bool method_79(GEnum10 genum10_0)
	{
		try
		{
			string string_ = "/session/{this.sessionId}/appium/device/press_keycode";
			JsonHelper gClass = new JsonHelper();
			gClass.AddValue("keycode", (int)genum10_0);
			string string_2 = gClass.GetJsonString();
			method_14(string_, string_2);
			return true;
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
	}

	public void method_80(double double_0, double double_1)
	{
		method_168("Delay...");
		Thread.Sleep(random_0.Next(Convert.ToInt32(double_0 * 1000.0), Convert.ToInt32(double_1 * 1000.0 + 1.0)));
		Application.DoEvents();
	}

	public void method_81(double double_0)
	{
		Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
		Application.DoEvents();
	}

	private bool method_82(Exception exception_0)
	{
		return false;
	}

	internal bool method_83()
	{
		method_97("shell am force-stop ru.andr7e.deviceinfohw");
		if (method_91(bool_3: true))
		{
			method_97("shell monkey -p ru.andr7e.deviceinfohw -c android.intent.category.LAUNCHER 1");
			return true;
		}
		return false;
	}

	public void method_84()
	{
		method_97("shell pm grant " + string_5 + " android.permission.READ_CONTACTS");
		method_97("shell pm grant " + string_5 + " android.permission.READ_EXTERNAL_STORAGE");
		method_97("shell pm grant " + string_5 + " android.permission.WRITE_EXTERNAL_STORAGE");
	}

	public int method_85(string string_11, int int_4 = 10)
	{
		method_168("Open app " + string_5 + "...");
		int num = 0;
		int tickCount = Environment.TickCount;
		while (!bool_1)
		{
			num++;
			switch (method_26(string_11))
			{
			case 4:
				if (num == 1)
				{
					return 2;
				}
				return 1;
			case 0:
				return 0;
			}
			method_84();
			method_23(string_11);
			method_97("shell content insert --uri content://settings/system --bind name:s:accelerometer_rotation --bind value:i:0");
			method_81(1.0);
			if (Environment.TickCount - tickCount >= int_4 * 1000)
			{
				break;
			}
		}
		return 0;
	}

	public bool method_86(string string_11, double double_0 = 10.0)
	{
		try
		{
			method_168("Close app " + string_5 + "...");
			method_97("shell am force-stop " + string_11);
		}
		catch (Exception exception_)
		{
			return method_82(exception_);
		}
		return false;
	}

	public int method_87(int int_4, int int_5)
	{
		return random_0.Next(int_4, int_5 + 1);
	}

	private string method_88(int int_4 = 0)
	{
		method_89("Get device name fake...");
		int tickCount = Environment.TickCount;
		do
		{
			string text = method_97("shell su -c \"cat /data/data/com.minsoftware.maxchanger/shared_prefs/Device.xml");
			if (text != "")
			{
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(text);
					XmlNode xmlNode = xmlDocument.SelectSingleNode("//*[@name='fingerprint']");
					XmlNode xmlNode2 = xmlDocument.SelectSingleNode("//*[@name='time_check']");
					if (xmlNode != null && xmlNode.InnerText != "" && xmlNode2 != null && xmlNode2.InnerText != "")
					{
						string_9 = xmlNode.InnerText + xmlNode2.InnerText;
						return string_9;
					}
				}
				catch (Exception)
				{
				}
			}
			if (int_4 == 0)
			{
				break;
			}
			method_81(2.0);
		}
		while (Environment.TickCount - tickCount < int_4 * 1000);
		return "";
	}

	private void method_89(string string_11)
	{
		if (!ConfigHelper.GetConfig("configDebug").GetBooleanValue("ckbChangeInfoDevice"))
		{
			return;
		}
		lock (object_1)
		{
			try
			{
				using StreamWriter streamWriter = new StreamWriter("logdevice\\" + String_2 + ".txt", append: true);
				streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ": " + string_11);
			}
			catch (Exception)
			{
			}
		}
	}

	private void method_90()
	{
		method_89("open app maxchange...");
		method_97("shell monkey -p com.minsoftware.maxchanger -c android.intent.category.LAUNCHER 1");
		method_81(3.0);
	}

	private bool method_91(bool bool_3 = false)
	{
		method_97("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
		method_97("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
		string text = method_88();
		method_89("Get device name fake old => " + text);
		int tickCount = Environment.TickCount;
		bool flag = false;
		if (bool_3)
		{
			flag = true;
			method_90();
		}
		int num = 1;
		do
		{
			if (num > 1 && !flag)
			{
				flag = true;
				method_90();
			}
			string text2 = "shell am broadcast -a com.minsoftware.maxchanger.CHANGE -n com.minsoftware.maxchanger/.AdbCaller";
			if (LicenseManager.string_7 != "Random")
			{
				string text3 = (from string_0 in LicenseManager.string_7.Split('|').ToList()
					orderby Guid.NewGuid()
					select string_0).Last();
				text2 = "shell am broadcast -a com.minsoftware.maxchanger.CHANGE --es \"brand\" \"" + text3 + "\" -n com.minsoftware.maxchanger/.AdbCaller";
			}
			method_89($"{num}. Run cmd: adb {text2}...");
			bool flag2 = method_97(text2, 120).Contains("Broadcast completed");
			method_89($"{num}. Run cmd => " + flag2);
			if (flag2)
			{
				method_81(2.0);
				string text4 = method_88(10);
				method_89($"{num}. Get device name fake new => " + text4);
				if (text4 != "" && text4 != text)
				{
					return true;
				}
			}
			num++;
		}
		while (Environment.TickCount - tickCount < 300000);
		return false;
	}

	internal bool method_92(string string_11)
	{
		method_168("Change info...");
		bool flag = false;
		if (method_93(string_11))
		{
			string text = method_88(10);
			flag = text != "";
		}
		if (!flag && (flag = method_91()))
		{
			method_94(string_11);
		}
		return flag;
	}

	internal bool method_93(string string_11)
	{
		if (string_11 != "")
		{
			method_98("com.minsoftware.maxchanger");
			method_97("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
			method_97("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
			string text = ApplicationHelper.GetApplicationDirectory() + "\\device\\" + string_11 + ".tar.gz";
			if (File.Exists(text))
			{
				bool flag = false;
				for (int i = 0; i < 10; i++)
				{
					string text2 = method_97("push \"" + text + "\" /sdcard");
					text2 = method_97("shell su -c cp /sdcard/" + string_11 + ".tar.gz /data/data/com.minsoftware.maxchanger/" + string_11 + ".tar.gz");
					text2 = method_97("shell su -c tar -xzvf /data/data/com.minsoftware.maxchanger/" + string_11 + ".tar.gz");
					text2 = method_97("shell su -c \"ls -l /data/data | grep com.minsoftware.maxchanger | awk '{print $3\\\":\\\"$4}'\"");
					flag = text2 != "";
					text2 = method_97("shell su -c chown -R " + text2 + " /data/data/com.minsoftware.maxchanger");
					if (!flag)
					{
						method_81(2.0);
						continue;
					}
					return true;
				}
			}
		}
		return false;
	}

	internal bool method_94(string string_11)
	{
		if (string_11 != "")
		{
			string text = ApplicationHelper.GetApplicationDirectory() + "\\device\\" + string_11 + ".tar.gz";
			if (File.Exists(text))
			{
				FormHelper.smethod_98(text);
			}
			method_86("com.minsoftware.maxchanger");
			for (int i = 0; i < 10; i++)
			{
				if (bool_1)
				{
					break;
				}
				method_97("shell su -c tar -czvf /data/data/com.minsoftware.maxchanger/device.tar.gz /data/data/com.minsoftware.maxchanger/shared_prefs/*");
				method_97("shell su -c cp /data/data/com.minsoftware.maxchanger/device.tar.gz /sdcard/device.tar.gz");
				method_97("pull /sdcard/device.tar.gz \"" + text + "\"");
				method_97("shell su -c rm -rf /data/data/com.minsoftware.maxchanger/*.tar.gz");
				method_97("shell su -c rm -rf /sdcard/*.tar.gz");
				if (!File.Exists(text))
				{
					method_81(3.0);
					continue;
				}
				return true;
			}
		}
		return false;
	}

	internal bool method_95(string string_11)
	{
		method_168("Restore data Fb...");
		method_98(string_5);
		if (string.IsNullOrEmpty(string_11))
		{
			return false;
		}
		string text = ApplicationHelper.GetApplicationDirectory() + "\\profile\\" + string_11 + ".tar.gz";
		if (File.Exists(text))
		{
			bool flag = false;
			for (int i = 0; i < 10; i++)
			{
				string text2 = method_97("push \"" + text + "\" /sdcard");
				text2 = method_97("shell su -c cp /sdcard/" + string_11 + ".tar.gz /data/data/" + string_5 + "/" + string_11 + ".tar.gz");
				text2 = method_97("shell su -c tar -xpf /data/data/" + string_5 + "/" + string_11 + ".tar.gz");
				text2 = method_97("shell su -c \"ls -l /data/data | grep " + string_5 + " | awk '{print $3\\\":\\\"$4}'\"");
				flag = text2 != "";
				text2 = method_97("shell su -c chown -R " + text2 + " /data/data/" + string_5);
				if (!flag)
				{
					method_81(2.0);
					continue;
				}
				return true;
			}
		}
		return false;
	}

	internal bool method_96(string string_11)
	{
		if (string_11 != "")
		{
			method_168("Backup data Fb...");
			string text = ApplicationHelper.GetApplicationDirectory() + "\\profile\\" + string_11 + ".tar.gz";
			if (File.Exists(text))
			{
				FormHelper.smethod_98(text);
			}
			for (int i = 0; i < 10; i++)
			{
				if (bool_1)
				{
					break;
				}
				method_97("shell su -c tar -czvpf /data/data/" + string_5 + "/backup.tar.gz /data/data/" + string_5 + "/databases /data/data/" + string_5 + "/app_light_prefs /data/data/" + string_5 + "/shared_prefs /data/data/" + string_5 + "/files/mobileconfig");
				method_97("shell su -c cp /data/data/" + string_5 + "/backup.tar.gz /sdcard/backup.tar.gz");
				method_97("pull /sdcard/backup.tar.gz \"" + text + "\"");
				method_97("shell su -c rm -rf /data/data/" + string_5 + "/*.tar.gz");
				method_97("shell su -c rm -rf /sdcard/*.tar.gz");
				if (!File.Exists(text))
				{
					method_81(3.0);
					continue;
				}
				return true;
			}
		}
		return false;
	}

	public string method_97(string string_11, int int_4 = 10)
	{
		string result;
		string string_12;
		string string_13;
		while (true)
		{
			if (!bool_1)
			{
				int num = 0;
				int num2 = 3;
				result = "";
				try
				{
					string text = "adb -s " + String_2 + " " + string_11;
					Process process = new Process();
					process.StartInfo.FileName = "cmd.exe";
					process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + text;
					process.StartInfo.Verb = "runas";
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.RedirectStandardError = true;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
					process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
					string_12 = "";
					process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
					{
						if (!string.IsNullOrEmpty(e.Data))
						{
							string_12 = string_12 + e.Data + "\n";
						}
					};
					string_13 = "";
					process.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs e)
					{
						if (!string.IsNullOrEmpty(e.Data))
						{
							string_13 = string_13 + e.Data + "\n";
						}
					};
					process.Start();
					process.BeginOutputReadLine();
					process.BeginErrorReadLine();
					bool flag = !process.WaitForExit((int_4 < 0) ? (-1) : (int_4 * 1000));
					process.Close();
					if (flag)
					{
						if (num > 0 && num % num2 == 0)
						{
							GClass7.smethod_3();
						}
						num++;
						continue;
					}
					if (!(string_13 != ""))
					{
						goto IL_0281;
					}
					if (string_13.Contains("daemon not running") && !string_13.Contains("daemon started successfully"))
					{
						continue;
					}
					if (Regex.Match(string_13, "device (.*?) not found").Groups[1].Value != "" || string_13.Contains("device offline"))
					{
						if (method_12())
						{
							continue;
						}
						return "disconnect";
					}
					lock (Class76.object_1)
					{
						File.AppendAllText("device.txt", "Run ADB error:" + Environment.NewLine);
						File.AppendAllText("device.txt", string_13 + Environment.NewLine);
						File.AppendAllText("device.txt", "-----------------------------" + Environment.NewLine);
					}
					goto IL_0281;
					IL_0281:
					result = string_12.Trim();
					break;
				}
				catch
				{
					break;
				}
			}
			return "disconnect";
		}
		return result;
	}

	internal void method_98(string string_11)
	{
		method_168("Clear data " + string_11 + "...");
		method_97("shell pm clear " + string_11);
	}

	internal int method_99(string string_11, string string_12, string string_13, string string_14, int int_4 = 0, int int_5 = 0, int int_6 = 300)
	{
		int tickCount = Environment.TickCount;
		if (int_5 != 2)
		{
			method_95(string_11);
		}
		method_85(string_5);
		string text = "";
		int num = 0;
		int num2 = 2;
		int num3 = 0;
		int num4 = 1;
		int num5 = 0;
		int num6 = 1;
		int num7 = 0;
		int num8 = 1;
		int num9 = 0;
		int num10 = ((int_4 != 15) ? (-1) : 0);
		int num11 = 0;
		int num12 = 3;
		int num13 = 0;
		int num14 = 1;
		method_168("Login Fb " + string_11 + "...");
		do
		{
			string text2;
			if (!bool_1)
			{
				text2 = method_53();
				text = method_29(0, text2, new List<string>
				{
					"//android.widget.ProgressBar", "//*[@text='NONE OF THE ABOVE']", "//*[@text='Session Expired']", "//android.widget.Button[@content-desc='Menu']", "//android.widget.EditText[@content-desc='Username']", "//android.widget.EditText[@text='Password']", "//android.widget.TextView[@text=\"Can't Find Account\"]", "//android.widget.TextView[@text='Incorrect Password']", "//android.widget.TextView[@text='Invalid username or password']", "//android.widget.TextView[@text='You Entered an Older Password']",
					"//android.widget.TextView[@text='Login Code Required']", "//android.widget.EditText[@text='login code']", "//android.widget.TextView[@text='Authentication Error']", "//*[@text='save your login info']", "//*[@content-desc='skip' or @text='skip']", "//*[@content-desc='deny' or @text='deny']", "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]", "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]", "//android.view.ViewGroup[@content-desc=\"Allow\"]", "//com.android.packageinstaller:id/do_not_ask_checkbox",
					"//android.widget.Button[@text=\"NEVER\"]", "//android.widget.TextView[@text=\"Find your account\"]", "//android.widget.Button[@text='FIND ACCOUNT']", "//*[@text ='LOG IN' or @content-desc='Log In']", "//android.widget.TextView[@text='Find Friends']", "//*[@text='Enter the code from your email']", "//*[@text='Enter the code from your SMS']", "//*[@text='Confirm by phone number']", "//android.widget.Button[@text='Confirm']", "//*[@content-desc='Send login code']",
					"//android.widget.Button[@text='TRY AGAIN']", "//android.widget.EditText[@text='Enter code']", "//*[@text='No thanks']", "//android.view.ViewGroup[@content-desc='Use login code instead']", "//*[@content-desc='I ACCEPT']", "//*[@content-desc='Allow all cookies']", "//*[@text=\"You can't log in right now\"]", "//*[@text=\"You Can't Use This Feature Right Now\"]", "//*[@text='An unexpected error occurred. Please try logging in again.']", "//*[@text='Facebook will be back soon']",
					"//*[@text='Login Failed']", "(//android.widget.EditText)[7]", "//*[@text='Connection lost']", "//*[@text='Trouble Loading']", "//*[@content-desc='Yes, continue']", "//*[@text='Enter password to log in']", "//android.view.ViewGroup[@content-desc='•']", "//*[@text='Take photo']", "//*[@text='Not now' or @content-desc='Not now']", "//android.widget.Button[@text='GET STARTED']",
					"//android.widget.Button[@content-desc='Log into another account']", "//*[@content-desc='Next']"
				});
				string text3 = text;
				string text4 = text3;
				uint num15 = Class206.smethod_0(text4);
				if (num15 <= 1514243556)
				{
					if (num15 <= 498126038)
					{
						if (num15 <= 199939915)
						{
							if (num15 <= 51955880)
							{
								if (num15 != 14426572)
								{
									if (num15 != 38614762)
									{
										if (num15 != 51955880 || !(text4 == "//*[@text='Not now' or @content-desc='Not now']"))
										{
											goto IL_0d76;
										}
									}
									else if (!(text4 == "//android.view.ViewGroup[@content-desc=\"Allow\"]"))
									{
										goto IL_0d76;
									}
									goto IL_0fa6;
								}
								if (text4 == "//*[@content-desc='deny' or @text='deny']")
								{
									method_60(text, text2);
									goto IL_0fb3;
								}
							}
							else if (num15 != 62961010)
							{
								if (num15 != 181913694)
								{
									if (num15 == 199939915 && text4 == "//android.widget.EditText[@text='login code']")
									{
										if (!(string_14.Trim() == ""))
										{
											string string_15 = FormHelper.smethod_85(string_14);
											method_50("//android.widget.EditText", string_15);
											method_81(1.0);
											method_79(GEnum10.const_66);
											goto IL_0fb3;
										}
										return 3;
									}
								}
								else if (text4 == "//*[@text='Enter the code from your email']")
								{
									goto IL_1018;
								}
							}
							else if (text4 == "//android.widget.Button[@text='Confirm']")
							{
								goto IL_0fa6;
							}
						}
						else
						{
							if (num15 <= 355810260)
							{
								if (num15 != 288814156)
								{
									if (num15 != 300361078)
									{
										if (num15 != 355810260 || !(text4 == "//android.widget.Button[@content-desc='Log into another account']"))
										{
											goto IL_0d76;
										}
									}
									else if (!(text4 == "//*[@content-desc='Allow all cookies']"))
									{
										goto IL_0d76;
									}
								}
								else if (!(text4 == "//*[@text='NONE OF THE ABOVE']"))
								{
									goto IL_0d76;
								}
								goto IL_0fa6;
							}
							if (num15 <= 440181498)
							{
								if (num15 != 385932458)
								{
									if (num15 == 440181498 && text4 == "//*[@text=\"You Can't Use This Feature Right Now\"]")
									{
										goto IL_0cf2;
									}
								}
								else if (text4 == "//android.widget.EditText[@text='Enter code']")
								{
									goto IL_0ffa;
								}
							}
							else if (num15 != 454760892)
							{
								if (num15 == 498126038 && text4 == "//android.widget.TextView[@text='You Entered an Older Password']")
								{
									goto IL_1023;
								}
							}
							else if (text4 == "//android.widget.Button[@text=\"NEVER\"]")
							{
								goto IL_0fa6;
							}
						}
					}
					else if (num15 <= 1080039791)
					{
						if (num15 <= 728177876)
						{
							if (num15 != 532719482)
							{
								if (num15 != 601041107)
								{
									if (num15 == 728177876 && text4 == "//com.android.packageinstaller:id/do_not_ask_checkbox")
									{
										goto IL_0fa6;
									}
								}
								else if (text4 == "//android.widget.Button[@content-desc='Menu']")
								{
									method_60("//android.widget.TextView", text2);
									goto IL_0fb3;
								}
							}
							else if (text4 == "//android.widget.ProgressBar")
							{
								num9++;
								if (num9 % 5 == 0)
								{
									if (method_100(text2))
									{
										return 1;
									}
									method_60("//*[@content-desc='skip' or @text='skip']", text2);
								}
								goto IL_0fb3;
							}
						}
						else if (num15 != 827023039)
						{
							switch (num15)
							{
							case 1080039791u:
								if (!(text4 == "//android.widget.Button[@text='TRY AGAIN']"))
								{
									break;
								}
								if (num3 < num4)
								{
									method_60(text, text2);
									method_81(1.0);
									num3++;
									goto IL_0fb3;
								}
								return 5;
							case 1029426508u:
								if (!(text4 == "//*[@text='Session Expired']"))
								{
									break;
								}
								if (num11 >= num12)
								{
									method_98(string_5);
									method_85(string_5);
									num11 = 0;
								}
								else
								{
									num11++;
									method_60("//android.widget.Button[@text='OK']", text2);
								}
								goto IL_0fb3;
							}
						}
						else if (text4 == "//*[@text='Connection lost']")
						{
							goto IL_0b29;
						}
					}
					else if (num15 <= 1236015078)
					{
						if (num15 != 1094531760)
						{
							if (num15 != 1156007901)
							{
								if (num15 == 1236015078 && text4 == "//android.widget.TextView[@text='Authentication Error']")
								{
									num++;
									if (num < num2)
									{
										method_60("//android.widget.Button[@text ='OK']", text2);
										goto IL_0fb3;
									}
									return 6;
								}
							}
							else if (text4 == "//*[@content-desc='Yes, continue']")
							{
								goto IL_0fa6;
							}
						}
						else if (text4 == "//*[@text='save your login info']")
						{
							goto IL_09f5;
						}
					}
					else
					{
						if (num15 <= 1378667548)
						{
							if (num15 != 1290144582)
							{
								if (num15 != 1378667548 || !(text4 == "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]"))
								{
									goto IL_0d76;
								}
							}
							else if (!(text4 == "//*[@text ='LOG IN' or @content-desc='Log In']"))
							{
								goto IL_0d76;
							}
							goto IL_0fa6;
						}
						if (num15 != 1451300114)
						{
							if (num15 == 1514243556 && text4 == "//*[@text=\"You can't log in right now\"]")
							{
								goto IL_0cf2;
							}
						}
						else if (text4 == "//android.widget.Button[@text='FIND ACCOUNT']")
						{
							goto IL_0c72;
						}
					}
				}
				else if (num15 <= 2526580307u)
				{
					if (num15 <= 1878701109)
					{
						if (num15 <= 1734832791)
						{
							if (num15 != 1580217180)
							{
								if (num15 != 1684149593)
								{
									if (num15 == 1734832791 && text4 == "//*[@content-desc='Send login code']")
									{
										goto IL_0ffa;
									}
								}
								else if (text4 == "//android.view.ViewGroup[@content-desc='•']")
								{
									goto IL_0bbe;
								}
							}
							else if (text4 == "//android.widget.TextView[@text='Incorrect Password']")
							{
								goto IL_1023;
							}
						}
						else if (num15 != 1761617051)
						{
							if (num15 != 1792698548)
							{
								if (num15 == 1878701109 && text4 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
								{
									goto IL_0b29;
								}
							}
							else if (text4 == "//*[@content-desc='Next']")
							{
								goto IL_0fa6;
							}
						}
						else if (text4 == "//android.widget.EditText[@content-desc='Username']")
						{
							method_50(text, string_12);
							method_81(1.0);
							method_50("//android.widget.EditText[@text='Password']", string_13);
							method_81(1.0);
							method_60("//*[@content-desc='Log In']");
							goto IL_0fb3;
						}
					}
					else if (num15 <= 2283011030u)
					{
						if (num15 != 1997336986)
						{
							if (num15 != 2146469799)
							{
								if (num15 == 2283011030u && text4 == "//*[@text='Enter password to log in']")
								{
									goto IL_0fa6;
								}
							}
							else if (text4 == "//*[@text='Enter the code from your SMS']")
							{
								goto IL_1018;
							}
						}
						else if (text4 == "//android.widget.TextView[@text='Find Friends']")
						{
							method_60("//android.widget.Button[@text='Get started']");
							goto IL_0fb3;
						}
					}
					else if (num15 <= 2492217505u)
					{
						if (num15 != 2329336095u)
						{
							if (num15 == 2492217505u && text4 == "//android.widget.TextView[@text=\"Can't Find Account\"]")
							{
								return 4;
							}
						}
						else if (text4 == "//*[@text='An unexpected error occurred. Please try logging in again.']")
						{
							goto IL_0cf2;
						}
					}
					else if (num15 != 2507397295u)
					{
						if (num15 == 2526580307u && text4 == "//android.widget.TextView[@text='Login Code Required']")
						{
							goto IL_09f5;
						}
					}
					else if (text4 == "//android.widget.Button[@text='GET STARTED']")
					{
						if (method_146(text2, "To log into your Facebook account, you need to first confirm your identity"))
						{
							method_60(text, text2);
							goto IL_0fb3;
						}
						return 2;
					}
				}
				else if (num15 <= 3496844666u)
				{
					if (num15 <= 2928020320u)
					{
						if (num15 != 2684704644u)
						{
							if (num15 != 2698810085u)
							{
								if (num15 == 2928020320u && text4 == "//android.widget.EditText[@text='Password']")
								{
									method_50("//android.widget.EditText[@text='Password']", string_13);
									method_81(1.0);
									method_60("//android.widget.Button[@text ='LOG IN']", text2);
									goto IL_0fb3;
								}
							}
							else if (text4 == "//*[@text='No thanks']")
							{
								goto IL_0fa6;
							}
						}
						else if (text4 == "//android.view.ViewGroup[@content-desc='Use login code instead']")
						{
							goto IL_0fa6;
						}
					}
					else if (num15 != 2934012532u)
					{
						if (num15 != 3186143151u)
						{
							if (num15 == 3496844666u && text4 == "//*[@text='Trouble Loading']")
							{
								goto IL_0b29;
							}
						}
						else if (text4 == "//android.widget.TextView[@text='Invalid username or password']")
						{
							goto IL_1023;
						}
					}
					else if (text4 == "//*[@text='Take photo']")
					{
						goto IL_0bbe;
					}
				}
				else if (num15 <= 3855779225u)
				{
					if (num15 != 3528901103u)
					{
						if (num15 != 3606322765u)
						{
							if (num15 == 3855779225u && text4 == "//*[@text='Login Failed']")
							{
								if (num3 < num4)
								{
									method_60("//android.widget.Button[@text='OK']", text2);
									method_81(1.0);
									num3++;
									goto IL_0fb3;
								}
								return 0;
							}
						}
						else if (text4 == "//android.widget.TextView[@text=\"Find your account\"]")
						{
							goto IL_0c72;
						}
					}
					else if (text4 == "//*[@text='Confirm by phone number']")
					{
						goto IL_1018;
					}
				}
				else if (num15 <= 3945336632u)
				{
					if (num15 != 3919975960u)
					{
						if (num15 == 3945336632u && text4 == "//*[@text='Facebook will be back soon']")
						{
							goto IL_0cf2;
						}
					}
					else if (text4 == "//*[@content-desc='I ACCEPT']")
					{
						goto IL_0fa6;
					}
				}
				else if (num15 != 4002761936u)
				{
					if (num15 == 4158470539u && text4 == "(//android.widget.EditText)[7]")
					{
						goto IL_1023;
					}
				}
				else if (text4 == "//*[@content-desc='skip' or @text='skip']")
				{
					goto IL_0fa6;
				}
				goto IL_0d76;
			}
			return -2;
			IL_0c72:
			if (num3 < num4)
			{
				method_60("//android.widget.ImageView[@content-desc=\"Back\"]", text2);
				method_81(1.0);
				num3++;
				goto IL_0fb3;
			}
			return 4;
			IL_0b29:
			if (num5 >= num6)
			{
				if (num10 != 0 || !method_160())
				{
					return 7;
				}
				num10 = 1;
				method_85(string_5);
			}
			num5++;
			if (text == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
			{
				method_60("//android.widget.Button[@text='OK']", text2);
			}
			else
			{
				method_60("//*[@text='Tap to retry']", text2);
			}
			goto IL_0fb3;
			IL_0cf2:
			if (num3 < num4)
			{
				method_60("//*[@text='OK']", text2);
				method_81(1.0);
				num3++;
				goto IL_0fb3;
			}
			return 12;
			IL_0d76:
			if (!method_22().Contains("FacebookSplashScreenActivity"))
			{
				if (method_146(text2, "Create new account"))
				{
					if (method_78())
					{
						return 0;
					}
				}
				else if (method_146(text2, "You have attempted to share a private intimate image"))
				{
					method_60("//android.widget.Button[@resource-id='checkpointSubmitButton-actual-button']", text2);
				}
				else if (method_31(0, text2, "//android.widget.ImageView[@content-desc='Unlock']"))
				{
					method_69();
					method_85(string_5);
				}
				else if (text2.Contains("com.android.systemui"))
				{
					method_28();
					method_85(string_5);
				}
				else if (method_85(string_5) != 1)
				{
					if (method_146(text2, "Something went wrong.Please try again"))
					{
						return 0;
					}
					if (method_146(text2, "You’re Temporarily Blocked", "It looks like you were misusing this feature by going too fast"))
					{
						return 11;
					}
					if (method_146(text2, "Facebook isn't responding", "Facebook keeps stopping"))
					{
						if (num7 < num8)
						{
							if (!method_95(string_11))
							{
								num7 = num8 - 1;
							}
						}
						else if (num7 < num8 + 1)
						{
							method_98(string_5);
						}
						else
						{
							method_49(string_5);
							method_177(ApplicationHelper.GetApplicationDirectory() + "\\app\\facebook.apk");
							method_17();
							method_44();
							method_69();
							method_95(string_11);
						}
						num7++;
						method_85(string_5);
						method_81(2.0);
					}
					else if (method_101(text2))
					{
						if (num13 >= num14)
						{
							return 13;
						}
						num13++;
						method_60("//*[@text='Close']", text2);
					}
					else
					{
						if (method_103(text2))
						{
							return 2;
						}
						if (!method_104(text2) && method_100(text2))
						{
							return 1;
						}
					}
				}
			}
			goto IL_0fb3;
			IL_1018:
			return 8;
			IL_0fb3:
			method_81(2.0);
			continue;
			IL_0fa6:
			method_60(text, text2);
			goto IL_0fb3;
			IL_1023:
			return 5;
			IL_0bbe:
			method_86(string_5);
			method_85(string_5);
			goto IL_0fb3;
			IL_09f5:
			method_60("//*[@text='OK']", text2);
			goto IL_0fb3;
			IL_0ffa:
			return 2;
		}
		while (Environment.TickCount - tickCount < int_6 * 1000);
		return 0;
	}

	public bool method_100(string string_11 = "")
	{
		if (string_11 == "")
		{
			string_11 = method_53();
		}
		return method_146(string_11, "News Feed, Tab", "Notifications, Tab", "Menu, Tab", "Make a post on Facebook", "\"Notifications");
	}

	public bool method_101(string string_11 = "")
	{
		if (string_11 == "")
		{
			string_11 = method_53();
		}
		return method_146(string_11, "of your comments go against our standards on spam", "This comment goes against our Community Standards on spam", "Standards on spam");
	}

	public bool method_102(string string_11 = "")
	{
		if (string_11 == "")
		{
			string_11 = method_53();
		}
		return method_146(string_11, "Turn on data or check your Wi-Fi settings", "Please check your internet connection", "Connection lost", "Trouble Loading");
	}

	public bool method_103(string string_11 = "")
	{
		if (string_11 == "")
		{
			string_11 = method_53();
		}
		if (method_150(string_11).Count == 0 && method_31(0, string_11, "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup[3]"))
		{
			method_60("//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup[1]", string_11);
			method_81(2.0);
			method_42(30);
			if (method_146("", "my account been locked"))
			{
				return true;
			}
			if (method_127("dataimage\\956"))
			{
				return true;
			}
			if (method_127("dataimage\\282"))
			{
				return true;
			}
			method_28();
		}
		if (method_127("dataimage\\956"))
		{
			return true;
		}
		if (method_127("dataimage\\282"))
		{
			return true;
		}
		if (method_150(string_11).Count == 1 && method_146(string_11, "\"Get started", "\"Learn more\""))
		{
			return true;
		}
		if (method_146(string_11, "Confirm Your Identity") && !method_146(string_11, "Contact info"))
		{
			return true;
		}
		return method_146(string_11, "Record a video of yourself", "To make sure you're a real person, we need you to record a video selfie. We'll ask you to move your head during the recording to help us capture your face at different angles.", "We use this video to help us check that this account belongs to you. We'll delete the video once we've done this, and it will never appear on your profile.", "Request a review", "Download your information", "Your account has been disabled", "Go to Community Standards", "We need more information", "Disagree with decision", "\"Record video", "Type the text", "a few steps to confirm your account on Facebook", "Help us confirm it's you", "checkpointSubmitButton-actual-button", "checkpoint_title", "Confirm your account", "Get a code by email", "Get a code on your phone", "your account has been locked", "Send login code");
	}

	public bool method_104(string string_11 = "")
	{
		method_168("Check popup...");
		int num = 0;
		int num2 = 1;
		while (true)
		{
			if (string_11 == "")
			{
				string_11 = method_53();
			}
			List<string> list = method_150(string_11.ToLower());
			if (list.Count == 2 && list.Contains("profile picture") && list.Contains("photo"))
			{
				method_76(-1);
				method_81(1.0);
				string_11 = method_53();
			}
			if (method_31(0, string_11, "//android.widget.Button[@text='Continue']"))
			{
				Class77 @class = new Class77(method_37(0, string_11, "//android.widget.Button[@text='Continue']/parent::*[1]").First());
				if (@class.int_2 - @class.int_0 > 800)
				{
					method_76(-1);
					method_81(1.0);
					string_11 = method_53();
				}
			}
			string value = method_37(0, string_11, "//*[@content-desc='Close']").FirstOrDefault();
			if (string.IsNullOrEmpty(value) || new Class77(value).int_1 <= 2300)
			{
				string text = method_29(0, string_11, new List<string> { "//*[@text='Tap to view story']", "//*[@content-desc='Close' or @text='CLOSE']", "//*[@content-desc='Dismiss' or @text='Dismiss']", "//*[@text='New! Post in this group without sharing your name.']", "//*[@content-desc='deny' or @text='deny']", "//*[@text='No thanks']", "//*[@content-desc='I ACCEPT']", "//*[@content-desc='Allow all cookies']", "//*[@text='Try again']", "//*[@content-desc='Unplug charger' or @text='Unplug charger']" });
				if (text != "")
				{
					if (!(text == "//*[@content-desc='Close' or @text='CLOSE']") || !method_31(0, string_11, "//android.widget.ScrollView"))
					{
						switch (text)
						{
						case "//*[@text='Try again']":
							if (num < num2)
							{
								num++;
								method_60(text, string_11);
								method_81(2.0);
								continue;
							}
							method_28();
							break;
						case "//*[@content-desc='Unplug charger' or @text='Unplug charger']":
							method_60("//*[@content-desc='OK' or @text='OK']", string_11);
							break;
						case "//*[@text='Tap to view story']":
							return false;
						default:
							method_60(text, string_11);
							break;
						}
					}
					else
					{
						Class77 class2 = new Class77(method_37(0, string_11, "//android.widget.ScrollView").First());
						if (class2.int_0 != 0)
						{
							method_73((class2.int_0 + class2.int_2) / 2, class2.int_1, (class2.int_0 + class2.int_2) / 2, (class2.int_3 < method_19().Value.Y) ? class2.int_3 : (class2.int_3 - 10));
						}
						else
						{
							class2 = new Class77(method_37(0, string_11, text).First());
							if (class2.int_0 == 0)
							{
								method_28();
							}
							else
							{
								method_60(text, string_11);
							}
						}
					}
					method_80(2.0, 3.0);
					return true;
				}
				if (method_146(string_11, "Review Your Data Settings"))
				{
					method_60("//*[@content-desc='Get Started']", string_11);
					string_11 = "";
				}
				else if (method_31(0, string_11, "//*[@content-desc='Accept and Continue']"))
				{
					method_60("//*[@content-desc='Accept and Continue']", string_11);
					string_11 = "";
				}
				if (string_11 == "")
				{
					continue;
				}
				switch (method_150(string_11).Distinct().Count())
				{
				case 1:
					if (!method_78(-1))
					{
						string_11 = method_53();
						continue;
					}
					break;
				case 0:
					if (string_11 != "" && !method_22().Contains("pagerecommendations"))
					{
						method_28();
						return true;
					}
					break;
				}
				break;
			}
			return false;
		}
		return false;
	}

	public string method_105(string string_11, int int_4 = 10)
	{
		return method_97("shell am start -n " + string_5 + "/.IntentUriHandler \"" + string_11 + "\"", int_4);
	}

	public int method_106(string string_11, int int_4 = 10)
	{
		method_168("Open gr " + string_11 + "...");
		method_105("fb://group/" + string_11);
		method_81(2.0);
		int_4 -= 2;
		string text = method_29(int_4, "", new List<string> { "//android.view.ViewGroup[starts-with(@content-desc,\"Cover photo of group\")]", "//android.widget.Button[@content-desc=\"Member Tools\"]", "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]" });
		return (!(text == "")) ? 1 : 0;
	}

	public void method_107()
	{
		method_168("Open Timeline...");
		method_105("fb://dbl_login_activity", 3);
		string text = "";
		for (int i = 0; i < 5; i++)
		{
			if (bool_1)
			{
				break;
			}
			text = "";
			string text2 = method_30(3, ref text, new List<string> { "//android.view.ViewGroup[@content-desc='Add more to your post']", "//android.widget.TextView[@text='Create post']", "//android.widget.Button[@content-desc='Discard post']" });
			if (!(text2 == ""))
			{
				if (text2 == "//android.view.ViewGroup[@content-desc='Add more to your post']" || text2 == "//android.widget.TextView[@text='Create post']")
				{
					method_60("//android.widget.ImageView[@content-desc='Back']", text);
				}
				else
				{
					method_60(text2, text);
				}
				continue;
			}
			break;
		}
	}

	public bool method_108(string string_11 = "", string string_12 = "people")
	{
		method_107();
		bool flag;
		if (!(flag = method_61(5, "//android.widget.Button[contains(@content-desc, \"Search\")]", "")))
		{
			method_105("fb://search");
			flag = true;
		}
		if (flag && string_11 != "" && method_50("//android.widget.EditText", string_11, 5))
		{
			method_80(1.0, 1.5);
			method_79(GEnum10.const_66);
			method_80(1.5, 2.5);
			method_61(10, "//android.view.ViewGroup[@content-desc=\"" + string_12 + " search results\"]", "");
		}
		return flag;
	}

	public bool method_109()
	{
		if (!method_31(0, "", "//*[starts-with(@content-desc,'Friends, tab')]"))
		{
			method_107();
		}
		if (method_61(5, "//*[starts-with(@content-desc,'Friends, tab')]", ""))
		{
			string string_ = "";
			switch (method_30(5, ref string_, new List<string> { "//*[@content-desc='Suggestions']", "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]", "//*[@content-desc='Requests']" }))
			{
			case "//*[@content-desc='Suggestions']":
				return method_61(0, "//*[@content-desc='Suggestions']", string_);
			case "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]":
				return true;
			case "//*[@content-desc='Requests']":
				if (method_61(0, "//*[@content-desc='Requests']", string_))
				{
					return method_61(5, "//*[@content-desc='See friend suggestions']", "");
				}
				break;
			}
		}
		return false;
	}

	public bool method_110()
	{
		if (!method_31(0, "", "//*[starts-with(@content-desc,'Friends, tab')]"))
		{
			method_107();
		}
		if (method_61(5, "//*[starts-with(@content-desc,'Friends, tab')]", ""))
		{
			return method_64("", 10, "//*[@content-desc='Your Friends']", "//*[@content-desc='All friends']");
		}
		return false;
	}

	public bool method_111()
	{
		method_168("Open Notify...");
		int tickCount = Environment.TickCount;
		while (true)
		{
			if (Environment.TickCount - tickCount < 30000 && !bool_1)
			{
				string text = method_53();
				if (method_29(0, text, new List<string> { "//android.widget.TextView[@text=\"No notifications\"]", "//*[@text='Notifications']" }) != "")
				{
					break;
				}
				string text2 = method_29(0, text, new List<string> { "//android.view.View[contains(@content-desc,'Notifications, tab')]" });
				if (text2 == "")
				{
					method_107();
				}
				else
				{
					method_60(text2, text);
				}
				method_81(2.0);
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_112()
	{
		method_168("Open Page...");
		method_107();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			text = method_53();
			string text2 = method_29(0, text, new List<string> { "//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/child::*", "//*[starts-with(@content-desc,'Menu, tab')]", "//android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/child::*", "//android.widget.ProgressBar" });
			switch (text2)
			{
			case "//*[starts-with(@content-desc,'Menu, tab')]":
				method_60(text2, text);
				break;
			case "//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/child::*":
			{
				List<Class77> list2 = Class77.smethod_1(text, text2);
				if (list2.Count > 0)
				{
					method_66(list2.First().method_0());
					return true;
				}
				break;
			}
			case "//android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/child::*":
			{
				List<Class77> list = Class77.smethod_1(text, text2);
				if (list.Count > 0)
				{
					method_66(list.Last().method_0());
				}
				break;
			}
			}
			method_81(2.0);
		}
		while (Environment.TickCount - tickCount < 300000);
		return false;
	}

	public bool method_113(string string_11 = "1|2|4|5")
	{
		method_168("Reaction...");
		List<string> list = new List<string> { "Like", "Love", "Care", "Haha", "Wow", "Sad", "Angry" };
		string text = "";
		if (string_11 == "")
		{
			string_11 = "1|2|4|5";
		}
		List<string> list2 = string_11.Split('|').ToList();
		if (list2.Count > 0)
		{
			text = list2.smethod_10();
			text = list[Convert.ToInt32(text) - 1];
		}
		if (string.IsNullOrEmpty(text))
		{
			text = list.smethod_10();
		}
		text = $"//*[contains(@content-desc, \"{text}\")]";
		return method_58(text);
	}

	public string method_114()
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		try
		{
			for (int i = 0; i < 2; i++)
			{
				if (bool_1)
				{
					break;
				}
				text3 = ((i != 0) ? method_97("shell cat data/data/" + string_5 + "/app_light_prefs/" + string_5 + "/authentication") : method_97("shell su -c cat data/data/" + string_5 + "/app_light_prefs/" + string_5 + "/authentication"));
				if (!(text3 == ""))
				{
					try
					{
						text = Regex.Match(text3, "EAAAAU\\S+").Value;
						string value = Regex.Match(text, "\u0005(.*?)$").Value;
						text = text.Replace(value, "");
					}
					catch
					{
					}
					string json = "{\"data\": [" + Regex.Match(text3, "\\[(.*?)\\]").Groups[1].Value + "]}";
					JObject jObject = JObject.Parse(json);
					for (int j = 0; j < jObject["data"].Count(); j++)
					{
						text2 = text2 + jObject["data"]![j]!["name"]!.ToString() + "=" + jObject["data"]![j]!["value"]!.ToString() + ";";
					}
					if (text != "")
					{
						break;
					}
				}
			}
		}
		catch
		{
		}
		return text + "|" + text2;
	}

	public string method_115()
	{
		string result = "";
		try
		{
			string text = method_116();
			if (!(text == ""))
			{
				string text2 = "";
				for (int i = 0; i < 2; i++)
				{
					if (bool_1)
					{
						break;
					}
					text2 = ((i != 0) ? method_97("shell su -c cat data/data/" + string_5 + "/app_light_prefs/" + string_5 + "/logged_in_" + text) : method_97("shell cat data/data/" + string_5 + "/app_light_prefs/" + string_5 + "/logged_in_" + text));
					if (!(text2 == ""))
					{
						text2 = Regex.Replace(text2, "[\0-\u001f]+", " ");
						string text3 = Regex.Match(text2, " name(.*?)is_pushable").Groups[1].Value.Trim();
						string text4 = Regex.Match(text2, "gender (.*?)\\s").Groups[1].Value.Trim().ToLower();
						string text5 = Regex.Match(text2, "phone_full_number\":\"(.*?)\"").Groups[1].Value.Trim();
						string text6 = Regex.Match(text2, "emails (.*?) uid").Groups[1].Value.Trim();
						string text7 = (text7 = Regex.Match(text2, "pic_square(.*?)(http.*?)\\s").Groups[2].Value.Trim());
						result = text + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7;
					}
				}
			}
		}
		catch
		{
		}
		return result;
	}

	public string method_116()
	{
		string result = "";
		try
		{
			result = Regex.Match(method_114().Split('|')[1] + ";", "c_user=(.*?);").Groups[1].Value;
		}
		catch
		{
		}
		return result;
	}

	public bool method_117(double double_0 = 0.0, params string[] string_11)
	{
		try
		{
			List<string> list_ = string_11.ToArray().ToList();
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (!(method_29(0, "", list_) == ""))
				{
					if (double_0 != 0.0)
					{
						method_81(1.0);
						if (!((double)(Environment.TickCount - tickCount) < double_0 * 1000.0))
						{
							break;
						}
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public Rect method_118(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.95)
	{
		try
		{
			using Mat mat = bitmap_0.ToMat();
			using Mat mat2 = bitmap_1.ToMat();
			using Mat mat3 = mat.Clone();
			using Mat mat4 = mat2.Clone();
			using Mat mat5 = new Mat(mat.Rows - mat2.Rows + 1, mat.Cols - mat2.Cols + 1, MatType.CV_32FC1);
			Cv2.MatchTemplate(mat3, mat4, mat5, TemplateMatchModes.CCoeffNormed);
			Cv2.Threshold(mat5, mat5, double_0, 1.0, ThresholdTypes.Tozero);
			Cv2.MinMaxLoc(mat5, out var _, out var maxVal, out var _, out var maxLoc);
			if (maxVal >= double_0)
			{
				return new Rect(maxLoc.X, maxLoc.Y, mat2.Width, mat2.Height);
			}
		}
		catch (Exception)
		{
		}
		return Rect.Empty;
	}

	public Rect[] method_119(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.95)
	{
		List<Rect> list = new List<Rect>();
		try
		{
			using Mat mat = bitmap_0.ToMat();
			using Mat mat2 = bitmap_1.ToMat();
			using Mat mat3 = mat.Clone();
			using Mat mat4 = mat2.Clone();
			using Mat mat5 = new Mat(mat.Rows - mat2.Rows + 1, mat.Cols - mat2.Cols + 1, MatType.CV_32FC1);
			Cv2.MatchTemplate(mat3, mat4, mat5, TemplateMatchModes.CCoeffNormed);
			Cv2.Threshold(mat5, mat5, double_0, 1.0, ThresholdTypes.Tozero);
			while (true)
			{
				Cv2.MinMaxLoc(mat5, out var _, out var maxVal, out var _, out var maxLoc);
				if (maxVal >= double_0)
				{
					Rect item = new Rect(new OpenCvSharp.Point(maxLoc.X, maxLoc.Y), new OpenCvSharp.Size(mat2.Width, mat2.Height));
					list.Add(item);
					Cv2.FloodFill(mat5, maxLoc, new Scalar(0.0));
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return (from rect_0 in list
			orderby rect_0.Y, rect_0.X
			select rect_0).ToArray();
	}

	public string method_120(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
	{
		try
		{
			List<Bitmap> list = new List<Bitmap>();
			DirectoryInfo directoryInfo = new DirectoryInfo(string_11);
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				Bitmap item = (Bitmap)Image.FromFile(fileInfo.FullName);
				list.Add(item);
			}
			int tickCount = Environment.TickCount;
			while (true)
			{
				if (bitmap_0 == null)
				{
					bitmap_0 = method_130();
				}
				foreach (Bitmap item2 in list)
				{
					Rect rect = method_118(bitmap_0, item2);
					if (rect != Rect.Empty)
					{
						return $"[{rect.Left},{rect.Top}][{rect.Right},{rect.Bottom}]";
					}
				}
				if (Environment.TickCount - tickCount < int_4 * 1000)
				{
					method_81(1.0);
					bitmap_0 = method_130();
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public string method_121(Bitmap bitmap_0, Bitmap bitmap_1 = null, int int_4 = 0)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				if (bitmap_1 == null)
				{
					bitmap_1 = method_130();
				}
				Rect rect = method_118(bitmap_1, bitmap_0);
				if (!(rect != Rect.Empty))
				{
					if (Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_81(1.0);
						bitmap_1 = method_130();
						continue;
					}
					break;
				}
				return $"[{rect.Left},{rect.Top}][{rect.Right},{rect.Bottom}]";
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public List<string> method_122(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			List<Bitmap> list2 = new List<Bitmap>();
			DirectoryInfo directoryInfo = new DirectoryInfo(string_11);
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				Bitmap item = (Bitmap)Image.FromFile(fileInfo.FullName);
				list2.Add(item);
			}
			int tickCount = Environment.TickCount;
			while (true)
			{
				if (bitmap_0 == null)
				{
					bitmap_0 = method_130();
				}
				foreach (Bitmap item2 in list2)
				{
					Rect[] array2 = method_119(bitmap_0, item2);
					if (array2.Length == 0)
					{
						continue;
					}
					for (int j = 0; j < array2.Length; j++)
					{
						if (array2[j].X != 0 && array2[j].Y != 0)
						{
							list.Add($"[{array2[j].Left},{array2[j].Top}][{array2[j].Right},{array2[j].Bottom}]");
						}
					}
					return list;
				}
				if (Environment.TickCount - tickCount < int_4 * 1000)
				{
					method_81(1.0);
					bitmap_0 = method_130();
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public bool method_123(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
	{
		try
		{
			string text = method_120(string_11, bitmap_0, int_4);
			if (text != "")
			{
				return method_66(text);
			}
		}
		catch
		{
		}
		return false;
	}

	public bool method_124(string string_11, int int_4 = 0, int int_5 = 10)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				string text = method_120(string_11);
				if (text != "")
				{
					for (int i = 0; i < int_5; i++)
					{
						method_66(text);
						method_81(1.0);
						string text2 = method_120(string_11);
						if (text2 == "" || text2 != text)
						{
							return true;
						}
					}
				}
				if (Environment.TickCount - tickCount < int_4 * 1000)
				{
					method_81(1.0);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		return false;
	}

	public bool method_125(string string_11, double double_0 = 0.0)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				string text = method_120(string_11);
				if (!(text != ""))
				{
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_81(1.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public bool method_126(string string_11, double double_0 = 0.0)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				string text = method_120(string_11);
				if (!(text == ""))
				{
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						method_81(1.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public bool method_127(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
	{
		try
		{
			string text = method_120(string_11, bitmap_0, int_4);
			return text != "";
		}
		catch (Exception)
		{
		}
		return false;
	}

	public string method_128(int int_4, ref Bitmap bitmap_0, List<string> list_0)
	{
		int tickCount = Environment.TickCount;
		while (true)
		{
			if (!bool_1)
			{
				if (bitmap_0 == null)
				{
					bitmap_0 = method_130();
				}
				for (int i = 0; i < list_0.Count; i++)
				{
					if (method_127(list_0[i], bitmap_0))
					{
						return list_0[i];
					}
				}
				if (int_4 == 0 || Environment.TickCount - tickCount > int_4 * 1000)
				{
					break;
				}
				method_81(1.0);
				bitmap_0 = method_130();
				continue;
			}
			return "";
		}
		return "";
	}

	public string method_129(int int_4, Bitmap bitmap_0, List<string> list_0)
	{
		return method_129(int_4, bitmap_0, list_0);
	}

	public Bitmap method_130()
	{
		return GClass7.smethod_2(String_2);
	}

	private bool method_131(string string_11)
	{
		List<string> list = method_175();
		return list.Contains(string_11);
	}

	public bool method_132(string string_11, string string_12)
	{
		method_4();
		method_97("shell su -c 'svc wifi enable'");
		if (!method_131("com.steinwurf.adbjoinwifi"))
		{
			method_177(ApplicationHelper.GetApplicationDirectory() + "\\app\\adb-join-wifi.apk");
		}
		method_86("com.steinwurf.adbjoinwifi");
		method_97("shell am start -n com.steinwurf.adbjoinwifi/.MainActivity -e ssid '" + string_11 + "' -e password_type WPA -e password '" + string_12 + "'");
		return true;
	}

	public void method_133(int int_4, int int_5, int int_6 = 1, int int_7 = 2)
	{
		int num = LicenseManager.random_0.Next(int_4, int_5 + 1);
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount < num * 1000 && !bool_1 && !method_78())
		{
			method_81(LicenseManager.random_0.Next(int_6, int_7 + 1));
		}
	}

	public void method_134()
	{
		method_168("Open reel...");
		method_27(string_5 + "/com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity");
	}

	internal string method_135(string string_11, string string_12)
	{
		string result = "";
		try
		{
			string text = "[FBAN/FB4A;FBAV/322.0.0.35.121;FBBV/297186297;FBDM/{density=2.75,width=1080,height=2130};FBLC/en_US;FBRV/298570471;FBCR/Viettel;FBMF/Xiaomi;FBBD/xiaomi;FBPN/com.facebook.katana;FBDV/Redmi Note 8;FBSV/10;FBOP/1;FBCA/arm64-v8a:;]";
			GClass24 gClass = new GClass24("", text, "", 0);
			gClass.httpRequest_0.AddHeader("Authorization", "OAuth " + string_12);
			string text2 = "method=POST&challenge_type=PASSWORD&challenge_params={\"password\":\"" + string_11 + "\"}&locale=en_US&client_country_code=VN&fb_api_req_friendly_name=validate_challenge&fb_api_caller_class=SecuredActionServiceHandler";
			string text3 = gClass.method_1("https://graph.facebook.com/secured_action/validate_challenge", text2);
			gClass.httpRequest_0.AddHeader("X-FB-Net-HNI", " 45204");
			gClass.httpRequest_0.AddHeader("X-FB-SIM-HNI", " 45201");
			gClass.httpRequest_0.AddHeader("Authorization", " OAuth " + string_12);
			gClass.httpRequest_0.AddHeader("X-FB-Connection-Type", " WIFI");
			gClass.httpRequest_0.AddHeader("X-Tigon-Is-Retry", " False");
			gClass.httpRequest_0.AddHeader("x-fb-rmd", " state=NO_MATCH");
			gClass.httpRequest_0.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
			gClass.httpRequest_0.AddHeader("x-fb-device-group", " 5120");
			gClass.httpRequest_0.AddHeader("X-FB-Friendly-Name", " PageCreationNewPage");
			gClass.httpRequest_0.AddHeader("X-FB-Request-Analytics-Tags", " graphservice");
			gClass.httpRequest_0.AddHeader("X-FB-HTTP-Engine", " Liger");
			gClass.httpRequest_0.AddHeader("X-FB-Client-IP", " True");
			gClass.httpRequest_0.AddHeader("X-FB-Server-Cluster", " True");
			gClass.httpRequest_0.AddHeader("x-fb-connection-token", " f36ca4f6f658dd2e6a1f0ff6e43e6051");
			text2 = "doc_id=4330798123599254&method=post&locale=en_US&pretty=false&format=json&purpose=fetch&variables={\"params\":{\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"},\"path\":\"security/2fac/nt/setup/qr_code\",\"params\":\"{\\\"start_screen_id\\\":\\\"[\\\\\\\"__ntid:uu97dx:0__\\\\\\\",null]\\\"}\",\"extra_client_data\":{}},\"scale\":\"3\",\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"}}&fb_api_req_friendly_name=NativeTemplateScreenQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=[\"GraphServices\"]&server_timestamps=true";
			text3 = gClass.method_1("https://graph.facebook.com/graphql/", text2);
			result = Regex.Match(text3, "secret=(.*?)&").Groups[1].Value;
			string text4 = FormHelper.smethod_85(result);
			gClass.httpRequest_0.AddHeader("X-FB-Net-HNI", " 45204");
			gClass.httpRequest_0.AddHeader("X-FB-SIM-HNI", " 45201");
			gClass.httpRequest_0.AddHeader("Authorization", "OAuth " + string_12);
			gClass.httpRequest_0.AddHeader("X-FB-Connection-Type", " WIFI");
			gClass.httpRequest_0.AddHeader("X-Tigon-Is-Retry", " False");
			gClass.httpRequest_0.AddHeader("x-fb-rmd", " state=NO_MATCH");
			gClass.httpRequest_0.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
			gClass.httpRequest_0.AddHeader("x-fb-device-group", " 5120");
			text2 = "doc_id=6091464777534071&method=post&locale=en_US&pretty=false&format=json&variables=%7B%22scale%22%3A%223%22%2C%22params%22%3A%7B%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22payload%22%3A%22security%2F2fac%2Fnt%2Fsetup%2Fcode_entry%2Fsubmit%3Fcontent_id%3D%255B%2522__ntid%253Av10gun%253A1__%2522%252Cnull%255D%26error_element_id%3D%255B%2522__ntid%253Av10gun%253A6__%2522%252Cnull%255D%26submit_button_id%3D%255B%2522__ntid%253Av10gun%253A4__%2522%252Cnull%255D%26progress_id%3D%255B%2522__ntid%253Av10gun%253A5__%2522%252Cnull%255D%26form_id%3D%255B%2522__ntid%253Av10gun%253A2__%2522%252Cnull%255D%26start_screen_id%3D%255B%2522__ntid%253Auu97dx%253A0__%2522%252Cnull%255D%22%2C%22client_data%22%3A%7B%22sensitive_string_value%22%3A%22%5B%5B%5C%22code%5B%5D%5C%22%2C%5C%22" + text4 + "%5C%22%5D%2C%5B%5C%22code_handler_type%5C%22%2C%5C%22third_party_qr_auth%5C%22%5D%5D%22%7D%7D%2C%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22profile_image_size%22%3A258%2C%22include_image_ranges%22%3Atrue%7D&fb_api_req_friendly_name=NativeTemplateAsyncQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=%5B%22GraphServices%22%5D&server_timestamps=true";
			text3 = gClass.method_1("https://graph.facebook.com/graphql/", text2);
			if (text3.Contains("error"))
			{
				result = "";
			}
		}
		catch
		{
		}
		return result;
	}

	internal int method_136(string string_11, string string_12, string string_13, string string_14, int int_4 = 0, int int_5 = 0, int int_6 = 300)
	{
		int tickCount = Environment.TickCount;
		method_98(string_6);
		method_85(string_6);
		string text = "";
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		int num4 = ((int_4 != 15) ? (-1) : 0);
		method_168("Login Tiktok...");
		do
		{
			string text2;
			if (!bool_1)
			{
				text2 = method_53();
				text = method_29(0, text2, new List<string>
				{
					"//*[@text='Log in or sign up']", "//*[@text='Sign up']", "//*[@text='Agree and continue']", "//*[@text='Swipe up for more']", "//*[@text='Start watching']", "//*[@text='Profile']", "//*[@text='Continue with Facebook']", "//android.widget.Button[starts-with(@text,'Continue as')]", "//*[starts-with(@text,'user')]", "//*[@text='Use phone / email / username']",
					"//*[@text='Email / Username']", "//android.widget.EditText[@text='Email or username']", "//*[@text='verify captcha']", "//*[@content-desc='deny' or @text='deny']", "//*[@content-desc='Skip' or @text='Skip']", "//android.widget.Button[@text='Not now']", "//*[@text='This will help us customize your viewing experience.']", "//android.widget.Button[@text='NONE OF THE ABOVE']", "//android.widget.Button[@text='No thanks']", "//*[@text='Already have an account? Log in']",
					"//*[@text='Follow your friends']", "//*[@content-desc='Unplug charger' or @text='Unplug charger']"
				});
				string text3 = text;
				string text4 = text3;
				uint num5 = Class206.smethod_0(text4);
				if (num5 <= 2488835064u)
				{
					if (num5 <= 940370423)
					{
						if (num5 <= 503461667)
						{
							if (num5 != 14426572)
							{
								if (num5 != 491345232)
								{
									if (num5 != 503461667 || !(text4 == "//android.widget.Button[@text='Not now']"))
									{
										goto IL_07d8;
									}
								}
								else if (!(text4 == "//*[@content-desc='Skip' or @text='Skip']"))
								{
									goto IL_07d8;
								}
							}
							else if (!(text4 == "//*[@content-desc='deny' or @text='deny']"))
							{
								goto IL_07d8;
							}
							goto IL_0844;
						}
						if (num5 <= 729358616)
						{
							if (num5 != 532719482)
							{
								if (num5 != 729358616 || !(text4 == "//*[@text='verify captcha']"))
								{
									goto IL_07d8;
								}
								method_130();
							}
							else
							{
								if (!(text4 == "//android.widget.ProgressBar"))
								{
									goto IL_07d8;
								}
								num3++;
								if (num3 % 5 == 0)
								{
									if (method_100(text2))
									{
										return 1;
									}
									method_60("//*[@content-desc='skip' or @text='skip']", text2);
								}
							}
							goto IL_0851;
						}
						if (num5 != 827023039)
						{
							if (num5 == 940370423 && text4 == "//*[@text='Incorrect account or password']")
							{
								return 5;
							}
						}
						else if (text4 == "//*[@text='Connection lost']")
						{
							goto IL_059f;
						}
					}
					else if (num5 <= 1289675325)
					{
						if (num5 != 975982194)
						{
							if (num5 != 1100426492)
							{
								if (num5 == 1289675325 && text4 == "//android.widget.Button[starts-with(@text,'Continue as')]")
								{
									goto IL_0844;
								}
							}
							else if (text4 == "//*[@content-desc='Unplug charger' or @text='Unplug charger']")
							{
								method_60("//*[@content-desc='OK' or @text='OK']", text2);
								goto IL_0851;
							}
						}
						else if (text4 == "//*[@text='Edit profile']")
						{
							return 1;
						}
					}
					else
					{
						if (num5 <= 1803252991)
						{
							if (num5 != 1450627680)
							{
								if (num5 != 1803252991 || !(text4 == "//*[@text='This will help us customize your viewing experience.']"))
								{
									goto IL_07d8;
								}
								method_60("//*[@text='Confirm']", text2);
							}
							else
							{
								if (!(text4 == "//*[starts-with(@text,'user')]"))
								{
									goto IL_07d8;
								}
								string_12 = method_34(text2, text, "text").First();
								method_60("//*[starts-with(@text,'user')]/parent::*/parent::*/child::*[last()]/child::*[last()]", text2);
							}
							goto IL_0851;
						}
						if (num5 != 1878701109)
						{
							if (num5 == 2488835064u && text4 == "//*[@text='Follow your friends']")
							{
								method_28();
								goto IL_0851;
							}
						}
						else if (text4 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
						{
							goto IL_059f;
						}
					}
				}
				else if (num5 <= 3301521716u)
				{
					if (num5 <= 2826808716u)
					{
						if (num5 != 2558777018u)
						{
							if (num5 != 2681761929u)
							{
								if (num5 == 2826808716u && text4 == "//*[@text='Swipe up for more']")
								{
									method_76();
									goto IL_0851;
								}
							}
							else if (text4 == "//*[@text='Log in or sign up']")
							{
								goto IL_0844;
							}
						}
						else if (text4 == "//*[@text='Start watching']")
						{
							goto IL_0844;
						}
					}
					else
					{
						if (num5 <= 3036778647u)
						{
							if (num5 != 2893717309u)
							{
								if (num5 != 3036778647u || !(text4 == "//android.widget.Button[@text='NONE OF THE ABOVE']"))
								{
									goto IL_07d8;
								}
							}
							else if (!(text4 == "//*[@text='Agree and continue']"))
							{
								goto IL_07d8;
							}
							goto IL_0844;
						}
						if (num5 != 3036894654u)
						{
							if (num5 == 3301521716u && text4 == "//android.widget.EditText[@text='Email or username']")
							{
								method_50("//android.widget.EditText[@text='Email or username']", string_12);
								method_81(1.0);
								method_50("//android.widget.EditText[@text='Password']", string_13);
								method_81(1.0);
								method_60("//*[@text='Log in']", text2);
								goto IL_0851;
							}
						}
						else if (text4 == "//*[@text='Continue with Facebook']")
						{
							goto IL_0844;
						}
					}
				}
				else if (num5 <= 3496844666u)
				{
					if (num5 != 3386554506u)
					{
						if (num5 != 3408017596u)
						{
							if (num5 == 3496844666u && text4 == "//*[@text='Trouble Loading']")
							{
								goto IL_059f;
							}
						}
						else if (text4 == "//*[@text='Profile']")
						{
							if (!method_31(0, text2, "//*[@text='Edit profile']"))
							{
								method_60(text, text2);
								goto IL_0851;
							}
							string input = "http://45.77.37.128/?type=getcode&mail=aaasasasas2323232@smakit.vn";
							string text5 = "";
							do
							{
								string text6;
								if (!bool_1)
								{
									text6 = method_53();
									text = method_29(0, text6, new List<string> { "//*[starts-with(@text,'user')]", "//*[@text='Settings and privacy']", "//*[@text='Manage account']", "//*[@text='Password']", "//*[@text=\"Can't verify your phone? Use email\"]", "//android.widget.EditText[@text='Email address']", "//*[@text='Change email address']", "//*[@text='Enter 6-digit code']", "//*[@text='No thanks']", "//android.widget.EditText[@text='Enter password']" });
									string text7 = text;
									string text8 = text7;
									num5 = Class206.smethod_0(text8);
									if (num5 <= 1450627680)
									{
										if (num5 <= 937886214)
										{
											if (num5 != 802456587)
											{
												if (num5 != 937886214 || !(text8 == "//*[@text='Enter 6-digit code']"))
												{
													goto IL_0c50;
												}
												if (text5 == "")
												{
													return -1;
												}
												string string_15 = Class23.smethod_4(0, input, text5);
												method_50("//android.widget.EditText", string_15);
											}
											else
											{
												if (!(text8 == "//*[@text='Manage account']"))
												{
													goto IL_0c50;
												}
												if (string_13 != "")
												{
													string text9 = string_12 + "|" + string_13 + "|" + text5 + "|";
													lock (object_2)
													{
														File.AppendAllText("tiktok.txt", text9 + "\r\n");
													}
													return 1;
												}
												if (method_31(0, text6, "//*[@text='Password']"))
												{
													method_60("//*[@text='Password']", text6);
												}
												else
												{
													method_60(text, text6);
												}
											}
										}
										else if (num5 != 1113589947)
										{
											if (num5 != 1450627680 || !(text8 == "//*[starts-with(@text,'user')]"))
											{
												goto IL_0c50;
											}
											string_12 = method_34(text6, text, "text").First();
											method_60("//*[starts-with(@text,'user')]/parent::*/parent::*/child::*[last()]/child::*[last()]", text6);
										}
										else
										{
											if (!(text8 == "//*[@text='Settings and privacy']"))
											{
												goto IL_0c50;
											}
											if (method_31(0, text6, "//*[@text='Manage account']"))
											{
												method_60("//*[@text='Manage account']", text6);
											}
											else
											{
												method_60(text, text6);
											}
										}
										goto IL_0cc9;
									}
									if (num5 <= 2745425442u)
									{
										if (num5 != 2698810085u)
										{
											if (num5 == 2745425442u && text8 == "//android.widget.EditText[@text='Enter password']")
											{
												string_13 = "Min@123" + FormHelper.smethod_59(5);
												method_50(text, string_13);
												method_60("//*[@text='Next']", text6);
												goto IL_0cc9;
											}
										}
										else if (text8 == "//*[@text='No thanks']")
										{
											goto IL_0cbc;
										}
									}
									else if (num5 != 3054835099u)
									{
										if (num5 != 3234013380u)
										{
											if (num5 == 3691564067u && text8 == "//android.widget.EditText[@text='Email address']")
											{
												text5 = FormHelper.smethod_62((from string_0 in Class44.smethod_3()
													orderby Guid.NewGuid()
													select string_0).First() + (from string_0 in Class44.smethod_5()
													orderby Guid.NewGuid()
													select string_0).First()).Replace(" ", "").ToLower() + FormHelper.smethod_61(6, random_0) + Regex.Match(input, "@\\w+.\\w+").Value;
												method_50(text, text5);
												method_60("//*[@text='Send code']", text6);
												goto IL_0cc9;
											}
										}
										else if (text8 == "//*[@text=\"Can't verify your phone? Use email\"]")
										{
											goto IL_0cbc;
										}
									}
									else if (text8 == "//*[@text='Change email address']")
									{
										goto IL_0cbc;
									}
									goto IL_0c50;
								}
								return -2;
								IL_0cbc:
								method_60(text, text6);
								goto IL_0cc9;
								IL_0cc9:
								method_81(1.0);
								continue;
								IL_0c50:
								if (method_31(0, text6, "//android.widget.ImageView[@content-desc='Unlock']"))
								{
									method_69();
									method_85(string_6);
								}
								else if (text6.Contains("com.android.systemui"))
								{
									method_28();
									method_85(string_6);
								}
								else if (method_85(string_6) != 1)
								{
									goto IL_0cc9;
								}
							}
							while (Environment.TickCount - tickCount < int_6 * 1000);
							break;
						}
					}
					else if (text4 == "//*[@text='Use phone / email / username']")
					{
						goto IL_0844;
					}
				}
				else
				{
					if (num5 > 3971055724u)
					{
						if (num5 != 4180370898u)
						{
							if (num5 != 4245741645u || !(text4 == "//*[@text='Already have an account? Log in']"))
							{
								goto IL_07d8;
							}
						}
						else if (!(text4 == "//android.widget.Button[@text='No thanks']"))
						{
							goto IL_07d8;
						}
						goto IL_0844;
					}
					if (num5 != 3915792911u)
					{
						if (num5 == 3971055724u && text4 == "//*[@text='Email / Username']")
						{
							goto IL_0844;
						}
					}
					else if (text4 == "//*[@text='Sign up']")
					{
						if (method_31(0, text2, "//*[@text=\"When’s your birthday?\"]"))
						{
							for (int i = 1; i < 4; i++)
							{
								string string_16 = "//*[@text='Next']/parent::*/child::*[last()]/child::*/child::*[" + i + "]";
								Class77 @class = new Class77(method_37(0, text2, string_16).First());
								int num6 = method_87(1, 4);
								if (i == 3)
								{
									num6 = 4;
								}
								for (int j = 0; j < num6; j++)
								{
									method_73(@class.int_0 + 5, @class.int_1 + 5, @class.int_2 - 5, @class.int_3 - 5, method_87(100, 200));
								}
							}
							method_60("//*[@text='Next']", text2);
						}
						else if (method_31(0, text2, "//*[@content-desc='Skip' or @text='Skip']"))
						{
							method_60("//*[@content-desc='Skip' or @text='Skip']", text2);
						}
						else
						{
							method_60(text, text2);
						}
						goto IL_0851;
					}
				}
				goto IL_07d8;
			}
			return -2;
			IL_0851:
			method_81(1.0);
			continue;
			IL_0844:
			method_60(text, text2);
			goto IL_0851;
			IL_059f:
			if (num >= num2)
			{
				if (num4 != 0 || !method_160())
				{
					return 7;
				}
				num4 = 1;
				method_85(string_5);
			}
			num++;
			if (text == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
			{
				method_60("//android.widget.Button[@text='OK']", text2);
			}
			else
			{
				method_60("//*[@text='Tap to retry']", text2);
			}
			goto IL_0851;
			IL_07d8:
			if (method_31(0, text2, "//android.widget.ImageView[@content-desc='Unlock']"))
			{
				method_69();
				method_85(string_6);
			}
			else if (text2.Contains("com.android.systemui"))
			{
				method_28();
				method_85(string_6);
			}
			else if (method_85(string_6) != 1)
			{
				goto IL_0851;
			}
		}
		while (Environment.TickCount - tickCount < int_6 * 1000);
		return 0;
	}

	internal int method_137(string string_11, string string_12, string string_13, int int_4 = 300)
	{
		method_98(string_7);
		method_85(string_7);
		int num = 0;
		int num2 = 5;
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			string text4;
			if (!bool_1)
			{
				text4 = method_53();
				text3 = method_29(0, text4, new List<string>
				{
					"android.widget.ProgressBar", "//*[starts-with(@text,'Continue as')]", "//*[@text='Log in with Facebook']", "//android.widget.Button[@text='Yes, finish setup']", "//*[@text='CREATE USERNAME']", "//android.widget.Button[@text='Sign up']", "//android.widget.Button[@text='Not now']", "//android.widget.Button[@text='Skip']", "//android.widget.Button[@content-desc='Next']", "//*[@content-desc='Profile']",
					"//*[@text='If you forgot your password, you can reset it with Facebook.']", "//android.widget.Button[@text='Đăng nhập']", "//android.widget.EditText[@text='New password']", "//android.widget.Button[@text='Dismiss']", "//android.widget.Button[@text='NONE OF THE ABOVE']", "//*[@content-desc='Unplug charger' or @text='Unplug charger']", "//*[starts-with(@text,'Log into Instagram as')]", "//*[@text='Current password']", "//*[@text='An unknown network error has occurred.']", "//*[@text=\"We couldn't log you in with Facebook.\"]"
				});
				string text5 = text3;
				string text6 = text5;
				uint num3 = Class206.smethod_0(text6);
				if (num3 <= 1896311505)
				{
					if (num3 <= 532719482)
					{
						if (num3 <= 203803302)
						{
							if (num3 != 101514837)
							{
								if (num3 == 203803302 && text6 == "//*[@content-desc='Profile']")
								{
									if (!(text2 != ""))
									{
										if (method_31(0, text4, "//android.widget.EditText[@text='Password']"))
										{
											text2 = "Min@123" + FormHelper.smethod_59(5);
											method_50("//android.widget.EditText[@text='Password']", text2);
											method_60("//android.widget.Button[@text='Create']", text4);
										}
										else if (method_31(0, text4, "//*[@text='Create password']"))
										{
											method_60("//*[@text='Create password']", text4);
										}
										else if (method_31(0, text4, "//*[@text='Password']"))
										{
											method_60("//*[@text='Password']", text4);
										}
										else if (method_31(0, text4, "//*[@text='Security']"))
										{
											method_60("//*[@text='Security']", text4);
										}
										else if (method_31(0, text4, "//android.widget.Button[@content-desc='Settings']"))
										{
											method_60("//android.widget.Button[@content-desc='Settings']", text4);
										}
										else if (method_31(0, text4, "//android.widget.Button[@content-desc='Options']"))
										{
											if (text == "")
											{
												text = method_34(text4, "//android.widget.Button[@content-desc='Options']/parent::*/child::*[1]/child::*[1]/child::*[1]/child::*[1]", "text").First();
											}
											method_60("//android.widget.Button[@content-desc='Options']", text4);
										}
										else
										{
											method_60(text3, text4);
										}
										goto IL_06ea;
									}
									string text7 = text + "|" + text2;
									lock (object_2)
									{
										File.AppendAllText("instagram.txt", text7 + "\r\n");
									}
									return 1;
								}
							}
							else if (text6 == "//*[@text=\"We couldn't log you in with Facebook.\"]")
							{
								break;
							}
						}
						else if (num3 != 359269505)
						{
							if (num3 != 503461667)
							{
								if (num3 == 532719482 && text6 == "//android.widget.ProgressBar")
								{
									goto IL_06ea;
								}
							}
							else if (text6 == "//android.widget.Button[@text='Not now']")
							{
								goto IL_06ad;
							}
						}
						else if (text6 == "//*[starts-with(@text,'Log into Instagram as')]")
						{
							break;
						}
						goto IL_063e;
					}
					if (num3 <= 1100426492)
					{
						if (num3 != 978746329)
						{
							if (num3 != 1100426492 || !(text6 == "//*[@content-desc='Unplug charger' or @text='Unplug charger']"))
							{
								goto IL_063e;
							}
							method_60("//*[@content-desc='OK' or @text='OK']", text4);
						}
						else
						{
							if (!(text6 == "//*[@text='Current password']"))
							{
								goto IL_063e;
							}
							if (!method_31(0, text4, "//*[@text='If you forgot your password, you can reset it with Facebook.']"))
							{
								return 3;
							}
						}
						goto IL_06ea;
					}
					if (num3 != 1620566430)
					{
						if (num3 != 1753985601)
						{
							if (num3 != 1896311505 || !(text6 == "//android.widget.Button[@content-desc='Next']"))
							{
								goto IL_063e;
							}
						}
						else if (!(text6 == "//android.widget.Button[@text='Skip']"))
						{
							goto IL_063e;
						}
					}
					else if (!(text6 == "//*[@text='Log in with Facebook']"))
					{
						goto IL_063e;
					}
				}
				else if (num3 <= 2853230193u)
				{
					if (num3 > 2467940779u)
					{
						if (num3 != 2621521766u)
						{
							if (num3 != 2746707739u)
							{
								if (num3 != 2853230193u || !(text6 == "//*[@text='If you forgot your password, you can reset it with Facebook.']"))
								{
									goto IL_063e;
								}
								System.Drawing.Point point = new Class77(method_37(0, text4, text3).First()).method_1();
								method_55(point.X + 200, point.Y);
							}
							else
							{
								if (!(text6 == "//android.widget.Button[@text='Đăng nhập']"))
								{
									goto IL_063e;
								}
								method_50("//android.widget.EditText", string_12);
								method_60(text3, text4);
							}
						}
						else
						{
							if (!(text6 == "//android.widget.EditText[@text='New password']"))
							{
								goto IL_063e;
							}
							text2 = "Min@123" + FormHelper.smethod_59(5);
							method_50(text3, text2);
							method_50("//android.widget.EditText[@text='New password, again']", text2);
							method_60("//android.widget.Button[@content-desc='Done']", text4);
						}
						goto IL_06ea;
					}
					if (num3 != 2032129326)
					{
						if (num3 != 2467940779u || !(text6 == "//android.widget.Button[@text='Yes, finish setup']"))
						{
							goto IL_063e;
						}
					}
					else if (!(text6 == "//android.widget.Button[@text='Dismiss']"))
					{
						goto IL_063e;
					}
				}
				else
				{
					if (num3 <= 2915547065u)
					{
						if (num3 != 2912895069u)
						{
							if (num3 == 2915547065u && text6 == "//*[@text='CREATE USERNAME']")
							{
								text = method_34(text4, "//android.widget.EditText", "text").First();
								method_60("//android.widget.Button[@text='Next']", text4);
								goto IL_06ea;
							}
						}
						else if (text6 == "//*[@text='An unknown network error has occurred.']")
						{
							break;
						}
						goto IL_063e;
					}
					if (num3 != 3036778647u)
					{
						if (num3 != 3556196668u)
						{
							if (num3 != 3850556364u || !(text6 == "//android.widget.Button[@text='Sign up']"))
							{
								goto IL_063e;
							}
						}
						else if (!(text6 == "//*[starts-with(@text,'Continue as')]"))
						{
							goto IL_063e;
						}
					}
					else if (!(text6 == "//android.widget.Button[@text='NONE OF THE ABOVE']"))
					{
						goto IL_063e;
					}
				}
				goto IL_06ad;
			}
			return -2;
			IL_06ea:
			method_81(1.0);
			continue;
			IL_06ad:
			if (text3 == "//android.widget.Button[@text='Sign up']" || text3 == "//android.widget.Button[@text='Dismiss']")
			{
				if (num >= num2)
				{
					break;
				}
				num++;
			}
			method_60(text3, text4);
			goto IL_06ea;
			IL_063e:
			if (method_31(0, text4, "//android.widget.ImageView[@content-desc='Unlock']"))
			{
				method_69();
				method_85(string_7);
			}
			else if (text4.Contains("com.android.systemui"))
			{
				method_28();
				method_85(string_7);
			}
			else if (method_85(string_7) != 1)
			{
				goto IL_06ea;
			}
		}
		while (Environment.TickCount - tickCount < int_4 * 1000);
		return 0;
	}

	internal int method_138(string string_11, string string_12, string string_13)
	{
		method_168("Check status...");
		int result = 0;
		method_85(string_5);
		string text = "";
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		int num4 = 6;
		int num5 = 0;
		int num6 = 1;
		while (true)
		{
			if (!bool_1)
			{
				text = method_53();
				if (!method_146(text, "Tap to view story"))
				{
					if (method_31(0, text, "//*[@text='Tap to retry']"))
					{
						if (num3 < num4)
						{
							num3++;
							method_78(-1);
							continue;
						}
						return 7;
					}
					if (!method_31(0, text, "//android.widget.ProgressBar"))
					{
					}
					if (method_146(text, "Save your login info"))
					{
						method_64(text, 0, "//*[@text='OK']", "//*[@text='Not now' or @content-desc='Not now']");
						result = 1;
						continue;
					}
					if (method_60("//*[@text='skip']", text))
					{
						result = 1;
						continue;
					}
					if (method_31(0, text, "//android.widget.ImageView[@content-desc='Unlock']"))
					{
						method_69();
						method_85(string_5);
						continue;
					}
					if (text.Contains("com.android.systemui"))
					{
						method_28();
						method_85(string_5);
						continue;
					}
					if (method_29(0, text, new List<string> { "//*[@text='Save your login info']", "//*[@text='Next time you log in on this phone, just tap your profile picture instead of typing a password.']" }) != "")
					{
						method_64(text, 0, "//*[@text='OK']", "//*[@text='Not now' or @content-desc='Not now']");
						method_80(2.0, 3.0);
						continue;
					}
					if (method_146(text, "Facebook isn't responding", "Facebook keeps stopping"))
					{
						if (num < num2)
						{
							if (!method_95(string_11))
							{
								num = num2 - 1;
							}
						}
						else if (num == num2)
						{
							method_98(string_5);
						}
						else
						{
							method_49(string_5);
							method_177(ApplicationHelper.GetApplicationDirectory() + "\\app\\facebook.apk");
							method_17();
							method_44();
							method_69();
							method_95(string_11);
						}
						num++;
						method_85(string_5);
						method_81(2.0);
						continue;
					}
					if (method_101(text))
					{
						if (num5 < num6)
						{
							num5++;
							method_60("//*[@text='Close']", text);
							continue;
						}
						return 13;
					}
					if (!method_103(text))
					{
						if (method_104(text))
						{
							continue;
						}
						if (!method_139(text))
						{
							if (!method_100(text))
							{
								if (method_85(string_5) != 1)
								{
									break;
								}
								method_81(3.0);
								continue;
							}
							return 0;
						}
						int num7 = method_99(string_11, string_11, string_12, string_13);
						if (num7 == 0)
						{
							return -1;
						}
						return num7;
					}
					return 2;
				}
				return 0;
			}
			return -2;
		}
		return result;
	}

	private bool method_139(string string_11)
	{
		if (string_11 == "")
		{
			string_11 = method_53();
		}
		return method_29(0, string_11, new List<string> { "//android.widget.TextView[@text='Session Expired']", "//android.widget.TextView[@text='Please log in again.']", "//android.view.ViewGroup[@content-desc='Reload Menu']", "//*[@text='Log Into Another Account']", "//*[@text='Find Your Account']" }) != "";
	}

	internal void method_140(string string_11, string string_12)
	{
		string text = method_97("shell pm path " + string_11);
		text = text.Split('\n')[0];
		text = text.Substring(text.IndexOf(":") + 1);
		text = method_97("pull " + text + " " + string_12);
	}

	private void method_141(string string_11)
	{
		string text = method_97("shell ls " + string_11);
		List<string> list = (from string_0 in text.Split(new string[2]
			{
				Environment.NewLine,
				"\n"
			}, StringSplitOptions.None)
			where !string.IsNullOrEmpty(string_0)
			select string_0).ToList();
		string string_12 = "shell su -c rm -rf /" + string_11 + "/*";
		method_97(string_12);
		string_12 = "shell su -c rm -r /" + string_11 + "/.thumbnails";
		method_97(string_12);
		foreach (string item in list)
		{
			method_97("shell am broadcast -a android.intent.action.MEDIA_SCANNER_SCAN_FILE -d \"file:///mnt/" + string_11 + "/" + Path.GetFileName(item) + "\"");
		}
	}

	internal void method_142(List<string> list_0)
	{
		method_168("Up ảnh...");
		method_141("sdcard/dcim/camera");
		method_141("sdcard/pictures");
		method_141("sdcard/movies");
		foreach (string item in list_0)
		{
			string text = FormHelper.smethod_60(10).TrimEnd('.') + "." + Path.GetExtension(item).TrimStart('.');
			method_97("push \"" + item + "\" \"/sdcard/pictures/" + text + "\"");
			method_97("shell am broadcast -a android.intent.action.MEDIA_SCANNER_SCAN_FILE -d \"file:///mnt/sdcard/pictures/" + text + "\"");
		}
	}

	internal bool method_143()
	{
		List<string> list = method_175();
		if (list.Contains("com.minsoftware.maxchanger"))
		{
			method_49("com.minsoftware.maxchanger");
		}
		if (!list.Contains("ru.andr7e.deviceinfohw"))
		{
			method_177(ApplicationHelper.GetApplicationDirectory() + "\\app\\DeviceInfoHW.apk");
		}
		method_177(ApplicationHelper.GetApplicationDirectory() + "\\app\\maxchange.apk");
		method_81(2.0);
		method_60("//android.widget.Button[@text='INSTALL ANYWAY']");
		method_97("shell am start -n com.android.shell/.BugreportWarningActivity -c org.lsposed.manager.LAUNCH_MANAGER -p com.android.shell -a android.intent.action.MAIN");
		method_81(2.0);
		method_97("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
		method_97("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
		string text = "facebook";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		while (!bool_1)
		{
			text2 = method_53();
			text3 = method_29(0, text2, new List<string> { "//android.widget.EditText[@text='Search…']", "//android.widget.Switch[@text='ON']", "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='true']", "//android.widget.Switch[@text='OFF']", "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='false']", "//android.widget.TextView[@text='MaxChanger']", "//android.widget.FrameLayout[contains(@content-desc,'Modules')]" });
			string text4 = text3;
			string text5 = text4;
			uint num2 = Class206.smethod_0(text5);
			if (num2 <= 1582824711)
			{
				if (num2 <= 1265225096)
				{
					if (num2 != 141461479)
					{
						if (num2 == 1265225096 && text5 == "//android.widget.TextView[@text='MaxChanger']")
						{
							goto IL_0347;
						}
					}
					else if (text5 == "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='false']")
					{
						goto IL_0347;
					}
				}
				else if (num2 != 1397864407)
				{
					if (num2 == 1582824711 && text5 == "//android.widget.Switch[@text='ON']")
					{
						goto IL_029b;
					}
				}
				else if (text5 == "//android.widget.FrameLayout[contains(@content-desc,'Modules')]")
				{
					if (flag)
					{
						method_60("//*[@content-desc='More options']/parent::*/child::*[1]", text2);
					}
					else
					{
						flag = true;
						method_60(text3, text2);
					}
				}
			}
			else if (num2 <= 2084351161)
			{
				if (num2 != 1926143043)
				{
					if (num2 == 2084351161 && text5 == "//android.widget.EditText[@text='Search…']")
					{
						method_50("//android.widget.EditText[@text='Search…']", text);
					}
				}
				else if (text5 == "//*[@content-desc='More options']/parent::*/child::*[1]")
				{
					goto IL_0347;
				}
			}
			else if (num2 != 2687307995u)
			{
				if (num2 == 4211664092u && text5 == "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='true']")
				{
					goto IL_029b;
				}
			}
			else if (text5 == "//android.widget.Switch[@text='OFF']")
			{
				goto IL_0347;
			}
			goto IL_0354;
			IL_0347:
			method_60(text3, text2);
			goto IL_0354;
			IL_029b:
			if (!method_31(0, text2, "//android.widget.textview[contains(@text,'" + text + "')]/parent::*/android.widget.checkbox"))
			{
				method_60("//androidx.appcompat.widget.LinearLayoutCompat[@class='androidx.appcompat.widget.LinearLayoutCompat']/android.widget.TextView", text2);
			}
			else
			{
				if (method_31(0, text2, "//android.widget.TextView[contains(@text,'" + text + "')]/parent::*/android.widget.checkbox[@checked='false']"))
				{
					method_60("//android.widget.TextView[contains(@text,'" + text + "')]", text2);
				}
				method_46("//android.widget.EditText");
				if (text == "facebook")
				{
					text = "device info hw";
				}
				else
				{
					if (!(text == "device info hw"))
					{
						return true;
					}
					text = "System";
				}
			}
			goto IL_0354;
			IL_0354:
			method_81(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_144()
	{
		List<string> list = method_176();
		foreach (string string_0 in list)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				method_97("shell am start -n " + string_0 + "/v.q -c android.intent.category.LAUNCHER -a android.intent.action.MAIN");
			});
			thread.IsBackground = true;
			thread.Start();
		}
		method_81(2.0);
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		bool flag = false;
		while (!bool_1)
		{
			text = method_53();
			text2 = method_29(0, text, new List<string> { "//android.widget.TextView[@text='No apps have asked for Superuser permission yet.']", "//android.widget.TextView[@text='Shell']/parent::*/*[@text='OFF']", "//android.widget.TextView[@text='Shell']/parent::*/*[@text='ON']", "//android.widget.FrameLayout[@content-desc='Superuser']", "//android.widget.TextView[@content-desc='Settings']", "//android.widget.TextView[@text='Settings']", "//android.widget.TextView[@text='Grant']" });
			string text3 = text2;
			string text4 = text3;
			uint num2 = Class206.smethod_0(text4);
			if (num2 <= 1133221858)
			{
				switch (num2)
				{
				case 1133221858u:
					if (!(text4 == "//android.widget.TextView[@text='Grant']"))
					{
						break;
					}
					method_60(text2, text);
					return true;
				case 829350801u:
					if (!(text4 == "//android.widget.TextView[@text='Settings']"))
					{
						break;
					}
					while (!method_60("//android.widget.TextView[@text='Automatic Response']"))
					{
						if (method_78())
						{
							return false;
						}
					}
					break;
				case 184981057u:
					if (text4 == "//android.widget.FrameLayout[@content-desc='Superuser']")
					{
						if (flag)
						{
							method_60("//android.widget.TextView[@content-desc='Settings']");
							break;
						}
						method_60(text2, text);
						flag = true;
					}
					break;
				}
			}
			else if (num2 <= 2493362195u)
			{
				if (num2 != 1228394547)
				{
					if (num2 == 2493362195u && text4 == "//android.widget.TextView[@text='Shell']/parent::*/*[@text='OFF']")
					{
						goto IL_0202;
					}
				}
				else if (text4 == "//android.widget.TextView[@content-desc='Settings']")
				{
					goto IL_0202;
				}
			}
			else if (num2 != 3190033371u)
			{
				if (num2 == 3353998111u && text4 == "//android.widget.TextView[@text='Shell']/parent::*/*[@text='ON']")
				{
					goto IL_0242;
				}
			}
			else if (text4 == "//android.widget.TextView[@text='No apps have asked for Superuser permission yet.']")
			{
				goto IL_0242;
			}
			goto IL_0253;
			IL_0242:
			method_28();
			goto IL_0253;
			IL_0202:
			method_60(text2, text);
			goto IL_0253;
			IL_0253:
			method_81(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_145()
	{
		if (method_175().Contains("com.builuc1998.max_mobile_app"))
		{
			method_49("com.builuc1998.max_mobile_app");
		}
		method_177(ApplicationHelper.GetApplicationDirectory() + "\\app\\maxhelper.apk");
		method_81(2.0);
		method_97("shell am start -a android.settings.ACCESSIBILITY_SETTINGS");
		method_81(2.0);
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		while (!bool_1)
		{
			text = method_53();
			text2 = method_29(0, text, new List<string> { "//android.widget.Button[@resource-id='com.android.settings:id/permission_disable_stop_button']", "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']", "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='true']", "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='false']", "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='true']", "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='false']", "//android.widget.TextView[@text='max_mobile_app']", "//android.widget.Button[@text='OK']", "//android.widget.Button[@text='Got it']" });
			string text3 = text2;
			string text4 = text3;
			uint num2 = Class206.smethod_0(text4);
			if (num2 <= 2286921084u)
			{
				if (num2 <= 675693509)
				{
					if (num2 != 366645833)
					{
						if (num2 == 675693509 && text4 == "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='true']")
						{
							goto IL_0287;
						}
					}
					else if (text4 == "//android.widget.TextView[@text='max_mobile_app']")
					{
						goto IL_0230;
					}
				}
				else if (num2 != 1232705540)
				{
					if (num2 == 2286921084u && text4 == "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='false']")
					{
						goto IL_0230;
					}
				}
				else if (text4 == "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='false']")
				{
					goto IL_0230;
				}
			}
			else if (num2 <= 2609368340u)
			{
				if (num2 != 2593255712u)
				{
					if (num2 == 2609368340u && text4 == "//android.widget.Button[@resource-id='com.android.settings:id/permission_disable_stop_button']")
					{
						goto IL_0287;
					}
				}
				else if (text4 == "//android.widget.Button[@text='OK']")
				{
					goto IL_0230;
				}
			}
			else if (num2 != 2614915793u)
			{
				if (num2 != 3036346468u)
				{
					if (num2 == 3445947035u && text4 == "//android.widget.Switch[@resource-id='android:id/switch_widget'][@checked='true']")
					{
						goto IL_0287;
					}
				}
				else if (text4 == "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']")
				{
					goto IL_0230;
				}
			}
			else if (text4 == "//android.widget.Button[@text='Got it']")
			{
				goto IL_0230;
			}
			goto IL_0259;
			IL_0259:
			method_81(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
			continue;
			IL_0287:
			return true;
			IL_0230:
			method_60(text2, text);
			if (text2 == "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']" || text2 == "//android.widget.Button[@text='OK']")
			{
				return true;
			}
			goto IL_0259;
		}
		return false;
	}

	public bool method_146(string string_11, params string[] string_12)
	{
		if (string_11 == "")
		{
			string_11 = method_53();
		}
		string_11 = string_11.ToLower();
		int num = 0;
		while (true)
		{
			if (num < string_12.Length)
			{
				if (string_11.Contains(string_12[num].ToLower()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_147(int int_4, string string_11, params string[] string_12)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (!bool_1)
			{
				if (string_11 == "")
				{
					string_11 = method_53();
				}
				if (!method_146(string_11, string_12))
				{
					string_11 = "";
					if (Environment.TickCount - tickCount < int_4 * 1000)
					{
						method_81(1.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception exception_)
		{
			method_82(exception_);
		}
		return false;
	}

	internal bool method_148()
	{
		method_97("shell am start -a android.settings.LOCALE_SETTINGS");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		while (!bool_1)
		{
			text = method_53();
			text2 = method_29(0, text, new List<string> { "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']", "//android.widget.TextView[@text='United States']", "//android.widget.TextView[@resource-id='android:id/locale_search_menu']", "//android.widget.EditText[@resource-id='android:id/search_src_text']", "//android.widget.Button[@resource-id='com.android.settings:id/add_language']" });
			switch (text2)
			{
			case "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']":
				if (!method_31(0, text, "//android.widget.TextView[@text='Languages']"))
				{
					if (text.Contains("English"))
					{
						List<string> list = method_37(0, text, "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']");
						if (list.Count > 1)
						{
							string string_ = list.Last();
							string string_2 = method_37(0, text, "//android.view.ViewGroup[@resource-id='com.android.settings:id/action_bar']/android.widget.LinearLayout/android.widget.ImageButton").First();
							method_75(string_, string_2);
							return true;
						}
					}
					method_60("//android.widget.Button[@resource-id='com.android.settings:id/add_language']");
					break;
				}
				return true;
			case "//android.widget.EditText[@resource-id='android:id/search_src_text']":
				method_50(text2, "English");
				method_81(2.0);
				method_61(5, "//android.widget.TextView[@resource-id='android:id/locale']", "");
				break;
			case "//android.widget.TextView[@resource-id='android:id/locale_search_menu']":
			case "//android.widget.TextView[@text='United States']":
				method_60(text2, text);
				break;
			case "//android.widget.Button[@resource-id='com.android.settings:id/add_language']":
				if (!text.Contains("English (United States)"))
				{
					method_60(text2, text);
					break;
				}
				return true;
			}
			method_81(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	public List<string> method_149()
	{
		List<string> source = method_175();
		return source.Where((string string_0) => string_0.StartsWith("com.facebook.ka")).ToList();
	}

	public List<string> method_150(string string_11 = "", int int_4 = 0)
	{
		if (string_11 == "")
		{
			string_11 = method_53().ToLower();
		}
		List<string> collection = method_152(string_11, "text=\"(.*?)\"");
		List<string> collection2 = method_152(string_11, "content-desc=\"(.*?)\"");
		List<string> collection3 = method_152(string_11, "text='(.*?)'");
		List<string> collection4 = method_152(string_11, "content-desc='(.*?)'");
		List<string> list = new List<string>();
		switch (int_4)
		{
		case 0:
			list.AddRange(collection);
			list.AddRange(collection2);
			list.AddRange(collection3);
			list.AddRange(collection4);
			break;
		case 1:
			list.AddRange(collection);
			list.AddRange(collection3);
			break;
		case 2:
			list.AddRange(collection2);
			list.AddRange(collection4);
			break;
		}
		return list;
	}

	public string method_151(string string_11)
	{
		string text = method_150(string_11).FirstOrDefault();
		if (string.IsNullOrEmpty(text))
		{
			text = "";
		}
		return text;
	}

	private List<string> method_152(string string_11, string string_12)
	{
		List<string> list = new List<string>();
		try
		{
			MatchCollection matchCollection = Regex.Matches(string_11, string_12);
			for (int i = 0; i < matchCollection.Count; i++)
			{
				if (!string.IsNullOrEmpty(matchCollection[i].Groups[1].Value))
				{
					list.Add(matchCollection[i].Groups[1].Value);
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private bool method_153()
	{
		return method_97("shell settings get global airplane_mode_on").Contains("1");
	}

	private void method_154()
	{
		method_97("shell settings put global airplane_mode_on 1");
		method_81(1.0);
		method_97("shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state true");
	}

	private void method_155()
	{
		method_97("shell settings put global airplane_mode_on 0");
		method_81(1.0);
		method_97("shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state false");
	}

	public void method_156()
	{
		method_97("shell su -c 'svc wifi disable'");
	}

	public void method_157()
	{
		method_97("shell su -c 'svc wifi enable'");
	}

	public void method_158()
	{
		method_97("shell settings put secure location_mode 0");
	}

	public void method_159()
	{
		method_97("shell settings put secure location_mode 1");
	}

	internal bool method_160()
	{
		method_4();
		int num = 0;
		while (true)
		{
			if (num < 3)
			{
				if (!method_153())
				{
					method_154();
					method_81(2.0);
				}
				method_155();
				if (method_163(60))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_161()
	{
		string text = "";
		for (int i = 0; i < 100; i++)
		{
			text = method_97("shell \"dumpsys power | grep 'Display Power' | grep -oE '(ON|OFF)'\"");
			if (text != "")
			{
				break;
			}
		}
		return text == "OFF";
	}

	public string method_162(int int_4 = 10, int int_5 = 0)
	{
		string text = "";
		string text2 = "";
		text2 = ((!(string_8 != "") || int_5 != 0) ? "shell curl -s -H 'Cache-Control: no-cache' ifconfig.co" : ("shell curl -s -H 'Cache-Control: no-cache' ifconfig.co -x \"" + string_8 + "\""));
		int tickCount = Environment.TickCount;
		do
		{
			text = method_97(text2);
			if (!text.Contains("you have authenticated yourself"))
			{
				if (text.Contains("html"))
				{
					text = "";
				}
				method_81(1.0);
				continue;
			}
			text = "Proxy Authentication Required";
			break;
		}
		while (text == "" && Environment.TickCount - tickCount < int_4 * 1000);
		return text;
	}

	public bool method_163(int int_4 = 15)
	{
		int tickCount = Environment.TickCount;
		do
		{
			string text = method_97("shell curl -s -H 'Cache-Control: no-cache' \"google.com\"");
			if (!(text != ""))
			{
				method_81(2.0);
				continue;
			}
			return true;
		}
		while (Environment.TickCount - tickCount < int_4 * 1000);
		return false;
	}

	public void method_164(string string_11 = "https://ifconfig.co/")
	{
		method_97("shell am start -a android.intent.action.VIEW -d \"" + string_11 + "\"");
	}

	public string method_165()
	{
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					text = method_97("shell \"uiautomator dump && cat /sdcard/window_dump.xml && rm /sdcard/window_dump.xml\"").ToLower();
					text = Regex.Match(text, "<\\?xml(.*?)</hierarchy>").Value;
					if (text.Trim() != "")
					{
						break;
					}
					Thread.Sleep(1000);
					continue;
				}
				catch
				{
					continue;
				}
			}
		}
		catch
		{
		}
		return text;
	}

	public string method_166()
	{
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					text = method_97("shell \"dumpsys activity | grep top-activity\"").ToLower();
					text = Regex.Match(text, "com(.*?)/").Value.TrimEnd('/');
					if (text.Trim() != "")
					{
						break;
					}
					Thread.Sleep(1000);
					continue;
				}
				catch
				{
					continue;
				}
			}
		}
		catch
		{
		}
		return text;
	}

	public string method_167(string string_11)
	{
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					text = method_97("shell \"dumpsys package " + string_11 + " | grep versionName\"").ToLower();
					text = text.Split('=')[1];
					if (text.Trim() != "")
					{
						break;
					}
					Thread.Sleep(1000);
					continue;
				}
				catch
				{
					continue;
				}
			}
		}
		catch
		{
		}
		return text;
	}

	public void method_168(string string_11)
	{
	}

	internal bool method_169(int int_4)
	{
		method_97("shell am start -a android.settings.NETWORK_OPERATOR_SETTINGS");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		bool flag = false;
		int num2 = 0;
		int num3 = 2;
		while (!bool_1)
		{
			text = method_53();
			text2 = method_29(0, text, new List<string> { "//android.widget.TextView[@text='Advanced']", "//android.widget.TextView[@text='Access Point Names']", "//android.widget.RadioButton[@resource-id='com.android.settings:id/apn_radiobutton']", "//android.widget.CheckedTextView[@class='android.widget.CheckedTextView']", "//android.widget.TextView[@text='APN protocol']", "//android.widget.TextView[@text='Save']" });
			switch (text2)
			{
			default:
				if (method_78())
				{
					if (num2 >= num3)
					{
						return false;
					}
					num2++;
				}
				break;
			case "//android.widget.RadioButton[@resource-id='com.android.settings:id/apn_radiobutton']":
			{
				Class77 @class = new Class77(method_37(0, text, text2).First());
				System.Drawing.Point point = @class.method_1();
				method_55(point.X - 300, point.Y);
				break;
			}
			case "//android.widget.CheckedTextView[@class='android.widget.CheckedTextView']":
				method_60($"({text2})[{int_4}]", text);
				flag = true;
				break;
			case "//android.widget.TextView[@text='APN protocol']":
				if (flag)
				{
					method_60("//android.widget.ImageButton[@content-desc='More options']");
				}
				else
				{
					method_60(text2, text);
				}
				break;
			case "//android.widget.TextView[@text='Advanced']":
			case "//android.widget.TextView[@text='Access Point Names']":
				method_60(text2, text);
				break;
			case "//android.widget.TextView[@text='Save']":
				method_60(text2, text);
				return true;
			}
			method_81(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_170()
	{
		method_97("shell am start -a android.settings.NETWORK_OPERATOR_SETTINGS");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		int num2 = 0;
		int num3 = 2;
		while (!bool_1)
		{
			text = method_53();
			text2 = method_29(0, text, new List<string> { "//*[@text='Preferred network type']" });
			string text3 = text2;
			string text4 = text3;
			if (!(text4 == "//*[@text='Preferred network type']"))
			{
				if (method_78())
				{
					if (num2 >= num3)
					{
						return false;
					}
					num2++;
				}
			}
			else
			{
				if (method_31(0, text, "//android.widget.CheckedTextView[contains(@text,'LTE')]"))
				{
					method_76(-1, 4);
					method_81(1.0);
					method_76(1, method_87(0, 4));
					method_66(method_37(0, "", "//android.widget.CheckedTextView[contains(@text,'LTE')]").smethod_10());
					method_81(1.0);
					return true;
				}
				method_60(text2, text);
			}
			method_81(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_171()
	{
		method_97("shell am start -a android.settings.ZEN_MODE_PRIORITY_SETTINGS");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		int num2 = 0;
		int num3 = 2;
		while (!bool_1)
		{
			text = method_53();
			text2 = method_29(0, text, new List<string> { "//android.widget.Button[@text='Turn on now']", "//android.widget.Button[@text='Turn off now']" });
			string text3 = text2;
			string text4 = text3;
			if (!(text4 == "//android.widget.Button[@text='Turn on now']"))
			{
				if (text4 == "//android.widget.Button[@text='Turn off now']")
				{
					return true;
				}
				if (method_78())
				{
					if (num2 >= num3)
					{
						return false;
					}
					num2++;
				}
			}
			else
			{
				method_60(text2, text);
			}
			method_81(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal List<string> method_172(List<string> list_0)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (string item in list_0)
		{
			list2.Add(new Class77(item).int_0.ToString());
		}
		string s = "";
		int num = 0;
		foreach (IGrouping<string, string> item2 in from string_0 in list2
			group string_0 by string_0)
		{
			if (item2.Count() > num)
			{
				s = item2.Key;
				num = item2.Count();
			}
		}
		foreach (string item3 in list_0)
		{
			if (new Class77(item3).int_0 == int.Parse(s))
			{
				list.Add(item3);
			}
		}
		return list;
	}

	internal bool method_173()
	{
		method_97("shell am start -a android.settings.DISPLAY_SETTINGS");
		int tickCount = Environment.TickCount;
		while (!bool_1)
		{
			string text = method_53();
			string text2 = method_29(0, text, new List<string> { "//android.widget.Switch[@content-desc='Dark theme'][@text='ON']", "//android.widget.Switch[@content-desc='Dark theme'][@text='OFF']" });
			string text3 = text2;
			string text4 = text3;
			if (!(text4 == "//android.widget.Switch[@content-desc='Dark theme'][@text='OFF']"))
			{
				if (text4 == "//android.widget.Switch[@content-desc='Dark theme'][@text='ON']")
				{
					return true;
				}
			}
			else
			{
				method_60(text2, text);
			}
			method_81(1.0);
			if (Environment.TickCount - tickCount >= 60000)
			{
				break;
			}
		}
		return false;
	}

	internal string method_174()
	{
		string input = method_97("shell dumpsys display");
		string value = Regex.Match(input, "deviceWidth=\\d+").Value;
		value = Regex.Match(value, "\\d+").Value;
		string value2 = Regex.Match(input, "deviceHeight=\\d+").Value;
		value2 = Regex.Match(value2, "\\d+").Value;
		return value + "x" + value2;
	}

	public List<string> method_175()
	{
		List<string> result = new List<string>();
		string text = method_97("shell pm list packages").Replace("package:", "").Trim();
		if (text != "" && text != "not found emulator!")
		{
			result = text.Split('\n').ToList();
		}
		return result;
	}

	public List<string> method_176()
	{
		List<string> result = new List<string>();
		string text = method_97("shell pm list packages -3").Replace("package:", "").Trim();
		if (text != "" && text != "not found emulator!")
		{
			result = text.Split('\n').ToList();
		}
		return result;
	}

	public bool method_177(string string_11)
	{
		method_97("shell settings put global verifier_verify_adb_installs 0");
		method_97("install \"" + string_11 + "\"", 120);
		return true;
	}

	public bool method_178(string string_11 = "")
	{
		try
		{
			string text = String_2;
			if (string_11 == "")
			{
				string_11 = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
			}
			string text2 = "CheckDevice";
			FormHelper.smethod_34(text2);
			FormHelper.smethod_34(text2 + "\\" + text);
			method_130().Save(text2 + "\\" + text + "\\" + string_11 + ".png");
			File.AppendAllText(text2 + "\\" + text + "\\" + string_11 + ".txt", method_22() + "\r\n");
			File.AppendAllText(text2 + "\\" + text + "\\" + string_11 + ".txt", method_53());
			return true;
		}
		catch
		{
		}
		return false;
	}

	public void method_179(string string_11 = "")
	{
		if (string_11 == "")
		{
			string_11 = method_53();
		}
		string_10 = string_11;
	}

	public bool method_180(int int_4, ref string string_11)
	{
		int tickCount = Environment.TickCount;
		while (!bool_1)
		{
			if (string_11 == "")
			{
				string_11 = method_53();
			}
			if (!(string_10 != string_11))
			{
				if (int_4 == 0)
				{
					break;
				}
				method_81(1.0);
				string_11 = "";
				if (Environment.TickCount - tickCount >= int_4 * 1000)
				{
					break;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	public bool method_181(int int_4 = 0, string string_11 = "")
	{
		return method_180(int_4, ref string_11);
	}
}
