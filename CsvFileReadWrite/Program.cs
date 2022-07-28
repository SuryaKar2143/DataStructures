using System;
using System.IO;
namespace CsvFileReadWrite;
class program
{
    public static void Main(string[] args)
    {
        List<Student> vlist=new List<Student>();
        vlist.Add(new Student(){Name="Surya Karan",FatherName="Raja",Gender=Gender.Male,DOB=new DateTime(1997,09,16)});
        vlist.Add(new Student(){Name="Tharani",FatherName="Raja A",Gender=Gender.Female,DOB=new DateTime(2000,05,18)});
        vlist.Add(new Student(){Name="Vikram",FatherName="Kamal",Gender=Gender.Male,DOB=new DateTime(1990,11,18)});
        Insert(vlist);
        Display();
        Update();



    }

    static void Insert(List<Student> vlist)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            Console.WriteLine("File doesn't exist.Creating a new CSV file");
            // var fs=File.open("out.csv",FileMode.OpenOrCreate); fs.Close();
            File.Create("Data.csv");

        }
        else
        {
            write=new StreamWriter(File.OpenWrite("Data.csv"));
            foreach(var v in vlist)
            {
                write.WriteLine(v.Name+","+v.FatherName+','+v.Gender+','+v.DOB.ToString("dd/MM/yyyy"));
            }
            write.WriteLine();


        }
        write.Close();

    }

    static void Display()
    {
        StreamReader reader=null;
        List<Student> listA=new List<Student>();
        if(File.Exists("Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("Data.csv"));
            while(!reader.EndOfStream)
            {
                var line=reader.ReadLine();
                var values=line.Split(',');
                if(values[0]!="")
                {
                    listA.Add(new Student(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});

                }
                
            }
            
        }
        else
            {
                Console.WriteLine("File Does not Exist");            
                
            }
        reader.Close();
        foreach(var coloumn1 in listA)
        {
            Console.WriteLine("Your Name    :\t"+coloumn1.Name+"\tFather Name   :\t"+coloumn1.FatherName+"\tGender  :\t"+coloumn1.Gender+"\tDOB     :\t"+coloumn1.DOB);

        }

    }
    static void Update()
    {
        Console.WriteLine("To update Select option 0.your Name1 1.Father Name");
        int option= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name To be Updated :");
        string name=Console.ReadLine();

        string [] lines=File.ReadAllLines("Data.csv");
        for(int i=0;i<lines.Length;i++)
        {
            if(lines[i]!="")
            {
                var values=lines[i].Split(',');
                if(values[option]==name)
                {
                    Console.WriteLine("Enter new name to update :");
                    string name1=Console.ReadLine();
                    if(option==0)
                    {
                        lines[i]=name1+","+values[1]+","+values[2]+","+values[3];
                    }
                    else if(option==1)
                    {
                        lines[i]=values[0]+","+name1+","+values[2]+","+values[3];

                    }
                }
            }
        }File.WriteAllLines("Data.csv",lines);

    }
}
