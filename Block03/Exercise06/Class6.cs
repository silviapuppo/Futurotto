using System;
using System.IO;

namespace Exercise06
{
    public class FileParseException : Exception
    {
        public string fileName;
        public int row;
        public string errorMessage;

        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }

        public string Row
        {
            get
            {
                return this.Row;
            }
            set
            {
                this.Row = value;
            }
        }

        public FileParseException(string message)
        {
            this.errorMessage = message;
        }

        public FileParseException(string fileName, int row, Exception inner)
        {
            this.fileName = fileName;
            this.row = row;
            this.errorMessage = string.Format("Attention! Parse Filed in file {0} at row {1}", this.fileName, this.row);
        }

        public FileParseException(string message, string fileName, int row, Exception inner)
        {
            this.fileName = fileName;
            this.row = row;
            this.errorMessage = message;
        }

    }

    public class Class6
    {
        public static void ReadFile(string path)
        {
            StreamReader file = new StreamReader(path);

            string line;
            int row = 0;
            int value;

            while ((line = file.ReadLine()) != null)
            {

                row++;

                try
                {
                    value = int.Parse(line);
                }
                catch (Exception e)
                {
                    throw new FileParseException(path, row, e);
                }
            }
        }
    }
}

