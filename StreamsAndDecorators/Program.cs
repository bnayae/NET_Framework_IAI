using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.IO.Compression;

namespace StreamsAndDecorators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo of file streams
            //FileStream();

            //Demo of stream readers and writers
            //ReadersWriters();

            //Demo of simple File API
            //FileReadLines();

            //Demo of binary readers and writers
            //BinaryReadersWriters();

            //Demo of CompositeOutputStream
            //CompositeOutputStream();

            //Demo of XorEncryptionStream
            //XorEncryptionStream();

            //Demo: real-life encryption
            //RealEncryption();

            //Demo: real-life compression
            //Compression();

            Console.ReadKey();
        }

        #region FileStream

        /// <summary>
        /// Demonstrates the fundamental FileStream APIs, including
        /// the file creation modes, file access modes, file sharing modes
        /// and various methods and properties for reading and writing
        /// data.  This example uses the Encoding.Unicode object to
        /// encode and decode strings from their byte array representations.
        /// </summary>
        private static void FileStream()
        {
            string greeting = @"Good 
.....
afternoon1";
            byte[] output = Encoding.UTF8.GetBytes(greeting);
            using (FileStream myFile = new FileStream("myfile.txt",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                myFile.Write(output, 0, output.Length);
                // myFile.Close();
            }

            byte[] input = new byte[output.Length];
            using (FileStream myFile = new FileStream("myfile.txt",
                FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                myFile.Read(input, 0, input.Length);
                //myFile.Close();
            }
            Console.WriteLine("Read from file: " +
                Encoding.UTF8.GetString(input));
        }

        #endregion // FileStream

        #region ReadersWriters

        /// <summary>
        /// Demonstrates the use of StreamWriter and StreamReader
        /// to write and read textual information with files.
        /// </summary>
        private static void ReadersWriters()
        {
            string greeting = @"Good 
.....
afternoon";
            using (FileStream myFile = new FileStream("myfile.txt",
                FileMode.Create))
            using (StreamWriter writer = new StreamWriter(myFile, Encoding.UTF8))
            //using (StreamWriter writer = new StreamWriter("myfile.txt"))
            {
                writer.WriteLine(greeting);
                //writer.Close(); //This is critical!
            }

            //Short-hand for creating a file
            using (FileStream myFile = new FileStream("myfile.txt",
                FileMode.Open))
            using (StreamReader reader = new StreamReader(myFile))
            //using (StreamReader reader = new StreamReader("myfile.txt"))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                //reader.Close();
            }
        }

        #endregion // ReadersWriters

        #region FileReadLines

        private static void FileReadLines()
        {
            const string FILE_NAME = "simplefile.txt";
            string greeting = @"Good 
.....
afternoon";
            File.WriteAllText(FILE_NAME, greeting);
            foreach (string line in File.ReadLines(FILE_NAME))
            {
                Console.WriteLine(line);
            }
        }

        #endregion // FileReadLines

        #region BinaryReadersWriters

        /// <summary>
        /// Demonstrates how a matrix of 10x10 double-precision numbers
        /// can be serialized to a binary file using the BinaryWriter class
        /// and then deserialized from the file using the BinaryReader class.
        /// Make note of the fact the matrix dimensions are serialized so that
        /// later on the matrix can be recreated.
        /// </summary>
        private static void BinaryReadersWriters()
        {
            double[,] matrix = new double[10, 10];
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                    matrix[i, j] = i * j;

            using (var srm = new FileStream("matrix.dat", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(srm))
            {
                int x = matrix.GetUpperBound(0) + 1;
                int y = matrix.GetUpperBound(1) + 1;
                writer.Write(x);
                writer.Write(y);
                for (int i = 0; i < x; ++i)
                    for (int j = 0; j < y; ++j)
                        writer.Write(matrix[i, j]);
                //writer.Close();
            }

            using (var srm = new FileStream("matrix.dat", FileMode.Open))
            using (BinaryReader reader = new BinaryReader(srm))
            {
                int dim0 = reader.ReadInt32();
                int dim1 = reader.ReadInt32();
                double[,] newMatrix = new double[dim0, dim1];
                for (int i = 0; i < dim0; ++i)
                    for (int j = 0; j < dim1; ++j)
                        newMatrix[i, j] = reader.ReadDouble();
                //reader.Close();
            }
        }

        #endregion // BinaryReadersWriters

        #region XorEncryptionStream

        /// <summary>
        /// Demonstrates the use of the XorEncryptionStream decorator (see above)
        /// for encrypting and decrypting data written to a file stream.
        /// Note that a StreamWriter/StreamReader pair would also work with a
        /// XorEncryptionStream as the underlying stream, enabling very powerful
        /// scenarios for combining stream decorators with other stream functionality.
        /// </summary>
        private static void XorEncryptionStream()
        {
            const string DATA = @"Hello
......
Xor";

            byte[] buf = Encoding.ASCII.GetBytes(DATA);

            using (FileStream data = new FileStream("encrypted.dat", FileMode.Create))
            using (XorEncryptionStream encryptor = new XorEncryptionStream(data, 37))
            {
                encryptor.Write(buf, 0, buf.Length);
                //encryptor.Close();
            }

            using (FileStream data = new FileStream("encrypted.dat", FileMode.Open))
            using (XorEncryptionStream decryptor = new XorEncryptionStream(data, 37))
            using (StreamReader reader = new StreamReader(decryptor))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                //decryptor.Close();
            }
        }

        #endregion // XorEncryptionStream

        #region CompositeOutputStream

        /// <summary>
        /// Demonstrates the use of the CompositeOutputStream stream adapter (see above)
        /// by directing output to the standard output stream and the standard error stream
        /// simultaneously.
        /// </summary>
        private static void CompositeOutputStream()
        {
            Stream consoleStream = Console.OpenStandardOutput();
            using (Stream stream = File.OpenWrite("tmp.txt"))
            using (Stream stream1 = File.OpenWrite("tmp1.txt"))
            using (CompositeOutputStream output = new CompositeOutputStream(
                    consoleStream,
                    stream,
                    stream1))
            using (var w = new StreamWriter(output))
            {
                //byte[] buffer = Encoding.UTF8.GetBytes("Hello World");
                //output.Write(buffer, 0, buffer.Length);
                w.WriteLine("Hello World");
            }
        }

        #endregion // CompositeOutputStream

        #region CreateRandomEntropy

        public static byte[] CreateRandomEntropy()
        {
            // Create a byte array to hold the random value.
            byte[] entropy = new byte[16];

            // Create a new instance of the RNGCryptoServiceProvider (random number generator).
            // Fill the array with a random value.
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(entropy);

            // Return the array.
            return entropy;
        }

        #endregion // CreateRandomEntropy

        #region RealEncryption

        /// <summary>
        /// real encryption sample
        /// </summary>
        private static void RealEncryption()
        {
            const string DATA_STORAGE = "data.encrypt";
            const string DATA = @"Hello
......
World";

            File.Delete(DATA_STORAGE);

            #region Get the cipher (byte[] key = ..., byte[] iv = ...)

            const string KEY_STORAGE = "key.secure";
            byte[] salting = Encoding.UTF8.GetBytes("Some salting");
            byte[] key = null;
            byte[] iv = null;
            if (File.Exists(KEY_STORAGE))
            {
                using (var srm = File.OpenRead(KEY_STORAGE))
                using (var reader = new BinaryReader(srm))
                {
                    int kLen = reader.ReadInt32();
                    int ivLen = reader.ReadInt32();
                    var keyBuffer = new byte[kLen];
                    var ivBuffer = new byte[ivLen];
                    reader.Read(keyBuffer, 0, keyBuffer.Length);
                    reader.Read(ivBuffer, 0, ivBuffer.Length);
                    key = ProtectedData.Unprotect(keyBuffer, salting, DataProtectionScope.CurrentUser); // add reference System.Security
                    iv = ProtectedData.Unprotect(ivBuffer, salting, DataProtectionScope.CurrentUser);
                }
            }

            if (key == null || iv == null)
            {
                using (var alg = Aes.Create())
                using (var srm = File.OpenWrite(KEY_STORAGE))
                using (var writer = new BinaryWriter(srm))
                {
                    key = alg.Key;
                    iv = alg.IV;
                    var keyBuffer = ProtectedData.Protect(key, salting, DataProtectionScope.CurrentUser);
                    var ivBuffer = ProtectedData.Protect(iv, salting, DataProtectionScope.CurrentUser);
                    writer.Write(keyBuffer.Length);
                    writer.Write(ivBuffer.Length);
                    writer.Write(keyBuffer);
                    writer.Write(ivBuffer);
                }
            }

            #endregion // Get the cipher (byte[] key = ..., byte[] iv = ...)
            
            using (var alg = Aes.Create())
            {
                alg.Key = key;
                alg.IV = iv;

                using (ICryptoTransform encryptor = alg.CreateEncryptor(alg.Key, alg.IV)) // Encryptor
                using (var srm = File.OpenWrite(DATA_STORAGE))
                using (var cryptStream = new CryptoStream(srm, encryptor, CryptoStreamMode.Write))
                using (var writer = new StreamWriter(cryptStream))
                {
                    writer.Write(DATA);
                }
            }


            Console.WriteLine("--------------------------");
            Console.WriteLine(File.ReadAllText(DATA_STORAGE));
            Console.WriteLine("--------------------------");

            using (var alg = Aes.Create())
            {
                alg.Key = key;
                alg.IV = iv;

                using (ICryptoTransform decryptor = alg.CreateDecryptor(alg.Key, alg.IV)) // Decryptor
                using (var srm = File.OpenRead(DATA_STORAGE))
                using (var cryptStream = new CryptoStream(srm, decryptor, CryptoStreamMode.Read))
                using (StreamReader reader = new StreamReader(cryptStream))
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                }
            }
        }

        #endregion // XorEncryptionStream

        #region Compression

        private static void Compression()
        {
            const string FILE_NAME = "data.copressed";

            string greeting = @"Good 
.....
afternoon";

            using (var srm = File.OpenWrite(FILE_NAME))
            using (var zip = new GZipStream(srm, CompressionMode.Compress))
            using (var writer = new StreamWriter(zip))
            {
                writer.WriteLine(greeting);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine(File.ReadAllText(FILE_NAME));
            Console.WriteLine("--------------------------");

            using (var srm = File.OpenRead(FILE_NAME))
            using (var zip = new GZipStream(srm, CompressionMode.Decompress))
            using (StreamReader reader = new StreamReader(zip))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }

        #endregion // Compression
    }
}
