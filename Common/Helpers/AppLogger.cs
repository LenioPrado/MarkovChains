using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Common.Helpers
{
    public class AppLogger
    {
        private readonly ILogger _logger;
        private readonly string _logFileName;

        public AppLogger(ILogger logger, string logFileName)
        {
            _logger = logger;
            _logFileName = logFileName;
        }

        public void LogError(Exception ex, bool jumpLine = true)
        {
            LogValue(ex.ToString(), LogLevel.Error, jumpLine);
        }

        public void LogError(string msg, bool jumpLine = true)
        {
            LogValue(msg, LogLevel.Error, jumpLine);
        }

        public void LogInformation(string msg, bool jumpLine = true)
        {
            LogValue(msg, LogLevel.Information, jumpLine);
        }

        public void LogWarning(string msg, bool jumpLine = true)
        {
            LogValue(msg, LogLevel.Warning, jumpLine);
        }

        private void LogValue(string msg, LogLevel logLevel, bool jumpLine = true)
        {
            switch (logLevel)
            {
                case LogLevel.Trace:
                    _logger.LogTrace(msg);
                    break;
                case LogLevel.Debug:
                    _logger.LogDebug(msg);
                    break;
                case LogLevel.Information:
                    _logger.LogInformation(msg);
                    break;
                case LogLevel.Warning:
                    _logger.LogWarning(msg);
                    break;
                case LogLevel.Error:
                    _logger.LogError(msg);
                    break;
                case LogLevel.Critical:
                    _logger.LogCritical(msg);
                    break;
                case LogLevel.None:
                    break;
                default:
                    break;
            }
            try
            {
                using StreamWriter _writer = File.AppendText(_logFileName);
                if(jumpLine)
                    _writer.WriteLine(msg);
                else
                    _writer.Write(msg);
                _writer.Flush();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
