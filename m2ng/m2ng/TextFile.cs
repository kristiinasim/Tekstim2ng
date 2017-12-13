using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace m2ng
{
    public class TextFile
    {
        private string TextFileName = "";
        private List<string> Info = new List<string>();

        public TextFile(string FileName)
        {
            this.TextFileName = FileName;
            this.Load();
        }

        public void Load()
        {
            if (File.Exists(this.TextFileName))
            {
                var textFile = File.ReadAllLines(this.TextFileName);
                this.Info = new List<string>(textFile);
            }
        }

        public void Save()
        {
            using (TextWriter tw = new StreamWriter(this.TextFileName))
            {
                foreach (String s in this.Info)
                    tw.WriteLine(s);
            }
        }

        public string getText()
        {

            string result = "";
            if (this.Info.Count != 0)
            {
                result = string.Join("\n", this.Info.ToArray());
            }
            return result;
        }

        public void DeleteLine(int idx)
        {
            if(idx < this.Info.Count)
            {
                this.Info.RemoveAt(idx);
            }
        }

        public void AddLine(string row)
        {
            this.Info.Add(row);
        }

        public int Find(int column, string value)
        {
            if (this.Info.Count == 0) return -1;
            int n = 0;
            foreach(string row in this.Info)
            {
                string[] rowValues = row.Split(';');
                if (rowValues[column] == value) return n;
                n++;
            }
            return 0;
        }

        public string getValue(int idx, int column)
        {
            if (this.Info.Count == 0) return "";
            string[] rida = this.Info[idx].Split(';');
            if (rida.Length > column)
            {
                return rida[column];
            }

            return "";

            
        }
    }
}
