using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoEAssetUpdater
{
	internal static class Logger
	{
		#region Variables

		private static readonly StringBuilder _logs = new StringBuilder();

		#endregion

		#region Public Methods

		public static void Write(string message)
		{
			_logs.Append(message);
			Console.Write(message);
		}

		public static void WriteLine(string message)
		{
			_logs.AppendLine(message);
			Console.WriteLine(message);
		}

		public static void SaveLogs(string logFilePath)
		{
			File.WriteAllText(logFilePath, _logs.ToString());
		}

		#endregion
	}
}
