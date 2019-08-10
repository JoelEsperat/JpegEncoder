using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JpegEncoder
{
    public class Encoder
    {
        private readonly string _inputFolderPath;
        private readonly string _outputFolderPath;
        private readonly int _quality;

        public event Action<int> ProgressChanged;

        private object syncRoot = new object();

        public int TotalFilesCount { get; private set; }
        public int EncodedFilesCount { get; private set; }

        public Encoder(string inputFolderPath, string outputFolderPath, int quality)
        {
            _inputFolderPath = inputFolderPath;
            _outputFolderPath = outputFolderPath;
            _quality = quality;
            TotalFilesCount = CountJpegFiles(inputFolderPath);
            EncodedFilesCount = 0;
        }

        public static int CountJpegFiles(string inputFolderPath)
        {
            var result = -1;
            try
            {
                var jpgFiles = Directory.GetFiles(inputFolderPath, "*.jpg", SearchOption.AllDirectories);
                var jpegFiles = Directory.GetFiles(inputFolderPath, "*.jpeg", SearchOption.AllDirectories);
                result = jpgFiles.Count() + jpegFiles.Count();
            }
            catch { }

            return result;
        }

        public void Encode()
        {
            if (!(TotalFilesCount > 0)) throw new Exception("No files found.");

            var inputFiles = new List<string>();
            inputFiles.AddRange(Directory.GetFiles(_inputFolderPath, "*.jpg", SearchOption.AllDirectories));
            inputFiles.AddRange(Directory.GetFiles(_inputFolderPath, "*.jpeg", SearchOption.AllDirectories));

            Parallel.ForEach(inputFiles, f => EncodeFile(f, _inputFolderPath, _outputFolderPath));
        }

        private void EncodeFile(string inputFilePath, string inputFolderPath, string outputFolderPath)
        {
            var outputFilePath = inputFilePath.ReplaceFirst(inputFolderPath, outputFolderPath);
            var directory = Path.GetDirectoryName(outputFilePath);
            Directory.CreateDirectory(directory);
            if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
            InvokeCjpeg(inputFilePath, outputFilePath, _quality);
            lock (syncRoot) EncodedFilesCount++;
            UpdateProgress(EncodedFilesCount);
        }

        private void InvokeCjpeg(string inputFilePath, string outputFilePath, int quality)
        {
            var cjpegExe = @"cjpeg-static.exe";
            var p = new Process();
            p.StartInfo.FileName = cjpegExe;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = $"-quality {quality} -outfile \"{outputFilePath}\" \"{inputFilePath}\"";
            p.Start();
            p.WaitForExit();
        }

        private void UpdateProgress(int progress)
        {
            var eh = ProgressChanged;
            if (eh != null) eh(progress);
        }
    }
}
