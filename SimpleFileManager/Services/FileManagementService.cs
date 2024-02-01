using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileManager.Services
{
    public class FileManagementService
    {
        public static FileManagementService Instance { get { return new FileManagementService(); } private set { } }

        private FileManagementService() { }

        public void delete(string path)
        {
            if(Directory.Exists(path))
            {
                Directory.Delete(path, true);
            } else if(File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void copy(string source, string destination)
        {
            if(Directory.Exists(source)) 
            {
                DirectoryInfo sourceInfo = new DirectoryInfo(source);
                destination = $"{destination}/{sourceInfo.Name}";
                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }
                if(Directory.GetFiles(source).Length > 0) 
                {
                    foreach (var f in Directory.GetFiles(source))
                    {
                        FileInfo fileInfo = new FileInfo(f);
                        string copyFile = $"{destination}/{fileInfo.Name}";
                        File.Copy(f, copyFile);
                    }
                }
                if(Directory.GetDirectories(source).Length > 0)
                {
                    foreach (var d in Directory.GetDirectories(source))
                    {
                        copy(d, destination);
                    }
                }

            }
            else if(File.Exists(source))
            {
                FileInfo sourceInfo = new FileInfo(source);
                File.Copy(source ,destination);
            }
        }

        public void createFile(string path, int index = 0)
        {
            if (File.Exists(path))
            {
                index += 1;
                FileInfo fileInfo = new FileInfo(path);
                String extractPath = fileInfo.Directory.FullName;
                String extractName = $"{fileInfo.Name.Replace(fileInfo.Extension, "")}_{index}";
                path = $"{extractPath}/{extractName}{fileInfo.Extension}";
                createFile(path, index);
                
            }
            FileStream createFileStream = File.Create(path);
            createFileStream.Close();
        }

        public void createFolder(string path, int index = 0)
        {
            if (Directory.Exists(path))
            {
                index += 1;
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                String extractPath = dirInfo.Parent.FullName;
                String extractName = $"{dirInfo.Name}_{index}";
                path = $"{extractPath}/{extractName}{dirInfo.Extension}";
                createFolder(path, index);
            }
            Directory.CreateDirectory(path);
        }
    }
}
