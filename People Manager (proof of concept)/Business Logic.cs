using System;
using System.Linq;

namespace Windows_Forms_Application {
    internal class Business_Logic {
        private static bool CheckDaysWithMonth(byte days, byte month, short year) {
            if (month != 2)
                return month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 ? days <= 31 : days <= 30;

            return DateTime.IsLeapYear(year) ? month <= 29 : month <= 28;
        }

        internal static bool CheckNationalIDNumber(string id, bool isMale) {
            //Checking length:
            if (id.Length != 14)
                return false;

            //Checking century number:
            if (id[0] - 48 < 2 || id[0] - 48 > 3)
                return false;

            //Checking date of birth:
            byte month = Convert.ToByte(id.Substring(3, 2));
            if (month == 0 || month > 12)
                return false;

            short year = (short) ((id[0] - 48 == 2 ? 1900 : 2000) + Convert.ToInt32(id.Substring(1, 2)));
            if (year > DateTime.Today.Year || !CheckDaysWithMonth(Convert.ToByte(id.Substring(5, 2)), month, year))
                return false;

            //Checking governorate code:
            byte[] governorateCodes = { 1, 2, 3, 4, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29, 31, 32, 33, 34, 35 };
            if (!governorateCodes.Contains(Convert.ToByte(id.Substring(7, 2))))
                return false;

            //Checking gender:
            return true;
        }

        internal static bool CheckDateOfBirthWithID(DateTime dateOfBirth, string id) {
            if (dateOfBirth.Day != Convert.ToInt32(id.Substring(5, 2)) || dateOfBirth.Month != Convert.ToInt32(id.Substring(3, 2)))
                return false;

            return dateOfBirth.Year == (short) ((id[0] - 48 == 2 ? 1900 : 2000) + Convert.ToInt32(id.Substring(1, 2)));
        }
    }
}
