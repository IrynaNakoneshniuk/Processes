using System.Diagnostics;
using System.Reflection;

namespace Child_Process
{
    internal class Program
    {
        static void Task1()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "notepad.exe";
                proc.Start();
                Console.WriteLine("Процес: " + proc.
                 ProcessName);
                proc.WaitForExit();
                Console.WriteLine("Код завершення: " +
                 proc.ExitCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        static void Task3()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "OperationWithCommandArg.exe";
                proc.StartInfo.Arguments = "1 2 +";
                proc.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void Task4()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "FileRead.exe";
            proc.StartInfo.Arguments ="TextFile1.txt Process";
            proc.Start();
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task3();
            Task4();
        }
    }
}