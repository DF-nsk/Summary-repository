using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextEditorBL
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string filePath, string content, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filePath);

    }
   public class FileManager : IFileManager
    {
       

        //Открываем фаил в нужной кодировке
        private readonly Encoding _encode = Encoding.GetEncoding(1251);

        public string GetContent(string filePath)
        {
            return GetContent(filePath, _encode);
        }

        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }
        //Сохраняем фаил в нужной кодировке
        public void SaveContent(string content, string filePath)
        {
            SaveContent(filePath, content, _encode);
        }

        public void SaveContent(string filePath, string content, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }
        //Подсчет количества символов
        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;
        }
        //Проверка наличия файла
        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }


    }
}
