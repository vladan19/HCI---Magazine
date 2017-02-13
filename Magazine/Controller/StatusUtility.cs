using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Controller {
    class StatusUtility {
        public static string Name(int id) {
            switch (id) {
                case 1: case 2: case 3: case 4: case 6: case 8:
                    return "In progress";
                case 5:
                    return "Returned";
                case 7:
                    return "Returned for final edit";
                case 9:
                    return "Published";
                case 10:
                    return "Rejected";
                case 11:
                    return "Canceled";
                default:
                    return "Error";
            }
        }

        public static string NameReview(int id) {
            switch (id) {
                case 2:
                    return "Needs review";
                case 3:
                    return "Accepted";
                case 4:
                    return "Rejected";
                default:
                    return "Error";
            }
        }

        public static int newIDEditor(int id) {
            switch (id) {
                case 1: case 6: case 8: case 4: case 3:
                    return 2;
                case 10: case 11:
                    return 3;
                case 9:
                    return 1;
                case 2: case 5: case 7:
                    return 4;
                default:
                    return -1;
            }
        }

        public static int newID(int id) {
            switch (id) {
                case 1: case 2: case 3: case 4: case 6: case 8:
                    return 1;
                case 5: case 7:
                    return 2;
                case 9:
                    return 3;
                case 10: case 11:
                    return 4;
                default:
                    return -1;
            }
        }

        public static int newIDReview(int id) {
            switch (id) {
                case 2:
                    return 3;
                case 3:
                    return 1;
                case 4:
                    return 2;
                default:
                    return -1;
            }
        }
    }
}
