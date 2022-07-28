using System;
using System.IO;
namespace ReadWriteTextFile;
class program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine("Folder Created");
        }
        else
        {
            Console.WriteLine("Folder Exist");
            if(!File.Exists("TestFolder/Test.txt"))
            {
                File.Create("TestFolder/Test.txt");
                Console.WriteLine("File Created");
            }
            else
            {
                Console.WriteLine("File Found");
            }
           
        }
        Console.WriteLine("Select Your option 1.Read File info 2.Write File Info");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try
                {
                    //Pass the file path and file name to the StreamReader Constructor
                    sr=new StreamReader("TestFolder/Text.txt");
                    //Read the first line
                    line=sr.ReadLine();
                    
                    while(line!=null)
                    {
                        //write the line to console Window
                        Console.WriteLine(line);
                        //Read the next line
                        line=sr.ReadLine();
                    }

                }
                catch (Exception e)
                { 
                    Console.WriteLine("Exception:" +e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing Finally Block");
                    sr.Close();
                }

                break;
                }
                case 2:
                {
                    StreamWriter sw=null;
                    try
                        {
                        string [] old= File.ReadAllLines("TestFolder/Test.txt");
                        //Pass the filepath and filename to the streamWriter Constructor
                        sw=new StreamWriter("TestFolder/Text.txt");
                        Console.WriteLine("Enter new Content to be laced in file");

                        string info=Console.ReadLine();

                        string old1="";
                        foreach(string text in old)
                        {
                            old1=old1+"\n"+info;

                        }
                        old1=old1+'\n'+info;
                        sw.WriteLine(old1);
                        }
                    catch(Exception e)
                    {
                        Console.WriteLine("Exception: "+e.Message);
                    }
                    finally
                    {
                        sw.Close();

                    }
                    break;
                }
                
            }

        }

    }


