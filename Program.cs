using System;
using SOLID.Controllers;
using SOLID.Entities;
using SOLID.Repositories;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            IStaffRepository staffRepository = new StaffRepository();
            IDoctorRepository doctorRepository = new DoctorRepository();
            ISurgonRepository surgonRepository = new SurgonRepository();
            IOtherStaffRepository otherStaffRepository = new OtherStaffRepository();
            var staffController = new StaffController(staffRepository);
            var doctorController = new DoctorController(doctorRepository, staffController);
            var surgonController = new SurgonController(surgonRepository, doctorController);
            var otherStaffController = new OtherStaffController(otherStaffRepository, staffController);
            while (true)
            {
                Console.WriteLine("1. Staff    2. Doctor    3. OtherStaff");
                int choice = Convert.ToInt32(Console.ReadLine());
                bool flag = false;
                switch (choice)
                {
                    case 1: // Staff
                        {
                            while (true)
                            {
                                Console.Write("1. List    2. Back\n");
                                int choice1 = Convert.ToInt32(Console.ReadLine());
                                bool done = false;
                                switch (choice1)
                                {
                                    case 1:
                                        {
                                            staffController.Index();
                                            break;
                                        }
                                    default:
                                        {
                                            done = true;
                                            break;
                                        }
                                }
                                if (done)
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    case 2: // Doctor
                        {
                            Console.Write("1. Any Doctor    2. Surgon\n");
                            int choice2 = Convert.ToInt32(Console.ReadLine());
                            if (choice2 == 1)
                            {
                                while (true)
                                {
                                    Console.Write("1. Create    2. Edit    3. Delete    4. List    5. status    6. Back\n");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    bool done = false;
                                    switch (choice1)
                                    {
                                        case 1:
                                            {
                                                Console.Write("Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Name: ");
                                                string name = Console.ReadLine();
                                                Console.Write("Enter Email: ");
                                                string email = Console.ReadLine();
                                                Console.Write("Enter Phone No: ");
                                                string phoneNo = Console.ReadLine();
                                                Console.Write("Enter Salary: ");
                                                int salary = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Specialization: ");
                                                String specialization = Console.ReadLine();
                                                IDoctor doctor = new Doctor(id, name, email, phoneNo, salary, specialization);
                                                doctorController.Create(doctor);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Write("Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Name: ");
                                                string name = Console.ReadLine();
                                                Console.Write("Enter Email: ");
                                                string email = Console.ReadLine();
                                                Console.Write("Enter Phone No: ");
                                                string phoneNo = Console.ReadLine();
                                                Console.Write("Enter Salary: ");
                                                int salary = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Specialization: ");
                                                String specialization = Console.ReadLine();
                                                IDoctor doctor = new Doctor(id, name, email, phoneNo, salary, specialization);
                                                doctorController.Edit(doctor);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.Write("Enter Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                doctorController.Delete(id);
                                                break;
                                            }
                                        case 4:
                                            {
                                                doctorController.Index();
                                                break;
                                            }
                                        case 5:
                                            {
                                                Console.Write("Enter Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                doctorController.WorkingStatus(id);
                                                break;
                                            }
                                        default:
                                            {
                                                done = true;
                                                break;
                                            }
                                    }
                                    if (done)
                                    {
                                        break;
                                    }
                                }
                            }else if(choice2 == 2)
                            {
                                while (true)
                                {
                                    Console.Write("1. Create    2. Edit    3. Delete    4. List    5. status    6. Back\n");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    bool done = false;
                                    switch (choice1)
                                    {
                                        case 1:
                                            {
                                                Console.Write("Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Name: ");
                                                string name = Console.ReadLine();
                                                Console.Write("Enter Email: ");
                                                string email = Console.ReadLine();
                                                Console.Write("Enter Phone No: ");
                                                string phoneNo = Console.ReadLine();
                                                Console.Write("Enter Salary: ");
                                                int salary = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Specialization: ");
                                                String specialization = Console.ReadLine();
                                                ISurgon surgon = new Surgon(id, name, email, phoneNo, salary, specialization);
                                                surgonController.Create(surgon);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Write("Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Name: ");
                                                string name = Console.ReadLine();
                                                Console.Write("Enter Email: ");
                                                string email = Console.ReadLine();
                                                Console.Write("Enter Phone No: ");
                                                string phoneNo = Console.ReadLine();
                                                Console.Write("Enter Salary: ");
                                                int salary = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("Enter Specialization: ");
                                                String specialization = Console.ReadLine();
                                                ISurgon surgon = new Surgon(id, name, email, phoneNo, salary, specialization);
                                                surgonController.Edit(surgon);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.Write("Enter Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                surgonController.Delete(id);
                                                break;
                                            }
                                        case 4:
                                            {
                                                surgonController.Index();
                                                break;
                                            }
                                        case 5:
                                            {
                                                Console.Write("Enter Id: ");
                                                int id = Convert.ToInt32(Console.ReadLine());
                                                surgonController.WorkingStatus(id);
                                                break;
                                            }
                                        default:
                                            {
                                                done = true;
                                                break;
                                            }
                                    }
                                    if (done)
                                    {
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    case 3: // Other staff
                        {
                            while (true)
                            {
                                Console.Write("1. Create    2. Edit    3. Delete    4. List    \n");
                                int choice1 = Convert.ToInt32(Console.ReadLine());
                                bool done = false;
                                switch (choice1)
                                {
                                    case 1:
                                        {
                                            Console.Write("Id: ");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Name: ");
                                            string name = Console.ReadLine();
                                            Console.Write("Enter Email: ");
                                            string email = Console.ReadLine();
                                            Console.Write("Enter Phone No: ");
                                            string phoneNo = Console.ReadLine();
                                            Console.Write("Enter Salary: ");
                                            int salary = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Work Hours: ");
                                            int workHours = Convert.ToInt32(Console.ReadLine());
                                            IOtherStaff otherStaff = new OtherStaff(id, name, email, phoneNo, salary, workHours);
                                            otherStaffController.Create(otherStaff);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Id: ");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Name: ");
                                            string name = Console.ReadLine();
                                            Console.Write("Enter Email: ");
                                            string email = Console.ReadLine();
                                            Console.Write("Enter Phone No: ");
                                            string phoneNo = Console.ReadLine();
                                            Console.Write("Enter Salary: ");
                                            int salary = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Work Hours: ");
                                            int workHours = Convert.ToInt32(Console.ReadLine());
                                            IOtherStaff otherStaff = new OtherStaff(id, name, email, phoneNo, salary, workHours);
                                            otherStaffController.Edit(otherStaff);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Enter Id: ");
                                            int id = Convert.ToInt32(Console.ReadLine());
                                            otherStaffController.Delete(id);
                                            break;
                                        }
                                    case 4:
                                        {
                                            otherStaffController.Index();
                                            break;
                                        }
                                    default:
                                        {
                                            done = true;
                                            break;
                                        }
                                }
                                if (done)
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    default:
                        {
                            flag = true;
                            break;
                        }
                }
                if (flag)
                {
                    break;
                }
            }
        }
    }
}