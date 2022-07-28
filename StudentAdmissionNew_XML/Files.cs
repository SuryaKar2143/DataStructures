using System;

using System.IO;
namespace StudentAdmissionNew;
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                Console.WriteLine("Create File");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                Console.WriteLine("Create File");
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                Console.WriteLine("Create File");
                File.Create("College/AdmissionDetails.csv");
            }
            
        }
         public static void ReadFile()
        {
            string[] students= File.ReadAllLines("College/StudentDetails.csv");
            string[] departments= File.ReadAllLines("College/departmentDetails.csv");
            string[] admission= File.ReadAllLines("College/admissionDetails.csv");

            Operation.studentList= CreateStudentObjects(students);
            Operation.departmentList=CreateDepartmentObjects(departments);
            Operation.admissionList=CreateAdmissionObjects(admission);

        }

        public static List<StudentDetail> CreateStudentObjects(string[] students)
        {
            List<StudentDetail> studentList=new List<StudentDetail>();
            foreach(string data in students)
            {
                StudentDetail student=new StudentDetail(data);
                studentList.Add(student);
            }
            return studentList;
        }

        public static List<DepartmentDetail> CreateDepartmentObjects(string[] departments)
        {
            List<DepartmentDetail> departmentList=new List<DepartmentDetail>();
            foreach(string data in departments)
            {
                DepartmentDetail department=new DepartmentDetail(data);
                departmentList.Add(department);
            }
            return departmentList;
        }

        public static List<AdmissionDetail> CreateAdmissionObjects(string[] admissions)
        {
            List<AdmissionDetail> admissionList=new List<AdmissionDetail>();
            foreach(string data in admissions)
            {
                AdmissionDetail admission=new AdmissionDetail(data);
                admissionList.Add(admission);

            }
            
            
            return admissionList;


        }

        public static void WriteToFile()
        {
            string[] studentDetails=new string[Operation.studentList.Count];
            string[] departmentDetails=new string[Operation.departmentList.Count];
            string[] admissionDetails=new string[Operation.admissionList.Count];
            for(int i=0;i<Operation.studentList.Count;i++)
            {
                studentDetails[i]=Operation.studentList[i].StudentId+","+Operation.studentList[i].Name+","+Operation.studentList[i].Father+","+Operation.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operation.studentList[i].Gender+","+Operation.studentList[i].Physics+","+Operation.studentList[i].Chemistry+","+Operation.studentList[i].Maths;
            }
            for(int i=0;i<Operation.departmentList.Count;i++)
            {
                departmentDetails[i]=Operation.departmentList[i].DepartmentId+","+Operation.departmentList[i].DepartmentName+","+Operation.departmentList[i].NumOfSeats;
            }
            for(int i=0;i<Operation.admissionList.Count;i++)
            {
                admissionDetails[i]=Operation.admissionList[i].AdmissionId+","+Operation.admissionList[i].DepartmentId+","+Operation.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operation.admissionList[i].Status;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);
            File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);
            File.WriteAllLines("College/admissionDetails.csv",admissionDetails);

        }
    }
        
    

   
