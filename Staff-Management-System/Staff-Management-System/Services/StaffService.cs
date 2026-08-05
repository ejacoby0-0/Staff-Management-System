using Staff_Management_System.Models;

namespace Staff_Management_System.Services
{
    public class StaffService
    {

        //In-memory collection to store staff member records
        static public List<StaffMember> staffMemberRecords = new List<StaffMember>();


        //1. Function for adding staff members
        public static void AddStaffMember()
        {
            Console.Write("\nEnter staff member ID: ");
            string staffId = Console.ReadLine();

            Console.Write($"\nEnter staff member full name: ");
            string fullName = Console.ReadLine();

            Console.Write($"\nEnter staff member email: ");
            string email = Console.ReadLine();

            Console.Write($"\nEnter staff member position: ");
            string postiton = Console.ReadLine();

            Console.Write($"\nEnter staff member unit: ");
            string unit = Console.ReadLine();

            //Creates a new object for the StaffMember class & assign variable newStaffMember
            StaffMember newStaffMember = new StaffMember
            {
                StaffId = staffId,
                FullName = fullName,
                Email = email,
                Postiton = postiton,
                Unit = unit
            };

            //newStaffMember are added to the end of the staffMemberRecords linked list
            staffMemberRecords.Add(newStaffMember);

            Console.WriteLine("\nStaff Member added successfully");

        }








    }
}
