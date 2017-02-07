using Magazine.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Controller {
    class PaperController {
        public static List<paper> GetPapers(user user) {
            return AccountController.entities.papers.Where(p => p.Author == user.id).ToList();
        }

        public static List<file> GetSubmissions(paper p) {
            return p.files.ToList();
        }

        public static void UploadSubmission(paper p, string filePath) {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string[] list = filePath.Split('\\');
            string extension = list[list.Length - 1].Split('.')[1];
            file f = new file();
            f.Content = fileBytes;
            f.Extension = extension;
            f.paper = p;
            AccountController.entities.files.Add(f);
            AccountController.entities.SaveChanges();
        }
    }
}
