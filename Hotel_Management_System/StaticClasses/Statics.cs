using System;

namespace Hotel_Management_System
{
    internal static class Statics
    {
        public static bool newUser;

        public static int hotelIdTKN;
        public static int employeeIdTKN;
        public static int tempEmpId;

        public static String uname;
        public static String tempUname;
        public static String pass;
        public static String hotelNameAndId;
        public static String employeeNameAndId;

        //public static void isNewUser(bool flag) => newUser = flag;

        //public static void setHotelId(int id) => hotelIdTKN = id;
        //public static void setEmployeeId(int id) => employeeIdTKN = id;
        //public static void setTempEmplId(int id) => tempEmpId = id;

        //public static void setUname(String str) => uname = str;
        //public static void setTempUname(String s) => tempUname = s;
        //public static void setPass(String str) => pass = str;

        public static void hotelNameId(int id, String name) => hotelNameAndId = name + id;

        public static void EmployeeNameId(int id, String name) => employeeNameAndId = name + id;

    }

}
