using System;
using System.IO;
using System.Collections.Generic;
namespace FilesFolder;
class program
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\SuryaKaranRaja\OneDrive - Syncfusion\Desktop\New folder";

        string folderPath=path+"/New folder";
        string filePath=path+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            string folder=path+"/New Folder";
            Directory.CreateDirectory(folder);
        }
        else
        {
            Console.WriteLine("Directory Found !");
        }
        if(!File.Exists(filePath))
        {
            string file=path+"/newFile.txt";
            File.Create(file);
        }
        else{
            Console.WriteLine("File Already Exist");
        }


        Console.WriteLine("Select option 0.Exit 1.Create Folder 2.Create File 3.Delete Folder 4.Delete File");
        int num=int.Parse(Console.ReadLine());
        switch(num)
        {
            case 0:
            {
                break;
            }
            case 1:
            {
                Console.WriteLine("Enter Folder name do you want to Create : " );
                string name1=Console.ReadLine();
                string newPath=path+'\\'+name1;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    Console.WriteLine("Directory Name Already Exist");
                }
                break;
            }
            case 2:
            {
                Console.WriteLine("Enter File name do you Want to Create =");
                string name1=Console.ReadLine();
                Console.WriteLine("Enter The File Extension Do you want to Create =" );
                string  name2=Console.ReadLine();
                string newPath=path+'\\'+name1+'.'+name2;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else{
                    Console.WriteLine("File Name Already Exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Select Folder do you want to Delete");
                string name1=Console.ReadLine();
                string newPath=path+'\\'+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                        Directory.Delete(newPath);
                        Console.WriteLine("Folder Deleted");
                    }
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Select file do you want to select");
                string name1=Console.ReadLine();
                Console.WriteLine("Enter the File Extension Do you Want to select :");
                string name2=Console.ReadLine();

                string newPath=path+'\\'+name1+'.'+name2;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                        File.Delete(newPath);
                        Console.WriteLine("File Deleted");
                        

                    }
                }

                break;
            }
        }
        
    }
}
