using System.Collections.Generic;

namespace TestListTemplate
{
    public class MainViewModel
    {
        public List<FileData> Files { get; set; }
        public string Name { get; set; } = "james";

        public MainViewModel()
        {
            List<FileData> fileDatas = new();
            fileDatas.Add(new FileData { FileName = "RefCount.txt", FullPath = @"C:\Program Files (x86)\Common Files" });
            fileDatas.Add(new FileData { FileName = "Adobe Desktop Service.exe", FullPath = @"C:\Program Files (x86)\Common Files\Adobe\Adobe Desktop Common\ADS" });
            Files = fileDatas;
        }
    }
}