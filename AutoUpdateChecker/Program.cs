using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Threading;
using System.Configuration;

namespace AutoUpdateChecker
{
    class Program
    {
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		static void Main(string[] args)
        {
			try
			{
				while (true)
				{					
					CheckRunning();
					CheckVersion();
					Thread.Sleep(5000);
				};
			}
			catch(Exception ex)
			{
				log.Debug("Exception occured" + ex.Message);
			}
		}
		static void CheckRunning()
		{
			Console.WriteLine("Checking if the Agent is running");
			log.Info("Checking if the Agent is running");
			if (Process.GetProcessesByName("AutoUpdate").Length==0)
			{
				Console.WriteLine("Agent not running. Initializing Agent");
				log.Info("Agent not running. Initializing Agent");
				string executablePath = ConfigurationManager.AppSettings["executablePath"];
				TriggerExecutable(executablePath);
			}	
		}
		static void CheckVersion()
		{
			string executablePath = ConfigurationManager.AppSettings["executablePath"];
			string localPath = ConfigurationManager.AppSettings["localPath"];
			string zipDownloadPath = ConfigurationManager.AppSettings["zipDownloadPath"];
			string extractPath = ConfigurationManager.AppSettings["extractPath"]; 
			string versionURL = ConfigurationManager.AppSettings["versionURL"];
			float localVersion;
			float serverVersion;

			if (!File.Exists(localPath + @"\version.txt"))
			{
				Console.WriteLine("Calling the executable");
				TriggerExecutable(executablePath);
				Console.WriteLine("done.");
			}

			Thread.Sleep(2000);
			Console.WriteLine("Reading local version info");
			float.TryParse(File.ReadAllText(localPath + @"\version.txt"),out localVersion);
			Console.WriteLine("Local version: " + localVersion);

			Console.WriteLine("Checking for updates...");
			DownloadAndExtractFile(zipDownloadPath, extractPath, versionURL,"version.txt");
			float.TryParse(System.IO.File.ReadAllText(extractPath + "\\version.txt"), out serverVersion);
			Console.WriteLine("Server version is: " + serverVersion);
			
			if (serverVersion > localVersion)
			{
				// There is a new version on the server!
				Console.WriteLine("There is a new version available on the server.");
				Console.WriteLine("Current Version: {0}, New version: {1}", localVersion, serverVersion);
				UpdateVersion();
			}
			else
			{
				Console.WriteLine("You are using the latest version");
			}


		}

		static void UpdateVersion()
		{
			string exeZipDownloadPath = ConfigurationManager.AppSettings["exeZipDownloadPath"];
			string exeExtractPath = ConfigurationManager.AppSettings["exeExtractPath"];
			string executablePath = ConfigurationManager.AppSettings["executablePath"];
			string appURL = ConfigurationManager.AppSettings["appURL"];

			DownloadAndExtractFile(exeZipDownloadPath, exeExtractPath, appURL,"AutoUpdate.exe");
			KillProcess();
			Thread.Sleep(5000);
			TriggerExecutable(executablePath);

		}

		static void KillProcess()
		{
			foreach (var process in Process.GetProcessesByName("AutoUpdate"))
			{
				Console.WriteLine("Closing old version");
				process.Kill();
			}
		}
		static void DownloadAndExtractFile(string zipDownloadPath, string extractPath, string URL, string extractFileName)
		{
			Console.WriteLine("Begin extract ..." + zipDownloadPath);
			WebClient webClient = new WebClient();
			if (File.Exists(zipDownloadPath))
			{
				Console.WriteLine("Deleting exiting file ..." + zipDownloadPath);
				File.Delete(zipDownloadPath);
			}
			Console.WriteLine("Downloading file from ..." + URL);
			webClient.DownloadFile(URL, zipDownloadPath);

			Console.WriteLine("Extracting to..." + extractPath);
			if (File.Exists(extractPath + "\\" + extractFileName))
			{
				Console.WriteLine("Deleting exiting file ..." + extractPath + "\\" + extractFileName);
				File.Delete(extractPath + "\\" +extractFileName);
			}

			ZipFile.ExtractToDirectory(zipDownloadPath, extractPath);
			Console.WriteLine(extractFileName + ": Download and Extraction completed");
		}
		static void TriggerExecutable(string executablePath)
		{
			Process myProcess = new Process();

			try
			{
				myProcess.StartInfo.UseShellExecute = true;				
				myProcess.StartInfo.FileName = executablePath;								
				myProcess.Start();
				
				// This code assumes the process you are starting will terminate itself.
				// Given that is is started without a window so you cannot terminate it
				// on the desktop, it must terminate itself or you can do it programmatically
				// from this application using the Kill method.
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

	}
}
