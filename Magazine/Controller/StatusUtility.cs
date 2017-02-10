using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Controller {
    class StatusUtility {
        public static string Name(int id) {
            switch (id) {
                case 1: case 2: case 3: case 4:
                    return "In progress";
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

        public static int newID(int id) {
            switch (id) {
                case 1: case 2: case 3: case 4:
                    return 1;
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
