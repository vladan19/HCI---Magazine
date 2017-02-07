using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Controller {
    class StatusUtility {
        public static string Name(int id) {
            switch (id) {
                case 1:
                    return "In progress";
                default:
                    return "Error";
            }
        }

        public static int newID(int id) {
            switch (id) {
                case 1:
                    return 1;
                default:
                    return -1;
            }
        }
    }
}
