using BenchmarkDotNet.Attributes;

namespace LazyIterationTest
{
    public class FileProcess
    {
        [Benchmark]
        public void ProcessFile()
        {            
            string path = Resource.DataDirectory;            
            var dataFiles = GetFileDetail(path);
            foreach (var item in dataFiles)
            {
                ProcessFileData(item);
            }
        }

        [Benchmark]
        public void ProcessFileLazy()
        {
            string path = Resource.DataDirectory;
            var dataFiles = GetFileDetailLazy(path);
            foreach (var item in dataFiles)
            {
                ProcessFileData(item);
            }
        }

        IEnumerable<(string Name, long Size)> GetFileDetail(string directoryPath)
        {
            var fileDetail = new List<(string Name, long Size)>();
            var files = Directory.GetFiles(directoryPath);

            foreach (var filePath in files)
            {
                var fileInfo = new FileInfo(filePath);
                fileDetail.Add((fileInfo.Name, fileInfo.Length));
            }

            return fileDetail;
        }
        private IEnumerable<(string Name, long Size)> GetFileDetailLazy(string directoryPath)
        {
            var files = Directory.GetFiles(directoryPath);
            foreach (var filePath in files)
            {
                var fileInfo = new FileInfo(filePath);
                yield return (fileInfo.Name, fileInfo.Length);
            }
        }

        private static void ProcessFileData((string Name, long Size) fileDetail)
        {
            Console.WriteLine($"Processed: {fileDetail.Name}, Size: {fileDetail.Size} bytes");
        }
    }
}