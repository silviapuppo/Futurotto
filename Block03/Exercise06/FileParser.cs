using System;
using System.IO;

namespace Exercise06
{
    public class FileParseException : Exception
    {
        private string fileName;
        private int row;
        private string message;

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
            this.message = message;
        }

        public FileParseException(string fileName, int row, Exception inner)
        {
            this.fileName = fileName;
            this.row = row;
            this.message = string.Format("Attention! Parse failed in file {0} at row {1}", this.fileName, this.row);
        }

        public FileParseException(string message, string fileName, int row, Exception inner)
        {
            this.fileName = fileName;
            this.row = row;
            this.message = message;
        }

    }

    public class FileParser
    {
        public static void ReadFile(string path)
        {
            try
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
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(string.Format("Attention! File {0} not found", path ));
            }
        }
    }
}