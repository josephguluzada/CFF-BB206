namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\asus\\Desktop\\BB206Dir";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            directoryInfo.Create();

            //foreach (var dr in directoryInfo.GetDirectories())
            //{
            //    Console.WriteLine($"{dr.Name} :");
            //    foreach (var file in dr.GetFiles())
            //    {
            //        Console.WriteLine("Yazilar:");
            //        foreach (var item in File.ReadAllLines(file.FullName))
            //        {
            //            Console.WriteLine(item);
            //        }
            //    }
            //}

            FileInfo fileInfo = new FileInfo(path + "\\Yusif.txt");

            if (!fileInfo.Exists)
            {
                fileInfo.Create().Close();
            }

            string[] strings = { "BB206", "bugun", "yaman", "xoshbekhtsiniz!" };
            File.WriteAllLines(fileInfo.FullName, strings);


            var str = File.ReadAllLines(fileInfo.FullName);

            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            //if (fileInfo.Name == "Yusif.txt")
            //{
            //    fileInfo.Delete();
            //}
        }
    }
}