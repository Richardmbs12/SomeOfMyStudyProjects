using System;
using System.Collections.Generic;
using System.IO;
using BusinessLayer.io.fileHandler;

namespace BusinessLogicLayer.io.fileHandler
{
    public class FileHandler : IFileHandler
    {
        private FileStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private string filePath;

        public FileHandler(string filePath = "logs/Error_Log.txt")
        {
            this.filePath = filePath;
        }

        public void WriteToTxt(List<string> rawData)
        {
            try
            {
                stream = new FileStream(this.filePath, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(stream);

                foreach (string item in rawData)
                {
                    writer.WriteLine(item);
                    writer.Flush();
                }
            }
            catch (FileNotFoundException)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("File {0} was not found at {1}", this.filePath, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (DirectoryNotFoundException)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Directory {0} was not found at {1}", this.filePath, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (FileCustomException)
            {
                FileCustomException exception = new FileCustomException("verkeerd!");
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Critical Error {0} was found at {1}", exception.Message, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (IOException e)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Critical Error {0} was found at {1}", e.Message, DateTime.UtcNow.ToShortDateString()) });
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
        }

        public void AppendToTxt(List<string> rawData)
        {
            try
            {
                stream = new FileStream(this.filePath, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(stream);

                foreach (string item in rawData)
                {
                    writer.WriteLine(item);
                    writer.Flush();
                }
            }
            catch (FileNotFoundException)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("File {0} was not found at {1}", this.filePath, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (DirectoryNotFoundException)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Directory {0} was not found at {1}", this.filePath, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (FileCustomException)
            {
                FileCustomException exception = new FileCustomException("verkeerd!");
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Critical Error {0} was found at {1}", exception.Message, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (IOException e)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Critical Error {0} was found at {1}", e.Message, DateTime.UtcNow.ToShortDateString()) });
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
        }

        public List<string> ReadFromTxt()
        {
            List<string> textFileLines = new List<string>();

            try
            {
                stream = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    textFileLines.Add(line);
                }
            }
            catch (FileNotFoundException)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("File {0} was not found at {1}", this.filePath, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (DirectoryNotFoundException)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Directory {0} was not found at {1}", this.filePath, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (FileCustomException)
            {
                FileCustomException exception = new FileCustomException("verkeerd!");
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Critical Error {0} was found at {1}", exception.Message, DateTime.UtcNow.ToShortDateString()) });
            }
            catch (IOException e)
            {
                new FileHandler().AppendToTxt(new List<string>() { string.Format("Critical Error {0} was found at {1}", e.Message, DateTime.UtcNow.ToShortDateString()) });
            }
            finally
            {
                reader.Close();
                stream.Close();
            }
            return textFileLines;
        }
    }
}

